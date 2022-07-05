using Shop.Data.Base;
using Shop.Models;


namespace Shop.Data.Services
{
    public class GameShopsService : EntityBaseRepository<GameShop>, IGameShopsService
    {
        public GameShopsService(AppDbContext context) : base(context) 
        {

        }
    }
}
