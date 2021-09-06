using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Loans_from_the_company
    {
        [Key]
        public string ID { get; set; }
        public string Loaned_item { get; set; }
        public string Amount { get; set; }
        public DateTime Loan_start { get; set; }
        public DateTime Loan_end { get; set; }
        public string Comment { get; set; }

    }
}
