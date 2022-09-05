using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace HospiEnCasa.WebApp.Pages.Revision
{
    public class GestionRevision : PageModel
    {
        private readonly ILogger<GestionRevision> _logger;

        public GestionRevision(ILogger<GestionRevision> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}