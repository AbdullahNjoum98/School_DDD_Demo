﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotracts.VMs
{
    public class TeacherVM
    {
        public int Id { get; set; }
        [MaxLength(30)]
        [MinLength(5)]
        [Required]
        public string Name { get; set; }
        [MaxLength(20)]
        [MinLength(3)]
        [Required]
        public string Degree { get; set; }

    }
}
