using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace HospiEnCasa.WebApp.Pages.Personas
{
    public class GestionPersona : PageModel
    {
        private readonly ILogger<GestionPersona> _logger;

        public GestionPersona(ILogger<GestionPersona> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}