using Shop.Data.Base;
using Shop.Models;
using System.Threading.Tasks;

namespace Shop.Data.Services
{
    public interface IGamesService : IEntityBaseRepository<Game>
    {
        Task<Game> GetGamesByIdAsync(int id);
    }
}
