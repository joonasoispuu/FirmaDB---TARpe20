using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Employees_childres
    {
        [Key]
        public string ID { get; set; }
        public int Children_amount { get; set; }
        public int Children_ID { get; set; }
        public string Children_firstname { get; set; }
        public string Children_lastname { get; set; }
        public string Comment { get; set; }
    }
}
