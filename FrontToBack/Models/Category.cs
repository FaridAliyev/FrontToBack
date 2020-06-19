using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Field Cannot Be Empty!!!"),StringLength(100,ErrorMessage ="Characters too long!!!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Field Cannot Be Empty!!!"), StringLength(700, ErrorMessage = "Characters too long!!!")]
        public string Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
