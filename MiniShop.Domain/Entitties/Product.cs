using System;
using System.Collections.Generic;
using System.Text;

namespace MiniShop.Domain.Entitties
{
    public class Product
    {
        public int Id { get; set; }
        public string Cod { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public Category Category { get; set; } = null!;

        //Navigation property
        public ICollection<Category> Categories { get; set; } = new List<Category>();
    }
}
