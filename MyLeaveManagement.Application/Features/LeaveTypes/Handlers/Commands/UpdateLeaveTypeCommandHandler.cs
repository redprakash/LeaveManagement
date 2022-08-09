using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FluentValidation;
using MediatR;
using MyLeaveManagement.Application.DTOs.LeaveType.Validator;
using MyLeaveManagement.Application.Features.LeaveTypes.Requests.Commands;
using MyLeaveManagement.Application.Persistence.Contracts;

namespace MyLeaveManagement.Application.Features.LeaveTypes.Handlers.Commands
{
    public class UpdateLeaveTypeCommandHandler: IRequestHandler<UpdateLeaveTypeCommand, Unit>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public UpdateLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateLeaveTypeDtoValidator();
            var validatorResult = await validator.ValidateAsync(request.LeaveTypeDto);
            if (!validatorResult.IsValid)
                throw new Exception();

            var leaveType = await _leaveTypeRepository.Get(request.LeaveTypeDto.Id);
            _mapper.Map(request.LeaveTypeDto, leaveType);
            await _leaveTypeRepository.Update(leaveType);
            return Unit.Value;
        }
    }
}
