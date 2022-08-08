using AutoMapper;
using MediatR;
using MyLeaveManagement.Application.DTOs.LeaveAllocation;
using MyLeaveManagement.Application.Features.LeaveAllocation.Requests.Queries;
using MyLeaveManagement.Application.Persistence.Contracts;

namespace MyLeaveManagement.Application.Features.LeaveAllocation.Handlers.Queries
{
    public class GetLeaveAllocationRequestDetailHandler : IRequestHandler<GetLeaveAllocationRequestDetail, LeaveAllocationDto>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly IMapper _mapper;

        public GetLeaveAllocationRequestDetailHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            _mapper = mapper;
        }
        public async Task<LeaveAllocationDto> Handle(GetLeaveAllocationRequestDetail request, CancellationToken cancellationToken)
        {
            var leaveAllocation = await _leaveAllocationRepository.GetLeaveAllocationWithDetails(request.Id);
            return _mapper.Map<LeaveAllocationDto>(leaveAllocation);
        }
    }
}
