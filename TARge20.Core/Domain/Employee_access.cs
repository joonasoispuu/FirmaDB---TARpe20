using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Employee_access
    {
        [Key]
        public int ID { get; set; }
        public string Access { get; set; }
        public string Comment { get; set; }

    }
}
