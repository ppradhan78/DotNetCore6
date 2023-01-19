using System.ComponentModel.DataAnnotations;

namespace ApsNetCore6.Entity
{
    public class Products
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        [MaxLength(100)]
        public string ProductName { get; set; }

        public int SupplierID { get; set; }
        public int CategoryID { get; set; }

        [MaxLength(20)]
        public string QuantityPerUnit { get; set; }

        public int UnitPrice { get; set; }

        public int UnitsInStock { get; set; }

        public int UnitsOnOrder { get; set; }

        public int ReorderLevel { get; set; }

        public bool Discontinued { get; set; }

        public Categories Categories { get; set; }

        public Suppliers Suppliers { get; set; }

    }
}
