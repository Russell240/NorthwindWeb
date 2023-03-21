using Microsoft.AspNetCore.Mvc.Razor; 
using System.Collections.Generic; 


namespace NorthWindWeb.Pages
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