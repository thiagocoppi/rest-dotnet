using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Model.Context
{
    public class PostgresContext : DbContext
    {
        public PostgresContext()
        {

        }

        public PostgresContext(DbContextOptions<PostgresContext> options) : base (options){}

        public DbSet<Person> Person { get; set;}
        public DbSet<Book> Book { get; set; }

    }
}
