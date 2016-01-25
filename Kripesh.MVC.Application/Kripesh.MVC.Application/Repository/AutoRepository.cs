using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Kripesh.MVC.Application.Models;

namespace Kripesh.MVC.Application.Repository
{
    public interface IAutoRepository : IGenericRepository<Auto>
    {
       
    }
    public class AutoRepository : IAutoRepository
    {
        public int Delete(Auto e)
        {
            throw new NotImplementedException();
        }

        public List<Auto> GetAll()
        {
            return new List<Auto>()
           {
               new Auto()
               {
                   Id=1,
                   AutoName="Maruti-800",
                   ModelNumber="2010",
                   Price="$1000",
                   Status=false
               },
               new Auto()
               {
                   Id=2,
                   AutoName="Mercedez Benz",
                   ModelNumber="2011",
                   Price="$9000",
                   Status=true
               },
               new Auto()
               {
                   Id=3,
                   AutoName="Toyota",
                   ModelNumber="2012",
                   Price="$2000",
                   Status=true
               }
           };
        }

        public Auto GetById(int id)
        {
            return GetAll().Where(m => m.Id == id).Single();
        }

        public int Insert(Auto e)
        {
            throw new NotImplementedException();
        }

        public List<Auto> Search(Expression<Func<Auto>> e)
        {
            throw new NotImplementedException();
        }

        public int Update(Auto e)
        {
            throw new NotImplementedException();
        }
    }
}