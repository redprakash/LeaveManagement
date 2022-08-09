using AutoMapper;
using FluentValidation;
using MediatR;
using MyLeaveManagement.Application.DTOs.LeaveType.Validator;
using MyLeaveManagement.Application.Features.LeaveTypes.Requests.Commands;
using MyLeaveManagement.Application.Persistence.Contracts;
using MyLeaveManagement.Domain;
using ValidationException = MyLeaveManagement.Application.Exceptions.ValidationException;

namespace MyLeaveManagement.Application.Features.LeaveTypes.Handlers.Commands
{
    public class CreateLeaveTypeCommandHandler : IRequestHandler<CreateLeaveTypeCommand, int>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public CreateLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateLeaveTypeDtoValidator();
            var validatorResult = await validator.ValidateAsync(request.LeaveTypeDto);
            if (!validatorResult.IsValid)
                throw new ValidationException(validatorResult);

            var leaveType = _mapper.Map<LeaveType>(request.LeaveTypeDto);
            leaveType = await _leaveTypeRepository.Add(leaveType);
            return leaveType.Id;
        }
    }
}
