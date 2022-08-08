using AutoMapper;
using MediatR;
using MyLeaveManagement.Application.Features.LeaveRequest.Requests.Commands;
using MyLeaveManagement.Application.Persistence.Contracts;

namespace MyLeaveManagement.Application.Features.LeaveRequest.Handlers.Commands
{
    public class CreateLeaveRequestCommandHandler : IRequestHandler<CreateLeaveRequestCommand,int>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;

        public CreateLeaveRequestCommandHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var leaveRequest = _mapper.Map<Domain.LeaveRequest>(request.LeaveRequestDto);
            leaveRequest = await _leaveRequestRepository.Add(leaveRequest);
            return leaveRequest.Id;
        }
    }
}
