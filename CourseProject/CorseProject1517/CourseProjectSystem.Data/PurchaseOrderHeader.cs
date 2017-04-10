using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectSystem.Data
{
    class PurchaseOrderHeader
    {

        [Table("PruchaseOrderHeader")]
        public class ShipingMethod
        {
            [Key]
            public int PurchaseOrderID { get; set; }
            public int NevisionNumber { get; set; }
            public int EmployeeID { get; set; }
            public int VendorID { get; set; }
            public int ShipMethodID { get; set; }
            public string OrderDate { get; set; }
            public string ShipDate { get; set; }
            public string SubTotal { get; set; }
            public double TaxAmt { get; set; }
            public string Freight { get; set; }
            public double TotalDue { get; set; }
            public string ModifiedDate { get; set; }

        }
    }
}
