﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Vacation_status
    {
        [Key]
        public string Status { get; set; }
    }
}
