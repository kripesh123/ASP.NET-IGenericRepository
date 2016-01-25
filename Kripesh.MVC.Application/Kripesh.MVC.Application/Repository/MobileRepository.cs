using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Kripesh.MVC.Application.Models;

namespace Kripesh.MVC.Application.Repository
{

    public interface IMobileRepository : IGenericRepository<Mobile>
    {
       
    }
    public class MobileRepository : IMobileRepository
    {
        public int Delete(Mobile e)
        {
            throw new NotImplementedException();
        }

        public List<Mobile> GetAll()
        {
            return new List<Mobile>()
            {
                new Mobile()
                {
                    Id=1,
                    Name="Iphone",
                    Price="12000",
                    Processor="iphone",
                    ScreenSize="6",
                    Available=true

                },
                new Mobile()
                {
                    Id=2,
                    Name="Samsung",
                    Price="19000",
                    Processor="samsung",
                    ScreenSize="8",
                    Available=true

                },
                new Mobile()
                {
                    Id=3,
                    Name="LAVA",
                    Price="10000",
                    Processor="lava",
                    ScreenSize="5",
                    Available=false
                }
            };
        }

        public Mobile GetById(int id)
        {
            return GetAll().Where(m => m.Id == id).Single();
        }

        public int Insert(Mobile e)
        {
            throw new NotImplementedException();
        }

        public List<Mobile> Search(Expression<Func<Mobile>> e)
        {
            throw new NotImplementedException();
        }

        public int Update(Mobile e)
        {
            throw new NotImplementedException();
        }
    }
}