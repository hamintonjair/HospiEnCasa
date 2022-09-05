using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace HospiEnCasa.WebApp.Pages.Seguros
{
    public class GestionSeguro : PageModel
    {
        private readonly ILogger<GestionSeguro> _logger;

        public GestionSeguro(ILogger<GestionSeguro> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}