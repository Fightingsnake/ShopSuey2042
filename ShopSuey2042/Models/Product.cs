using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Reflection;

namespace ShopSuey2042.Models
{
	public class Product
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "Gebe den Namen des Produkts an!")]
		public string? Name { get; set; }
		public string? Description { get; set; }
		public string? Producer { get; set; }
		public decimal Price { get; set; }
		public double? Quantity { get; set; }
		public Einheiten Einheit { get; set; }
		public string? Image { get; set; }
        public Product()
        {
            
        }
    }
}
