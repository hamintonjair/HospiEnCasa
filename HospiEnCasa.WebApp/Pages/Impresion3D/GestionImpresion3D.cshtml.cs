using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace HospiEnCasa.WebApp.Pages.Impresion3D
{
    public class GestionImpresion3D : PageModel
    {
        private readonly ILogger<GestionImpresion3D> _logger;

        public GestionImpresion3D(ILogger<GestionImpresion3D> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}