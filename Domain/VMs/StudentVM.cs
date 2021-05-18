﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.VMs
{
    public class StudentVM:PersonVM
    {
        [Required]
        public List<int> favCourses { get; set; }
    }
}
