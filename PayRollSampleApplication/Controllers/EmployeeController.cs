using AutoMapper;
using FluentValidation;
using FluentValidation.AspNetCore;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PayRollSampleApplication.Contracts;
using PayRollSampleApplication.Data;
using PayRollSampleApplication.Entities.DTOS;
using PayRollSampleApplication.Entities.Models;
using System.Security;
using System.Security.Permissions;

namespace PayRollSampleApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]

    public class EmployeeController : ControllerBase
    {
        private readonly IRepository<Employee, int> _employeeRepository;
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _hostEnvironment;
        private IValidator<AddOrUpdateEmployeeDto> _validator;

        public EmployeeController(IRepository<Employee, int> employeeRepository, ApplicationDbContext context,
            IMapper mapper, IWebHostEnvironment hostEnvironment, IValidator<AddOrUpdateEmployeeDto> validator)
        {
            _employeeRepository = employeeRepository;
            _context = context;
            _mapper = mapper;
            _hostEnvironment = hostEnvironment;
            _validator = validator;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var employees = await  _context.Employees.AsQueryable()
                                     .Include(c => c.EmployeeAttachments)
                                     .Include(c => c.SalaryDetails)
                                     .Include(c => c.Dependents).ToListAsync();
                var employeesDto = _mapper.Map<IEnumerable<EmployeeDto>>(employees);
                return Ok(employeesDto);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var employee = await _context.Employees.AsQueryable()
                                     .Include(c => c.EmployeeAttachments)
                                     .Include(c => c.SalaryDetails)
                                     .Include(c => c.Dependents)
                                     .AsNoTracking().FirstOrDefaultAsync(a => a.EmployeeId == id);

                if (employee == null) return BadRequest("employee id not found");
                var employeeDto = _mapper.Map<EmployeeDto>(employee);
                return Ok(employeeDto);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        [Authorize(Roles = "HrManager")]

        public async Task<IActionResult> Post([FromBody] AddOrUpdateEmployeeDto employeeDto)
        {
            ValidationResult result = await _validator.ValidateAsync(employeeDto);

            if (!result.IsValid)
            {
                result.AddToModelState(this.ModelState);
                return BadRequest(ModelState);
            }

            try
            {
                UploadFiles(employeeDto.EmployeeAttachments);
                var employee = _mapper.Map<Employee>(employeeDto);
                employee.JobStatusId = SetJobStatus(employee.JoinDate, employee.EndDate);
                employee.Dependents = _mapper.Map<List<Dependent>>(employeeDto.Dependents);
                employee.SalaryDetails = _mapper.Map<List<SalaryDetail>>(employeeDto.SalaryDetails);
                foreach (var item in employee.SalaryDetails)
                {
                    item.EffectiveDate = employeeDto.JoinDate.HasValue ? employeeDto.JoinDate.Value : null;
                }
                employee.EmployeeAttachments = _mapper.Map<List<EmployeeAttachment>>(employeeDto.EmployeeAttachments);
                await _employeeRepository.Add(employee);
                await _employeeRepository.SaveChangesAsync();
                return Ok(employee.EmployeeId);
            }
            catch (Exception ex)
            {
                if (ex.InnerException is not null)
                    throw new Exception(ex.InnerException.Message);
                else throw new Exception(ex.Message);
            }
        }

        [HttpPut]
        [Authorize(Roles = "HrManager")]
        public async Task<IActionResult> Put([FromBody] AddOrUpdateEmployeeDto employeeDto)
        {
            ValidationResult result = await _validator.ValidateAsync(employeeDto);
            if (!result.IsValid)
            {
                result.AddToModelState(this.ModelState);
                return BadRequest(ModelState);
            }

            try
            {
                var emp = await _context.Employees.AsQueryable()
                                    .Include(c => c.EmployeeAttachments)
                                    .Include(c => c.SalaryDetails)
                                    .Include(c => c.Dependents)
                                    .FirstOrDefaultAsync(a => a.IdentifierNumber == employeeDto.IdentifierNumber);

                if (emp == null) return BadRequest("employee id not found");

                UploadFiles(employeeDto.EmployeeAttachments);
                employeeDto.JobStatusId = employeeDto.JobStatusId is null ?
                  SetJobStatus(employeeDto.JoinDate, employeeDto.EndDate) : employeeDto.JobStatusId;

                _ = _mapper.Map(employeeDto, emp);
                var res = await _employeeRepository.SaveChangesAsync();
                return Ok(res);
            }
            catch (Exception ex)
            {
                if (ex.InnerException is not null)
                    throw new Exception(ex.InnerException.Message);
                else throw new Exception(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "HrManager")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var employee = await _context.Employees.AsQueryable()
                                    .Include(c => c.EmployeeAttachments)
                                    .Include(c => c.SalaryDetails)
                                    .Include(c => c.Dependents)
                                    .AsNoTracking().FirstOrDefaultAsync(a => a.EmployeeId == id);

                if (employee == null) return BadRequest("employee id not found");
                foreach (var item in employee.EmployeeAttachments)
                {
                    string path = item.FilePath;
                    System.IO.File.Delete(path);
                }
                _employeeRepository.Delete(id);
                return Ok(await _employeeRepository.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                if (ex.InnerException is not null)
                    throw new Exception(ex.InnerException.Message);
                else throw new Exception(ex.Message);
            }
        }

        private static int SetJobStatus(DateTime? joinDate, DateTime? endDate)
        {
            if (joinDate is null && endDate is null)
                return (int)Enums.JobStatus.NotYetStarted;

            if (joinDate is not null && endDate is not null)
                return (int)Enums.JobStatus.NotWorking;

            if (joinDate!.Value.Date >= DateTime.Now.Date || joinDate!.Value.Date < DateTime.Now.Date)
                return (int)Enums.JobStatus.Started;

            return 0;
        }

        private void UploadFiles( IEnumerable<EmployeeAttachmentDto> employeeAttachments)
        {
            var rootPath = _hostEnvironment.ContentRootPath + "/Resources/Images";
            foreach (var file in employeeAttachments)
            {
                byte[] bytes = Convert.FromBase64String(file.File);
                string filePath = $"{rootPath}/{file.FileName}.{file.FileType}";
                file.FilePath = filePath;
                System.IO.File.SetAttributes(filePath, FileAttributes.Normal);
            
                using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite))
                {
                    fileStream.Write(bytes, 0, bytes.Length);
                }
            }
        }
    }
}
