using AutoMapper;
using MediatR;
using MyLeaveManagement.Application.Features.LeaveAllocation.Requests.Command;
using MyLeaveManagement.Application.Persistence.Contracts;

namespace MyLeaveManagement.Application.Features.LeaveAllocation.Handlers.Command
{
    public class CreateLeaveAllocationCommandHandler : IRequestHandler<CreateLeaveAllocationCommand, int>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly IMapper _mapper;


        public CreateLeaveAllocationCommandHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateLeaveAllocationCommand request, CancellationToken cancellationToken)
        {
            //Map from leaveAllocationDto to LeaveAllocation
            var leaveAllocation = _mapper.Map<Domain.LeaveAllocation>(request.LeaveAllocationDto);
            leaveAllocation = await _leaveAllocationRepository.Add(leaveAllocation);
            return leaveAllocation.Id;
        }
    }
}
