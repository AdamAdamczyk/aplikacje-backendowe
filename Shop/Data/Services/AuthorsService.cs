using Microsoft.EntityFrameworkCore;
using Shop.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Services
{
    public class AuthorsService : IAuthorsService
    {
        private readonly AppDbContext _context;
        public AuthorsService(AppDbContext context)
        {
            _context = context;
        }


        public void Add(Author author)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Author>> GetAll()
        {
            var result = await _context.Authors.ToListAsync();
            return result;
        }

        public Author GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Author Update(int id, Author newAuthor)
        {
            throw new System.NotImplementedException();
        }
    }
}
