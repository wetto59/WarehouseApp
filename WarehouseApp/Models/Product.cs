using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseApp.Models
{
    public class Product
    {
        public int ID { get; set; }

        public string? Name { get; set; }

        public int CatID { get; set; }

        public string? Barcode { get; set; }

        public double Cost { get; set; }

        public double Price { get; set; }
    }
}
