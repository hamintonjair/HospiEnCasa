
using System.Security.Principal;
using System.Reflection.Metadata;
using System.Xml.XPath;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using HospiEnCasa.Dominio;
using HospiEnCasa.Persistencia;

namespace HospiEnCasa.WebApp.Pages.Impresion3D
{
    public class Edit : PageModel
    {
        private readonly ILogger<Edit> _logger;

        public Edit(ILogger<Edit> logger)
        {
            _logger = logger;
        }

        public Impresiones3D impresiones;

        private IImpresion3DRepository impresion = new Impresion3DRepository(new HospiEnCasa.Persistencia.AppContext());
        public List<Impresiones3D> listadoImpresion3D {get; set; }
        
        public IActionResult OnGet(int Id)
        {
            listadoImpresion3D = new List<Impresiones3D>();
            listadoImpresion3D = impresion.ObtenerTodo();

             impresiones = impresion.Buscar(Id);

            if(impresiones == null){

                return RedirectToPage("./Gestionimpresion3D");

            }else{
                return Page();
            }
        }
        public IActionResult OnPost(){

            var mensaje = ""; 

            var id             = Request.Form["id"];
            var cliente        = Request.Form["cliente"];
            var Tipo_impresion = Request.Form["impresion3d"];
            var cantidad       = Request.Form["cantidad"];
            var precio         = Request.Form["precio"];

            var impresion3d = impresion.Buscar(Int32.Parse(id));

            if(impresion3d != null ){

                impresion3d.cliente = cliente;
                impresion3d.Tipo_impresion = Tipo_impresion;
                impresion3d.cantidad = cantidad;
                impresion3d.precio = precio;

                var result = impresion.Update(impresion3d);

                if(result > 0){

                    mensaje ="Se actualizaron los datos a "+ cliente;
                }else
                {                   
                   mensaje ="No fue posible la actualización"+ cliente;                    
                }
            }else
            {
                 mensaje ="Error, Se produjo un problemainterno, intente nuevamente ";
            }
            TempData["mensaje"] = mensaje;
            return RedirectToPage("./Gestionimpresion3D");
        }

        public IActionResult OnPostUpdate(){

            var mensaje = "";           
          
            mensaje ="Consumo Ajax";
          
            TempData["mensaje"] = mensaje;
            return Content("impresiones3d");
        }

         public IActionResult OnPostUpdateJson([FromBody]Impresiones3D impresiones3d){

            var mensaje = "";           
          
            mensaje ="Atención, Se actualizaron ";
          
            TempData["mensaje"] = mensaje;
            return new JsonResult( mensaje);
        }
    }
}