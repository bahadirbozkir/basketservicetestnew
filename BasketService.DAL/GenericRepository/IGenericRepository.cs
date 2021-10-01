using BasketService.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BasketService.DAL.GenericRepository
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        Task<T> AddAsync(T entity);
        Task<int> DeleteAsync(T entity);
        Task<ICollection<T>> GetAllAsync();
        Task<T> UpdateAsync(T entity);
        Task<T> GetAsync(long id);
    }
}
