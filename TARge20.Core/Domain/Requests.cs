using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Requests
    {
        [Key]
        public string ID { get; set; }
        public string Request { get; set; }
        public DateTime Date_of_request { get; set; }
        public string Comment { get; set; }

    }
}
