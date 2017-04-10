using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorseProjectSystem.Data
{
    class ShipMethod
    {
        [Table("ShipMethod")]
        public class ShipingMethod
        {
            [Key]
            public int ShipMethodID { get; set; }
            public string Name { get; set; }
            public string ShipBase { get; set; }
            public int ShipRate { get; set; }
            public string rowguid { get; set; }
            public string ModifiedDate { get; set; }
        }
    }
}
