
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PersonManager : IApplicantService 
    {
        public void ApplyFormmask(Person person)
        {

        }

        public List<Person> GetList()
        {
            return null;
        }

        public bool CheckPerson(Person person)
        {
            return true;
        }

        public void ApplyForMask(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
