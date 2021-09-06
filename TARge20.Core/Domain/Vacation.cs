using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Vacation
    {
        [Key]
        public int ID { get; set; }
        public DateTime Vacation_start { get; set; }
        public DateTime Vacation_end { get; set; }
        public string Vacation_type { get; set; }
        public string Comment { get; set; }
        public string Sick_leaves { get; set; }

    }
}
