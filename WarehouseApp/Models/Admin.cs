﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseApp.Models
{
    public class Admin
    {
        public int ID { get; set; }

        public string ?Username { get; set; }

        public string ?Email { get; set; }

        public string? Phone_Number { get; set; }

        public string ? Password { get; set; }

        public DateTime Date_Registered { get; set; }


    }
}
