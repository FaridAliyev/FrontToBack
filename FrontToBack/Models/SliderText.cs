using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.Models
{
    public class SliderText
    {
        public int Id { get; set; }
        [Required,StringLength(200)]
        public string Title { get; set; }
        [Required,MinLength(150),MaxLength(500)]
        public string Description { get; set; }
        [Required, StringLength(300)]
        public string Image { get; set; }
    }
}
