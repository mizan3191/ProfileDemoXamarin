using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyscoundApp.Models
{
    public class Order
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
        public string Image { get; set; }
        public int Population { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        [NotMapped]
        public double Longitude1 { get; set; }

        //public int OrderID { get; set; }
        //public string CustomerID { get; set; }
        //public int EmployeeID { get; set; }
        //public double Freight { get; set; }
        //public string ShipCity { get; set; }
        //public bool Verified { get; set; }
        //public DateTime OrderDate { get; set; }
        //public string ShipName { get; set; }
        //public string ShipCountry { get; set; }
        //public DateTime ShippedDate { get; set; }
        //public string ShipAddress { get; set; }
    }
}
