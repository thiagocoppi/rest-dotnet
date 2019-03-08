using System;
using System.Collections.Generic;
using WebApplication1.Model;
using WebApplication1.Repository;

namespace WebApplication1.Services.Impl
{
    public class PersonServiceImpl : IPersonService
    {

        private IPersonRepository _repository;
        
        public PersonServiceImpl(IPersonRepository repository)
        {
            _repository = repository;
        }


        public Person Create(Person Person)
        {
            try
            {
                _repository.Insert(Person);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Person;
        }
          

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<Person> FindAllPersons()
        {
            return _repository.FindAll();
            
        }

        public Person findById(long id)
        {
            return _repository.FindById(id);
        }

        public Person Update(Person person)
        {
            return _repository.Update(person);
        }
    }
}
