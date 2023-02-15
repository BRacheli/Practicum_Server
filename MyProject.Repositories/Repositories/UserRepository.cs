using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Enums;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IContext _context;

        public UserRepository(IContext context)
        {
            _context = context;
        }

        public async Task<User> AddAsync(string firstName, string lastName, string tz, DateTime birthDate, string gender, HMOEnum HMO,  string parentTz)
        {
            var newUser = new User { FirstName = firstName, LastName = lastName, Tz = tz, BirthDate = birthDate, Gender = gender, HMO = HMO,  Parent_1_tz = parentTz,Parent_2_tz=""};
            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();
            return newUser;
        }

        public async Task DeleteAsync(int id)
        {
            var user = await GetByIdAsync(id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<User> GetByTzAsync(string tz)
        {
            return await _context.Users.FirstOrDefaultAsync((user)=>user.Tz==tz);
        }

        public async Task<User> UpdateAsync(User user)
        {
            var updateUser=_context.Users.Update(user);
            await _context.SaveChangesAsync();
            return updateUser.Entity;
        }
    }
}
