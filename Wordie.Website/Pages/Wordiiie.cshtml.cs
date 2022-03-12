using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wordie.Website.Pages
{
    public class WordiiieModel : PageModel
    {
        private readonly ILogger<WordiiieModel> _logger3;

        public WordiiieModel(ILogger<WordiiieModel> logger)
        {
            _logger3 = logger;
        }

        public void OnGet()
        {
        }
    }
}
