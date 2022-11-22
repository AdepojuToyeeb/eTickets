using System;
using Microsoft.EntityFrameworkCore;

namespace MovieWeb.Data
{
	public class ApplicationDbContext: DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
		{
			
		}
	}
}

