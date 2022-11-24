using System;
using Microsoft.EntityFrameworkCore;
using MovieWeb.Models;

namespace MovieWeb.Data.Services
{
	public class ActorsService:IActorsService
	{

        private readonly ApplicationDbContext _context;

        public ActorsService(ApplicationDbContext context)
		{
            _context = context;
		}

        public void Add(Actor actor)
        {
            _context.Add(actor);
            _context.SaveChanges();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            var result = await _context.Actors.ToListAsync();
            return result;
        }

        public Actor GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Actor Update(int Id, Actor newActor)
        {
            throw new NotImplementedException();
        }
    }
}

