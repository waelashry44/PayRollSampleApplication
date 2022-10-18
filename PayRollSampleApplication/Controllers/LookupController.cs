using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PayRollSampleApplication.Contracts;
using PayRollSampleApplication.Data;
using PayRollSampleApplication.Entities.DTOS;
using PayRollSampleApplication.Entities.Models;

namespace PayRollSampleApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LookupController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public LookupController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("GetDepartments")]
        public async Task<IActionResult> GetDepartments()
        {
            try
            {
                var departments = await _context.Departments
                    .Include(c => c.JobPositions).ToListAsync();
                var departmentsDto = _mapper.Map<IEnumerable<DepartmentDto>>(departments);

                return Ok(departmentsDto);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("GetPositions")]
        public async Task<IActionResult> GetPositions()
        {
            try
            {
                var positions = await _context.JobPositions.ToListAsync();
                var jobPositions = _mapper.Map<IEnumerable<JobPositionsDto>>(positions);

                return Ok(jobPositions);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("GetPositionByDeptId")]
        public async Task<IActionResult> GetPositionByDepartmentId(int departmentId)
        {
            try
            {
                var jobPositions = await _context.JobPositions.Where(a => a.DepartmentId == departmentId).ToListAsync();
                var jobPositionsDto = _mapper.Map<IEnumerable<JobPositionsDto>>(jobPositions);
                return Ok(jobPositionsDto);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}
