using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Model;

namespace WebApplication1.Services
{
    public interface IPersonService
    {
        Person Create(Person Person);
        Person findById(long id);
        List<Person> FindAllPersons();
        Person Update(Person person);
        void Delete(long id);

    }
}
