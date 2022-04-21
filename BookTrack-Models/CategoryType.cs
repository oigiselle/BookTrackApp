using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTrack_Models
{
    public class CategoryType
    {
        [Key]
        public string Type { get; set; }
        public string Name { get; set; }

        public ICollection<Category> Category { get; set; }
    }
}
