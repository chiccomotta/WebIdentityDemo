using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp1
{
    // [Authorize]
    public class ContactModel : PageModel
    {
        public string Message { get; set; } = "Contact me at cristiano.motta@hotmail.it";

        public void OnGet()
        {

        }
    }
}