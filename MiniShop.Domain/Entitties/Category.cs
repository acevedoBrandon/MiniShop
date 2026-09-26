using System;
using System.Collections.Generic;
using System.Text;

namespace MiniShop.Domain.Entitties
{
    public class Category
    {
        public int id { get; set; }
        public string name { get; set; } = null!; 
        public string Description { get; set; }
        public bool IsActive { get; set; }


        //Navigation property
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
