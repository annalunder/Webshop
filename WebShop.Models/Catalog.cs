﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.Models
{
    public class Catalog
    {
        public DateTime LastUpdated { get; set; }

        public ICollection<Book> Books { get; set; }
        public ICollection<Genre> ProductCategories { get; set; }
    }
}