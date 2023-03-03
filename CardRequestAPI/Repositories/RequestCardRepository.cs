using CardRequestAPI.Data;
using CardRequestAPI.Models;

namespace CardRequestAPI.Repositories
{
    public class RequestCardRepository : BaseRepository<RequestCardEntity>, IRequestRepository
    {
        public RequestCardRepository(RequestCardContext context) : base(context)
        {
        }
    }
}
