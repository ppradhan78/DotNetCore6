using ApsNetCore6.Entity;
using ApsNetCore6.Models;
using System.Collections.Generic;

namespace ApsNetCore6.Repositories
{
    public interface ICategoriesRepository
    {
        IEnumerable<CategoriesSampleModels> GetAll();
        CategoriesSampleModels GetSingle(int id);
        Categories Add(Categories toAdd);
        Categories Update(Categories toUpdate);
        void Delete(Categories toDelete);
        int Save();
    }
}