using Shop.Data.Base;
using Shop.Models;

namespace Shop.Data.Services
{
    public class ProducersService:EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context)
        {

        }
    }
}
