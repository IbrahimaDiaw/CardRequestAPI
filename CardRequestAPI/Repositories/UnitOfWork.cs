using CardRequestAPI.Data;

namespace CardRequestAPI.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RequestCardContext _cardContext;
        public UnitOfWork(RequestCardContext cardContext)
        {
            _cardContext = cardContext;
        }

        public Task Save(CancellationToken cancellationToken)
        {
           return _cardContext.SaveChangesAsync(cancellationToken);
        }
    }
}
