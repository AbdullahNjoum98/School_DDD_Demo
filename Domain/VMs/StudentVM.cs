﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.VMs
{
    public class StudentVM
    {
        [Required]
        public CourseVM favCourse { get; set; }
    }
}
