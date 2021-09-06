using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Employee_position
    {
        [Key]
        public int ID { get; set; }
        public string Position { get; set; }
        public int Payment { get; set; }
        public string Comment { get; set; }

    }
}
