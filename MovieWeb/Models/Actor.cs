using System;
using System.ComponentModel.DataAnnotations;

namespace MovieWeb.Models
{
	public class Actor
	{
		[Key]
		public int Id { get; set; }

		[Display(Name = "Profile Picture")]
		[Required(ErrorMessage = "Profile Picture is Required")]
		public string ProfilePictureURL { get; set; }


        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is Required")]
		[StringLength(50, MinimumLength =3, ErrorMessage ="Full name must be between 3 and 50 characters")]
		public string FullName { get; set; }


        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is Required")]
        public string Bio { get; set; }


		//Relationships

		public List<Actor_Movie> Actors_Movies { get; set; }
	}
}

