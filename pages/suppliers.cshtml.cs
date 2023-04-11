using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic; 


namespace NorthwindWeb.Pages
{
    public class SuppliersModel : PageModel 
    {
        public IEnumerable<string> Suppliers {get; set; }
        public void OnGet()
            {
                ViewData["Title"] = "NorthWind Web Site  - suppliers  "; 
                Suppliers = new[]{"Alpha Co", "Beta Limited ", "Gamma Corp" };
                
            }
    }
}