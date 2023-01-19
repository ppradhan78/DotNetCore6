using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApsNetCore6.Entity
{
    public class Categories
    {
        [Key]
        public int CategoryID { get; set; }
        [MaxLength(15)]
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Products> Products { get; set; }

        [Column(TypeName = "char(3)")]
        public string CategoryCode { get; set; }

    }
}
