using System;
using System.Collections.Generic;
using System.Text;

namespace ShopExample.Model
{
    public class Article
    {
        public List<Promotion> Promotions { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }

        //method special
    }
}
