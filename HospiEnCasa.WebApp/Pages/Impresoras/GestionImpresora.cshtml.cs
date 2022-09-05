using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace HospiEnCasa.WebApp.Pages.Impresoras
{
    public class GestionImpresora : PageModel
    {
        private readonly ILogger<GestionImpresora> _logger;

        public GestionImpresora(ILogger<GestionImpresora> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}