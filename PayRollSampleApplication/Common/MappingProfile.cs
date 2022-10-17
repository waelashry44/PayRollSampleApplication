using AutoMapper;
using Microsoft.AspNetCore.Identity;
using PayRollSampleApplication.Entities.DTOS;
using PayRollSampleApplication.Entities.Models;

namespace PayRollSampleApplication.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RegistrationDto, IdentityUser>();
            CreateMap<DependentDto, Dependent>().ReverseMap();
            CreateMap<EmployeeAttachmentDto, EmployeeAttachment>().ReverseMap();
            CreateMap<SalaryDetailDto, SalaryDetail>().ReverseMap();
            CreateMap<EmployeeDto, Employee>().ReverseMap();
            CreateMap<AddOrUpdateEmployeeDto, Employee>().ReverseMap();
            CreateMap<PaySlipDetailDto, PaySlipDetail>().ReverseMap();
            CreateMap<PaySlipDetail, AllPaySlipDto>().ReverseMap();
        }
    }
}
