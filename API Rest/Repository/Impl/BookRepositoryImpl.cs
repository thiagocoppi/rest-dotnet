using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Model;
using WebApplication1.Model.Context;
using WebApplication1.Repository.Generic;

namespace WebApplication1.Repository.Impl
{
    public class BookRepositoryImpl : GenericRepository<Book>, IBookRepository
    {
        public BookRepositoryImpl(PostgresContext context) : base(context)
        {   
        }
    }
}
