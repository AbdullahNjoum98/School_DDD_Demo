﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotracts.VMs
{
    public class FavCourseResource
    {
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(10)]
        public string Code { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(30)]
        public string Name { get; set; }

        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                FavCourseResource p = (FavCourseResource)obj;
                return Id == p.Id
                    && Name == p.Name
                    && Code == p.Code;
            }
        }

    }
}
