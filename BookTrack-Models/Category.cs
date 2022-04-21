using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BookTrack_Models
{
    public class Category
    {
       
        [Key]
        public string NameToken { get; set; }
        
        public string Type { get; set; }

        public string Description { get; set; }

        public ICollection<Book> Books { get; set; }

    }
}
