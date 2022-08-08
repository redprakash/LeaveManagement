using AutoMapper;
using MediatR;
using MyLeaveManagement.Application.DTOs.LeaveRequest;
using MyLeaveManagement.Application.Features.LeaveRequest.Requests.Queries;
using MyLeaveManagement.Application.Persistence.Contracts;

namespace MyLeaveManagement.Application.Features.LeaveRequest.Handlers.Queries
{
    public class GetLeaveRequestListRequestHandler : IRequestHandler<GetLeaveRequestListRequest,List<LeaveRequestListDto>>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;

        public GetLeaveRequestListRequestHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }
        public async Task<List<LeaveRequestListDto>> Handle(GetLeaveRequestListRequest request, CancellationToken cancellationToken)
        {
            var leaveRequests = await _leaveRequestRepository.GetLeaveRequestsWithDetails();
            return _mapper.Map<List<LeaveRequestListDto>>(leaveRequests);
        }
    }
}
