using FluentValidation;

namespace CleanArchitectureBlazor.Application
{
    public class CreateEventCommandValidator : AbstractValidator<CreateEventCommand>
    {
        public CreateEventCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Event name is required.")
                .MaximumLength(100).WithMessage("Event name cannot exceed 100 characters.");
            RuleFor(x => x.Date)
                .GreaterThan(DateTime.Now).WithMessage("Event date must be in the future.");
            RuleFor(x => x.Capacity)
                .GreaterThan(0).WithMessage("Event capacity must be greater than zero.");
            RuleFor(x => x.Description)
                .MaximumLength(500).WithMessage("Event description cannot exceed 500 characters.");
        }
    }
}
