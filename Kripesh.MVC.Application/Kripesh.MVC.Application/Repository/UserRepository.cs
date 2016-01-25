using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Kripesh.MVC.Application.Models;

namespace Kripesh.MVC.Application.Repository
{

    public interface IUserRepository : IGenericRepository<User>
    {

    }
    public class UserRepository : IUserRepository
    {
        public int Delete(User e)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            return new List<User>()
            {
                new User()
                {
                    Id=1,
                    Username="admin",
                    Password="Admin123",
                    Status=true
                },
                new User()
                {
                    Id=2,
                    Username="user.admin",
                    Password="user1qaz",
                    Status=false
                },
                new User()
                {
                    Id=3,
                    Username="admin.admin",
                    Password="admin=[;.",
                    Status=false
                }
            };
        }

        public User GetById(int id)
        {
            return GetAll().Where(user => user.Id == id).Single();
        }

        public int Insert(User e)
        {
            throw new NotImplementedException();
        }

        public List<User> Search(Expression<Func<User>> e)
        {
            throw new NotImplementedException();
        }

        public int Update(User e)
        {
            throw new NotImplementedException();
        }
    }
}