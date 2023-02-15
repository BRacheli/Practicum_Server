using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories
{
    public interface IContext
    {
        DbSet<User> Users { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
