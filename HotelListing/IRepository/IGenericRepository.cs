using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace HotelListing.IRepository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IList<T>> GetAll(
            Expression<Func<T,bool>> expression = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            List<string> includes = null
            );

        Task<T> Get(Expression<Func<T, bool>> expression = null ,List<string> includes = null);

        Task insert (T entity);
        Task insertRange (IEnumerable<T> entities);
        Task delete (int id);
        void deleteRange (IEnumerable<T> entities);
        void update (T entity);

    }
}
