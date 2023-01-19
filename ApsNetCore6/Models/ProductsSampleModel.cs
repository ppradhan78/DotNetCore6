using ApsNetCore6.Models;

namespace ApsNetCore6.Models
{
    public class ProductsSampleModel
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public int SupplierID { get; set; }
        public int CategoryID { get; set; }

        public int QuantityPerUnit { get; set; }

        public int UnitPrice { get; set; }

        public int UnitsInStock { get; set; }

        public int UnitsOnOrder { get; set; }

        public int ReorderLevel { get; set; }

        public bool Discontinued { get; set; }


        public CategoriesSampleModels Categories { get; set; }

        public SuppliersSampleModels Suppliers { get; set; }

    }
}
