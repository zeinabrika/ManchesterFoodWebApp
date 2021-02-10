using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManFood.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ManFood.Pages.Admin.Category
{
    public class IndexModel : PageModel
    {
       //[Authorize(Roles = SD.ManagerRole)]
        public void OnGet()
        {
        }
    }
}
