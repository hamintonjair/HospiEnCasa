using System.Net;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using HospiEnCasa.Dominio;
using HospiEnCasa.Persistencia;

namespace HospiEnCasa.WebApp.Pages.Personas
{
    public class NivelStudio : PageModel
    {
        private readonly ILogger<NivelStudio> _logger;

        public NivelStudio(ILogger<NivelStudio> logger)
        {
            _logger = logger;
        }
        private INivelEstudiosRepository studio = new NivelEstudiosRepository(new HospiEnCasa.Persistencia.AppContext());
        public List<NivelEstudio> listadoNivelEstudio {get; set; }
        
        public void OnGet()
        {
            listadoNivelEstudio = new List<NivelEstudio>();
            listadoNivelEstudio = studio.ObtenerTodo();
        }

        public void OnPost()
        {
            var mensaje = "";    

            var nivelStudio = Request.Form["nivelEstudio"];

            var _nivelStudio = "";
           //traemos el listado de personas para poder sacar la cedula y comparar           
            OnGet();
            foreach (var p in listadoNivelEstudio)
            {
                 _nivelStudio = p.estudio;
            }
            if(_nivelStudio == nivelStudio){
                  mensaje = "¡Atención!,Ya heciste un Tipo de impresora con este Nombre " + nivelStudio;           
            }
            //VALIDAMOS SI EL DATO INGRESADO ES VACIO
           if(String.IsNullOrEmpty(nivelStudio)){

                  mensaje = "Error, debes llenar todos los campos";
                    
           }

           if(_nivelStudio != nivelStudio){
          
                var N_estudio = new NivelEstudio{
                estudio = nivelStudio
                };

                var validado = studio.FindByName(nivelStudio);

                 if(validado != null){

                     var result = studio.AdicionarNivelEstudio(N_estudio);

                        if(result > 0){
                            mensaje = "Nivel de estudio agregado con exito";
                            OnGet();                   
                            // Response.Redirect("page");  
                        }else{
                        mensaje = "No se pudo ingresar el registro";
                        }
                  }else{
                        mensaje = "Ya heciste un Tipo de impresora con este Nombre";
                    }
               
           }

           TempData["mensaje"] = mensaje;
        }
    }
}