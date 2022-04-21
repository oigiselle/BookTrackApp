﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BookTrack_Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        public CategoryType Type { get; set; }

        public string Description { get; set; }

        public ICollection<Book> Books { get; set; }

    }
}
