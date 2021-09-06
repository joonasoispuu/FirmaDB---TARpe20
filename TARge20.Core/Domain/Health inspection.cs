using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Health_inspection
    {
        [Key]
        public string ID { get; set; }
        public string Health_problems { get; set; }
        public string Comment { get; set; }

    }
}
