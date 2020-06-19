﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [Required,StringLength(300)]
        public string Image { get; set; }
        [StringLength(300)]
        public string Class { get; set; }
    }
}
