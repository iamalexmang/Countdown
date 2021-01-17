using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace Countdown.Pages
{
    public class IndexModel : PageModel
    {
        // requires using Microsoft.Extensions.Configuration;
        private readonly IConfiguration Configuration;

        public IndexModel(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void OnGet()
        {
        }
    }
}
