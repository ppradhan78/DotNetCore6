using ApsNetCore6.Models;
using System.Collections.Generic;

namespace ApsNetCore6.Models
{
    public class CategoriesSampleModels
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string CategoryCode { get; set; }
        public List<ProductsSampleModel> Products { get; set; }
    }
}
