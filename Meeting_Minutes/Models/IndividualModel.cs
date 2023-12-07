using Microsoft.AspNetCore.Mvc.Rendering;

namespace Meeting_Minutes.Models
{
    public class IndividualModel
    {
        public int IndividualId { get; set; }
        public List<SelectListItem> IndividualList { get; set; }
    }
}
