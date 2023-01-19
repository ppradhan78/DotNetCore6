using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ApsNetCore6.Models
{
    public class SuppliersSampleModels
    {
        public int SupplierID { get; set; }
        [IgnoreDataMember]
        public string CompanyName { get; set; }

        public string ContactName { get; set; }

        public string ContactTitle { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }

        public string Region { get; set; }

        public string Country { get; set; }

        [IgnoreDataMember]
        public string Phone { get; set; }

        public string Fax { get; set; }

        public string HomePage { get; set; }

        public List<ProductsSampleModel> Products { get; set; }
    }
}
