using ApsNetCore6.Entity;
using ApsNetCore6.Models;
using System.Collections.Generic;
using System.Linq;

namespace ApsNetCore6.Repositories
{
    public class CategoriesRepository : ICategoriesRepository
    {
        private readonly DataBaseContext _ctx;

        public CategoriesRepository(DataBaseContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<CategoriesSampleModels> GetAll()
        {
            var results=new List<CategoriesSampleModels>(); ;
            var output= _ctx.Categories;
           
            foreach (var item in output)
            {
                results.Add(new CategoriesSampleModels { CategoryID = item.CategoryID, CategoryName = item.CategoryName, Description = item.Description });
            }
            return results;
        }

        public CategoriesSampleModels GetSingle(int id)
        {
            var result =new CategoriesSampleModels{ };
            var output= _ctx.Categories.FirstOrDefault(x => x.CategoryID == id);
            if (output!=null)
            {
                result.Description = output.Description;
                result.CategoryName = output.CategoryName;
                result.CategoryID = output.CategoryID;
            }
            return result;
        }

        public Categories Add(Categories toAdd)
        {
          
            _ctx.Categories.Add(toAdd);
            return toAdd;
        }

        public Categories Update(Categories toUpdate)
        {
            _ctx.Categories.Update(toUpdate);
            return toUpdate;
        }

        public void Delete(Categories toDelete)
        {
            _ctx.Categories.Remove(toDelete);
        }

        public int Save()
        {
            return _ctx.SaveChanges();
        }
    }
}
