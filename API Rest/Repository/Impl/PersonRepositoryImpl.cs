using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Model;
using WebApplication1.Model.Context;

namespace WebApplication1.Repository.Impl
{
    public class PersonRepositoryImpl : IPersonRepository
    {
        private PostgresContext _context;

        public PersonRepositoryImpl(PostgresContext context)
        {
            _context = context;
        }

        public void Delete(long id)
        {
            Person person = _context.Person.Find(id);

            if (person != null)
            {
                _context.Person.Remove(person);
            }

        }

        public bool Exist(long? id)
        {
            return _context.Person.Find(id) != null;
        }

        public List<Person> FindAll()
        {
            return _context.Person.ToList();
        }

        public Person FindById(long id)
        {
            return _context.Person.Find(id);
        }

        public Person Insert(Person person)
        {   
            _context.Person.Add(person);
            _context.SaveChanges();

            return person;
        }

        public Person Update(Person person)
        {
            if (Exist(person.id)) {
                Person personPreUpdate = _context.Person.Find(person.id);
                _context.Entry(personPreUpdate).CurrentValues.SetValues(person);
                _context.SaveChanges();
            } else {
                return null;
            }

            return person;
        }
    }
}
