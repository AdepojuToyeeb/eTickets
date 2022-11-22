using System;
using System.ComponentModel.DataAnnotations;

namespace MovieWeb.Models
{
	public class Actor
	{
		[Key]
		public int Id { get; set; }

		public string ProfilePictureURL { get; set; }

		public string FullName { get; set; }

		public string Bio { get; set; }

	}
}

