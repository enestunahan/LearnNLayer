using System.Collections.Generic;

namespace LearnNLayer.Core.DTOs
{
    public class CategoryWithProductsDto : CategoryDto
    {
        public List<ProductDto> Products { get; set; }
    }
}
