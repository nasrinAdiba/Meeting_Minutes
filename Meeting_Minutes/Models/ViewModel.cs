using Microsoft.AspNetCore.Mvc.Rendering;

namespace Meeting_Minutes.Models
{
    public class ViewModel
    {
        public int CorporateId { get; set; }
        public List<SelectListItem> CorporateList { get; set; }
        public int IndividualId { get; set; }
        public List<SelectListItem> IndividualList { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public List<SelectListItem> ProductList { get; set; }
    }
}
