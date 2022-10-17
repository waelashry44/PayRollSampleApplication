using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PayRollSampleApplication.Contracts;
using PayRollSampleApplication.Data;
using PayRollSampleApplication.Entities.DTOS;
using PayRollSampleApplication.Entities.Models;
using System.Data;
using JobStatus = PayRollSampleApplication.Enums.JobStatus;

namespace PayRollSampleApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "PayRollManager")]

    public class PaySlipController : ControllerBase
    {
        private readonly IRepository<PaySlipDetail, int> _paySlipRepository;
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public PaySlipController(IRepository<PaySlipDetail, int> paySlipRepository,
            ApplicationDbContext context, IMapper mapper)
        {
            _paySlipRepository = paySlipRepository;
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var employees = await _context.Employees.AsQueryable()
                                    .Include(c => c.PaySlipDetails)
                                    .Include(c => c.SalaryDetails)
                                    .ToListAsync();
                if (employees == null) return BadRequest("no employees found");

                var employeePaySlipDetails = new List<EmployeePaySlipDetails>();
                foreach (var item in employees)
                {
                   var paySlips = item.PaySlipDetails.Where(x => x.EmployeeId == item.EmployeeId).ToList();
                   employeePaySlipDetails.Add( new EmployeePaySlipDetails
                   {
                      EmployeeId = item.EmployeeId,
                      AllPaySlips = _mapper.Map<List<AllPaySlipDto>>(paySlips),
                      SalaryDetails = _mapper.Map<List<SalaryDetailDto>>(item.SalaryDetails)
                   });
                }
                return Ok(employeePaySlipDetails);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> GeneratePaySlip([FromBody] PaySlipDetailDto paySlipDetailDto)
        {
            try
            {
                var employee = await _context.Employees.AsQueryable()
                                     .Include(c => c.PaySlipDetails)
                                     .FirstOrDefaultAsync(a => a.EmployeeId == paySlipDetailDto.EmployeeId);

                if (employee == null) return BadRequest("employee id not found");

                var paySlipDetail = _mapper.Map<PaySlipDetail>(paySlipDetailDto);
                var existPaySlip = employee.PaySlipDetails!.FirstOrDefault(x => x.EmployeeId == paySlipDetail.EmployeeId
                && x.Month == paySlipDetail.Month && x.Year == paySlipDetail.Year);

                if (existPaySlip is not null)
                {
                    _ = _mapper.Map(paySlipDetailDto, existPaySlip);
                    existPaySlip.CreatedDate = DateTime.Now;
                    return Ok(await _paySlipRepository.SaveChangesAsync());
                }

                await _paySlipRepository.Add(paySlipDetail);
                await _paySlipRepository.SaveChangesAsync();
                return Ok(paySlipDetail.Id);
            }
            catch (Exception ex)
            {
                if (ex.InnerException is not null)
                    throw new Exception(ex.InnerException.Message);
                else throw new Exception(ex.Message);
            }
        }

        [HttpPost("GeneratePaySlipForAll")]
        public async Task<IActionResult> GeneratePaySlipForAllWorkingEmployees([FromBody] AllPaySlipDto allPaySlipDto)
        {
            try
            {
                var employees = await _context.Employees.AsQueryable()
                                    .Include(c => c.PaySlipDetails)
                                    .Where(a => a.JobStatusId == (int)JobStatus.Started)
                                    .ToListAsync();

                if (employees == null) return BadRequest("no working employee found");
                if (allPaySlipDto.Month == 0 || allPaySlipDto.Year == 0) return BadRequest("month / year should not be zero");

                List<PaySlipDetail> paySlipList = new List<PaySlipDetail>();

                foreach (var item in employees)
                {
                    var existPaySlip = _context.PaySlipDetails!.FirstOrDefault(x => x.EmployeeId == item.EmployeeId
                                      && x.Month == allPaySlipDto.Month && x.Year == allPaySlipDto.Year);
                    if (existPaySlip is null)
                    {
                        existPaySlip = new PaySlipDetail();
                        existPaySlip.EmployeeId = item.EmployeeId;
                        existPaySlip.Month = allPaySlipDto.Month;
                        existPaySlip.Year = allPaySlipDto.Year;
                        existPaySlip.CreatedDate = DateTime.Now;
                        paySlipList.Add(existPaySlip);
                    }
                }
                await _context.AddRangeAsync(paySlipList);
                await _context.SaveChangesAsync();
                return Ok(paySlipList.Select(x => x.Id).ToList());
            }
            catch (Exception ex)
            {
                if (ex.InnerException is not null)
                    throw new Exception(ex.InnerException.Message);
                else throw new Exception(ex.Message);
            }
        }
    }
}
