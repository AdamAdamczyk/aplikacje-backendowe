using Shop.Data.Base;
using Shop.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.Data.Services
{
    public interface IAuthorsService:IEntityBaseRepository<Author>
    {
    }
}
