using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Tips
    {
        [Key]
        public string Tip { get; set; }
        public DateTime Date_of_tip { get; set; }
        public string Comment { get; set; }

    }
}
