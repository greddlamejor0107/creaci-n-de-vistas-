using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETLDaraWarehouse.Entities.DWH

{
    public class DimProduct
    {
        public int IDProduct { get; set; }
        public string NameProduct { get; set; } = string.Empty;
        public int IDSupplier { get; set; }
        public int IDCategory { get; set; }
        public string? QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? UnitsInStock { get; set; }
        public int? UnitsOnOrder { get; set; }
        public int? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
    }

}
