using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Kripesh.MVC.Application.Models;

namespace Kripesh.MVC.Application.Repository
{
    public interface IStoreRepository : IGenericRepository<Store>
    {
       
    }

    public class StoreRepository : IStoreRepository
    {
        public int Delete(Store e)
        {
            throw new NotImplementedException();
        }

        public List<Store> GetAll()
        {
            return new List<Store>(){
                new Store()
                {
                    Id=1,
                    Name="Big Mart",
                    Location="Durbar Marg",
                    Capacity="Large",
                    Employee=25,
                    Status=true
                },
                new Store()
                {
                    Id=2,
                    Name="Ram Store",
                    Location="Nakhipot",
                    Capacity="Small",
                    Employee=10,
                    Status=true
                },
                new Store()
                {
                    Id=3,
                    Name="Kripesh Store",
                    Location="Patan",
                    Capacity="Medium",
                    Employee=8,
                    Status=false
                }
            };
        }

        public Store GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Store getById(int id)
        {
            return GetAll().Where(m => m.Id == id).Single();
        }

        public int Insert(Store e)
        {
            throw new NotImplementedException();
        }

        public List<Store> Search(Expression<Func<Store>> e)
        {
            throw new NotImplementedException();
        }

        public int Update(Store e)
        {
            throw new NotImplementedException();
        }
    }
}