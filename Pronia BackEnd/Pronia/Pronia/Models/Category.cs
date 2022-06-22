using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia.Models
{
    public class Category
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        [Required(ErrorMessage = "This field is Required !")]
        public string Name { get; set; }
        public ICollection<ProductCategory> Products { get; set; }
    }
}
