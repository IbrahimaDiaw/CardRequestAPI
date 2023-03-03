using CardRequestAPI.Data;
using CardRequestAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CardRequestAPI.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly RequestCardContext _Context;

        public BaseRepository(RequestCardContext context)
        {
            _Context = context;
        }

        public void Create(T entity)
        {
           _Context.Add(entity);
        }

        public void Delete(T entity)
        {

            entity.DateCreated = DateTimeOffset.UtcNow;
            _Context.Update(entity);
        }

        public Task<T> Get(Guid id, CancellationToken cancellationToken)
        {
            return _Context.Set<T>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }

        public Task<List<T>> GetAll(CancellationToken cancellationToken)
        {
            return _Context.Set<T>().ToListAsync(cancellationToken);
        }

        public void Update(T entity)
        {
           _Context.Update(entity);
        }
    }
}
