using System.Collections.Generic;

namespace LearnNLayer.Core.Models
{
    public class Category
    {
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
