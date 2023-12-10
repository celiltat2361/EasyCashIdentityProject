using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos
{
	public class AppUserRegisterDto
	{

		//[Required(ErrorMessage = "Name required")]
		//[Display(Name = "Name")]
		//[MaxLength(30, ErrorMessage = "Max 30 character")]
		public string Name { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string UserName { get; set; }
		public string Surname { get; set; }
		public string ComfirmPassword { get; set; }
	}
}

//name,surname, username, mail, password, comfirmpasword