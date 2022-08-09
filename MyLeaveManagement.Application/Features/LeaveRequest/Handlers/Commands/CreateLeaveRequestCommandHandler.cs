﻿using AutoMapper;
using MediatR;
using MyLeaveManagement.Application.DTOs.LeaveRequest.Validator;
using MyLeaveManagement.Application.Features.LeaveRequest.Requests.Commands;
using MyLeaveManagement.Application.Persistence.Contracts;

namespace MyLeaveManagement.Application.Features.LeaveRequest.Handlers.Commands
{
    public class CreateLeaveRequestCommandHandler : IRequestHandler<CreateLeaveRequestCommand,int>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public CreateLeaveRequestCommandHandler(ILeaveRequestRepository leaveRequestRepository,ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateLeaveRequestDtoValidator(_leaveTypeRepository);
            var validatorResult = await validator.ValidateAsync(request.LeaveRequestDto);
            if (!validatorResult.IsValid)
                throw new Exception();
            var leaveRequest = _mapper.Map<Domain.LeaveRequest>(request.LeaveRequestDto);
            leaveRequest = await _leaveRequestRepository.Add(leaveRequest);
            return leaveRequest.Id;
        }
    }
}
