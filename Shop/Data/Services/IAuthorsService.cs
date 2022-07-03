using Shop.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.Data.Services
{
    public interface IAuthorsService
    {
        Task<IEnumerable<Author>> GetAll();
        Author GetById(int id);
        void Add(Author author);
        Author Update(int id, Author newAuthor);
        void Delete(int id);
    }
}
