using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Employees_location
    {
        [Key]
        public string ID { get; set; }
        public string Employee_location { get; set; }
        public string Comment { get; set; }
    }
}
