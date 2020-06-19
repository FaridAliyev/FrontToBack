using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.Models
{
    public class Bio
    {
        public int Id { get; set; }
        [Required,StringLength(100)]
        public string Logo { get; set; }
        [StringLength(100)]
        public string Instagram { get; set; }
        [StringLength(100)]
        public string Facebook { get; set; }
        [StringLength(100)]
        public string Twitter { get; set; }
        [StringLength(100)]
        public string Tumblr { get; set; }
        [StringLength(100)]
        public string Pinterest { get; set; }
    }
}
