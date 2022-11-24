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

        public async Task AddAsync(Actor actor)
        {
            await _context.AddAsync(actor);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int Id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id == Id);
            _context.Actors.Remove(result);
            await _context.SaveChangesAsync();

       
        }

        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            var result = await _context.Actors.ToListAsync();
            return result;
        }

        public async Task<Actor> GetByIdAsync(int Id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id == Id);
            return result;
        }

        public async Task<Actor> UpdateAsync(int Id, Actor newActor)
        {
            _context.Update(newActor);
            await _context.SaveChangesAsync();
            return newActor;
        }
    }
}

