using AutoMapper;
using MyLeaveManagement.Application.DTOs.LeaveRequest;
using MyLeaveManagement.Application.DTOs.LeaveType;
using MyLeaveManagement.Domain;

namespace MyLeaveManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestListDto>().ReverseMap();
            CreateMap<LeaveType, LeaveTypeDto>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveRequestDto>().ReverseMap();
        }
    }
}
