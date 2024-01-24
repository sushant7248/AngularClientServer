using System.ComponentModel.DataAnnotations;

namespace AngularAppAuth.Server.Models
{
	public class Userlogin
	{

		[Required]
		public string Firstname { get; set; }


		public string Password { get; set; }
	}
}
