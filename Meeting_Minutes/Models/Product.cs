using Microsoft.AspNetCore.Mvc.Rendering;

namespace Meeting_Minutes.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public List<SelectListItem> ProductList { get; set; }
        public int Quantity { get; set; }
    }
}
