using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Model;
using WebApplication1.Repository;

namespace WebApplication1.Services.Impl
{
    public class BookServiceImpl : IBookService
    {

        private IBookRepository _repository;

        public BookServiceImpl(IBookRepository repository)
        {
            _repository = repository;
        }

        public Book Create(Book book)
        {
            throw new NotImplementedException();
        }

        public Book FindById(long id)
        {
            return _repository.FindById(id);
        }

        public List<Book> ListAllBook()
        {
            List<Book> lista = _repository.FindAll();
            return _repository.FindAll();
        }

        public void RemoveById(long id)
        {
            throw new NotImplementedException();
        }

        public Book Update(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
