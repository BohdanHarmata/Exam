using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3
{
    class Article
    {
        public string Name { get; set; }
        public string ShopName { get; set; }
        public string Price { get; set; }

        public Article(string name, string shopName, string price)
        {
            this.Name = name;
            this.ShopName = shopName;
            this.Price = price;
        }
    }
}
