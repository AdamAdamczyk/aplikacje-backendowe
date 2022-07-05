using Microsoft.EntityFrameworkCore;
using Shop.Data.Base;
using Shop.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Services
{
    public class AuthorsService : EntityBaseRepository<Author>, IAuthorsService
    {
        public AuthorsService(AppDbContext context) : base(context) { }        
    }
}
