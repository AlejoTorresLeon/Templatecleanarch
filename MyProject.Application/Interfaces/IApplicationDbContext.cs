using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        //DatabaseFacade Database { get; }
        int SaveChanges();
        Task<int> SaveChangesAsync();
        void Dispose();
    }
}
