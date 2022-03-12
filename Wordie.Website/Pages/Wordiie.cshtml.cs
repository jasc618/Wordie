using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wordie.Website.Pages
{
    public class WordiieModel : PageModel
    {
        private readonly ILogger<WordiieModel> _logger2;

        public WordiieModel(ILogger<WordiieModel> logger)
        {
            _logger2 = logger;
        }

        public void OnGet()
        {
        }
    }
}
