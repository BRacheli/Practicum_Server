using MyProject.Repositories.Entities;
using MyProject.Repositories.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllAsync();
        Task<User> GetByTzAsync(string tz);
        Task<User> GetByIdAsync(int id);
        Task<User> AddAsync(string firstName, string lastName, string tz, DateTime birthDate, string gender, HMOEnum HMO, string parentTz);
        Task<User> UpdateAsync(User user);
        Task DeleteAsync(int id);
    }
}
