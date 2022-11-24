using System;
using MovieWeb.Models;

namespace MovieWeb.Data.Services
{
	public interface IActorsService
	{
		Task<IEnumerable<Actor>> GetAll();

		Actor GetById(int Id);

		void Add(Actor actor);

		Actor Update(int Id, Actor newActor);

		void Delete(int Id);
	}
}

