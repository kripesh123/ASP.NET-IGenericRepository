using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Kripesh.MVC.Application.Models;


namespace Kripesh.MVC.Application.Repository
{

    public interface ICategoryRepository : IGenericRepository<Category>
    {
    }
    public class CategoryRepository : ICategoryRepository
    {
        public int Delete(Category e)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            return new List<Category>()
            {
                new Category()
                {
                    Id=1,
                    CategoryName="Apperals",
                    Item="apperals",
                    Details="Very Good",
                    Status=true
                },
                new Category()
                {
                    Id=2,
                    CategoryName="Kitchenware",
                    Item="kitchen",
                    Details="kitchen",
                    Status=true
                },
                new Category()
                {
                    Id=3,
                    CategoryName="MensWear",
                    Item="menswear",
                    Details="underwear,t-shirt,pants",
                    Status=false
                }
            };
        }

        public Category GetById(int id)
        {
            return GetAll().Where(category => category.Id == id).Single();
        }

        public int Insert(Category e)
        {
            throw new NotImplementedException();
        }

        public List<Category> Search(Expression<Func<Category>> e)
        {
            throw new NotImplementedException();
        }

        public int Update(Category e)
        {
            throw new NotImplementedException();
        }
    }
}