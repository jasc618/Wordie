using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wordie.Website.Pages
{
    public class WordiveModel : PageModel
    {
        private readonly ILogger<WordiveModel> _logger4;

        public WordiveModel(ILogger<WordiveModel> logger)
        {
            _logger4 = logger;
        }

        public void OnGet()
        {
        }
    }
}
