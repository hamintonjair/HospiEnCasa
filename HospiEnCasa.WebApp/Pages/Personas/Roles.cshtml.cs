
using System.Xml.Schema;
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
    public class Roles : PageModel
    {
        private readonly ILogger<Roles> _logger;

        public Roles(ILogger<Roles> logger)
        {
            _logger = logger;
        }

        private IPersonaRepository persona = new PersonaRepository(new HospiEnCasa.Persistencia.AppContext());
        private IRolesRepository rol = new RolesRepository(new HospiEnCasa.Persistencia.AppContext());
        public List<Persona> listadoPersona {get; set; }
        public List<Rol> listado_Rol {get; set; }


        public void OnGet()
        {
           listadoPersona = new List<Persona>();
           listadoPersona = persona.ObtenerTodo();
           listado_Rol = new List<Rol>();       
           listado_Rol = rol.ObtenerTodo();
        }

        public void OnPost()
        {
            var mensaje = "";   
            var _rol     = Request.Form["rol"];
            var password = Request.Form["password"];
            var _persona  = Request.Form["persona"];
  
            //validamos que no exista para poder regiostrarlo
            var validado = rol.FindByName(_rol);
            var validadoPersona = persona.Buscar(Int32.Parse(_persona));
         
            //VALIDAMOS SI EL DATO INGRESADO ES VACIO
           if(String.IsNullOrEmpty(_rol) || String.IsNullOrEmpty(password)){

                 mensaje = "Error, debes llenar todos los campos";
                  OnGet();    
           }else{

                if (validado != null)
                {                    
                    var N_rol = new Rol{
                        tipo_Rol = _rol,
                        password = password,
                      //  persona = persona,
                    };
                        rol.AdicionarRol(N_rol);

                        N_rol.persona = validadoPersona;
                        var result =   rol.Update(N_rol);

                    if(result > 0){
                       mensaje ="Rol agregado con exito";
                       OnGet();                 
                        // Response.Redirect("page");  
                    }else{
                        mensaje = "No se pudo ingresar el registro";
                    }
                }else
                {
                  mensaje = "No se puede duplicar el rol";
                }
           }
         TempData["mensaje"] = mensaje;
           
        }
    }
}