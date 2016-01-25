using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Kripesh.MVC.Application.Models;

namespace Kripesh.MVC.Application.Repository
{

    public interface IStudentRepository : IGenericRepository<Student>
    {
       
    }

    public class StudentRepository : IStudentRepository
    {
        public int Delete(Student e)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAll()
        {
            return new List<Student>()
            {
                new Student()
                {
                    Id=1,
                    FirstName="Kripesh",
                    LastName="Bista",
                    Email="kripeshbista3@gmail.com",
                    ContactNo="98000000",
                    Status=true
                },
                new Student()
                {
                    Id=2,
                    FirstName="Shyam",
                    LastName="Maharjan",
                    Email="shyam@gmail.com",
                    ContactNo="98098000",
                    Status=false
                },
                new Student()
                {
                    Id=3,
                    FirstName="Ram",
                    LastName="Bhatta",
                    Email="ram@gmail.com",
                    ContactNo="980009800",
                    Status=true
                }
            };
        }

        public Student GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Student GetByID(int id)
        {
           /* foreach(Student student in GetAll())
            {
                if(student.Id == id)
                {
                    return student;
                }
            }
            return null;*/
           return GetAll().Where(student => student.Id == id).Single();
           
        }

        public int Insert(Student e)
        {
            throw new NotImplementedException();
        }

        public List<Student> Search(Expression<Func<Student>> e)
        {
            throw new NotImplementedException();
        }

        public int Update(Student e)
        {
            throw new NotImplementedException();
        }
    }
}