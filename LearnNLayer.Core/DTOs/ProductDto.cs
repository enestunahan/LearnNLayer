//using System.ComponentModel.DataAnnotations;

namespace LearnNLayer.Core.DTOs
{
    public class ProductDto : BaseDto
    {      
        //[Required(ErrorMessage ="İsim alanı gereklidir")]
        //[MinLength(3,ErrorMessage ="Minimum 3 karakter uzunluğunda olmalıdır")]
        public string Name { get; set; }   
        //[Required(ErrorMessage ="Stok alanı zorunludur")]
        //[Range(5,150,ErrorMessage ="5 ten küçük 150 den büyük olamaz")]
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
