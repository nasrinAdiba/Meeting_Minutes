using Meeting_Minutes.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Rendering;
using Meeting_Minutes.Data;
using System.Net.Http.Headers;
using Microsoft.EntityFrameworkCore;

namespace Meeting_Minutes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


       

        public IActionResult Index()
        {

            DBMeeting_MinutesContext dBMeeting_MinutesContext = new DBMeeting_MinutesContext();

            CorporateModel corporateModel = new CorporateModel();
            corporateModel.CorporateList = new List<SelectListItem>();

            
            var data = dBMeeting_MinutesContext.CorporateCustomerTbls.ToList();
            corporateModel.CorporateList.Add(new SelectListItem
            {
                Text = "Select Corporate Customer Name",
                Value = ""
            });
            foreach (var item in data)
            {
                corporateModel.CorporateList.Add(new SelectListItem
                {
                    Text = item.CustomerName,
                    Value = Convert.ToString(item.Id)
                });
            }


            IndividualModel individualModel = new IndividualModel();
            individualModel.IndividualList = new List<SelectListItem>();

            
            var data2 = dBMeeting_MinutesContext.IndividualCustomerTbls.ToList();
            individualModel.IndividualList.Add(new SelectListItem
            {
                Text = "Select Individual Customer Name",
                Value = ""
            });
            foreach (var item in data2)
            {
                individualModel.IndividualList.Add(new SelectListItem
                {
                    Text = item.CustomerName,
                    
                    Value = Convert.ToString(item.Id)
                });
            }

            Product productModel = new Product();
            productModel.ProductList = new List<SelectListItem>();

            var data3 = dBMeeting_MinutesContext.ProductsServiceTbls.ToList();

            productModel.ProductList.Add(new SelectListItem
            {
                Text = "Select Product/Service",
                
                Value = ""
            });
            foreach (var item in data3)
            {
                productModel.ProductList.Add(new SelectListItem
                {
                    Text = item.ProductService,

                    Value = Convert.ToString(item.Id)
                });
            }


            ViewModel vm = new ViewModel()
            {
                CorporateList = corporateModel.CorporateList,
                IndividualList = individualModel.IndividualList,
                ProductList = productModel.ProductList
            };


           
            return View(vm);
        }
        [HttpPost]
        public IActionResult Index(Product productModel)
        {
            DBMeeting_MinutesContext dBMeeting_MinutesContext = new DBMeeting_MinutesContext();
            productModel.ProductList = new List<SelectListItem>();

            var data3 = dBMeeting_MinutesContext.ProductsServiceTbls.ToList();

            productModel.ProductList.Add(new SelectListItem
            {
                Text = "Select Product/Service",
                
                Value = ""
            });
            foreach (var item in data3)
            {
                productModel.ProductList.Add(new SelectListItem
                {
                    Text = item.ProductService,
                   
                    Value = Convert.ToString(item.Id)
                });
            }

            ViewBag.Value = productModel.ProductId;
            ViewBag.Quantity = productModel.ProductList.Where(m => m.Value == productModel.Quantity.ToString()).FirstOrDefault();
            ViewBag.Text = productModel.ProductList.Where(m => m.Value == productModel.ProductId.ToString()).FirstOrDefault().Text;
            return View(productModel);
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}