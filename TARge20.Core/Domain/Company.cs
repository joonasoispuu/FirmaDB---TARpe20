using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Company
    {
        [Key]
        public int Register_no { get; set; }
        public int code { get; set; }
        public string name { get; set; }
        public string Frequency_of_appearance { get; set; }
        public string Comment { get; set; }
    }
}
