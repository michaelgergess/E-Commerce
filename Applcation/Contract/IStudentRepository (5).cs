using School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace School.Application.Contract
{
    public interface IStudentRepository : IRepository<Student, int>    
    {
        Student GetByLastName(string Lname);
        Student GetByFirstName(string Fname);

    }
}
