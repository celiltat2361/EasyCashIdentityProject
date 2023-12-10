using EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.ValidationRules.AppUserValidationRules
{
	public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
	{
		public AppUserRegisterValidator()
		{
			RuleFor(x => x.Name).NotEmpty().WithMessage("Name required");
			RuleFor(x => x.Surname).NotEmpty().WithMessage("Surname required");
			RuleFor(x => x.UserName).NotEmpty().WithMessage("User name required");
			RuleFor(x => x.Email).NotEmpty().WithMessage("Email required");
			RuleFor(x => x.Password).NotEmpty().WithMessage("Password required");
			RuleFor(x => x.Surname).NotEmpty().WithMessage("Comfirm Password required");
			RuleFor(x => x.Name).MaximumLength(30).WithMessage("It must be Maximum 30 character");
			RuleFor(x => x.Name).MinimumLength(2).WithMessage("It must be Minimum 2 character");
			RuleFor(x => x.ComfirmPassword).Equal(y => y.Password).WithMessage("It must be same password value");
			RuleFor(x => x.Email).EmailAddress().WithMessage("Please write true mail format");
		}
	}
}
