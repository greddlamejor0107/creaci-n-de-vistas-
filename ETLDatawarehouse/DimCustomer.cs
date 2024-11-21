using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETLDaraWarehouse.Entities.DWH
{
    public class DimCustomer
    {
        public string IDCustomer { get; set; }
        public string NameCustomer { get; set; }
        public string? NameContact { get; set; }
        public string? TitleContact { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Region { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
    }


}