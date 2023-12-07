using Microsoft.AspNetCore.Mvc.Rendering;

namespace Meeting_Minutes.Models
{
    public class CorporateModel
    {
        public int CorporateId { get; set; }
        public List<SelectListItem> CorporateList { get; set; }
    }
}
