using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace HospiEnCasa.WebApp.Pages.Login
{
    public class GestionLogin : PageModel
    {
        private readonly ILogger<GestionLogin> _logger;

        public GestionLogin(ILogger<GestionLogin> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}