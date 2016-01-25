using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Kripesh.MVC.Application.Models;

namespace Kripesh.MVC.Application.Repository
{

    public interface ITeacherRepository : IGenericRepository<Teacher>
    {
       

    }
    public class TeacherRepository : ITeacherRepository
    {
        public int Delete(Teacher e)
        {
            throw new NotImplementedException();
        }

        public List<Teacher> GetAll()
        {
            return new List<Teacher>()
            {
                new Teacher()
                {
                    Id=1,
                    FirstName="Amar",
                    LastName="Shrestha",
                    Address="Dallu",
                    Salary="20000",
                    Email="amar@gmail.com",
                    Status=true
                },
                new Teacher()
                {
                    Id=2,
                    FirstName="Bipin",
                    LastName="Maharjan",
                    Address="Newroad",
                    Salary="40000",
                    Email="bipin@gmail.com",
                    Status=true
                },
                new Teacher()
                {
                    Id=3,
                    FirstName="Ajay",
                    LastName="Panday",
                    Address="Patan",
                    Salary="30000",
                    Email="ajay@gmail.com",
                    Status=true
                }
            };
            
        }

        public Teacher GetById(int id)
        {
            return GetAll().Where(teacher => teacher.Id == id).Single();
        }

        public int Insert(Teacher e)
        {
            throw new NotImplementedException();
        }

        public List<Teacher> Search(Expression<Func<Teacher>> e)
        {
            throw new NotImplementedException();
        }

        public int Update(Teacher e)
        {
            throw new NotImplementedException();
        }
    }
}