using BasketService.DAL.Entity;
using BasketService.DAL.GenericRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BasketService.DAL.UOW
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<T> GetRepository<T>() where T : BaseEntity;
        int SaveChanges(bool useAudit = false);
        Task<int> SaveChangesAsync(bool useAudit = false);
    }
}
