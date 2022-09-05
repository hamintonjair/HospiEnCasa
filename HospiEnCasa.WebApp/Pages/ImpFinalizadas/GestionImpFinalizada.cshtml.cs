using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace HospiEnCasa.WebApp.Pages.ImpFinalizadas
{
    public class GestionImpFinalizada : PageModel
    {
        private readonly ILogger<GestionImpFinalizada> _logger;

        public GestionImpFinalizada(ILogger<GestionImpFinalizada> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}