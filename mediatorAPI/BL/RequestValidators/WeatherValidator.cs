using FluentValidation;
using mediatorAPI.Protocol.Interfaces;
using mediatorAPI.Protocol.Requests;

namespace mediatorAPI.BL.RequestValidators;

public class GetWeatherRequestValidator  : AbstractValidator<GetWeatherRequest>
{
    public GetWeatherRequestValidator (IWeatherRepository weatherRepository)
    {
        RuleFor(x => x.LocationName)
            .MaximumLength(20).WithMessage("Location name is too long.")
            .NotEmpty().WithMessage("Location name is required.")
            .Must(x => weatherRepository.GetLocations().Contains(x)).WithMessage("Location name is not valid.");
    }
}