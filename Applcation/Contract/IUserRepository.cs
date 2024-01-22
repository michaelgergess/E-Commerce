using 

namespace School.Application.Contract
{
    public interface IUserRepository  : IRepository<, int>    
    {
        Student GetByLastName(string Lname);
        Student GetByFirstName(string Fname);

    }
}
