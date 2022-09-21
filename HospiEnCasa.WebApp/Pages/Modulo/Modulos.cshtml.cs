using System.Xml.Schema;
using System.Net.Sockets;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.Dominio;
using HospiEnCasa.Persistencia;
using Microsoft.Extensions.Logging;

namespace HospiEnCasa.WebApp.Pages.Modulos
{
    public class Modulos : PageModel
    {
        private readonly ILogger<Modulos> _logger;

        public Modulos(ILogger<Modulos> logger)
        {
            _logger = logger;
        }

        private IModuloRepository _modulo = new ModuloRepository(new HospiEnCasa.Persistencia.AppContext());
        private IRolesRepository _rol = new RolesRepository(new HospiEnCasa.Persistencia.AppContext());
        private IPersonaRepository _persona = new PersonaRepository(new HospiEnCasa.Persistencia.AppContext());
        public List<Modulo> listadoModulo {get; set; }
        public List<Rol> listadoRol {get; set; }
        public List<Persona> listadoPersona {get; set; }
       
        public void OnGet()
        {
            listadoModulo  = new List<Modulo>();
            listadoModulo  = _modulo.ObtenerTodo();
            listadoRol     = new List<Rol>();
            listadoRol     = _rol.ObtenerTodo();
            listadoPersona = new List<Persona>();
            listadoPersona = _persona.ObtenerTodo();
        }
        public void OnPost()
        {
            var mensaje = "";    

             var rol         = Request.Form["rol"];
             var usuario     = Request.Form["usuario"];
             var seguro      = Request.Form["seguro"];
             var impresora   = Request.Form["impresora"];
             var impresion3D = Request.Form["impresion3D"];
             var repuesto    = Request.Form["repuesto"];
             var revision    = Request.Form["revision"];
             var finalizado  = Request.Form["finalizado"];
      
             //validamos que no exista para poder regiostrarlo
            var validado = _rol.Buscar(Int32.Parse(rol));          
           
            //VALIDAMOS SI EL DATO INGRESADO ES VACIO
           if(String.IsNullOrEmpty(rol)){

                mensaje = "Debes Escoger un rol";
                  OnGet();
           }   
            var _id="" ;                    
            OnGet();
            //consultamos el rol asociado a este modulo mediante su id
            foreach (var p in listadoModulo)
            {
                 _id = p.rol.tipo_Rol;
            }  
            //comparamos que el modulo consultado es igual al ingresado       
           if (_id == validado.tipo_Rol)     
            {                   
                mensaje = "Ya tiene asignado unos módulos, si va actualizar un módulo debes editarlo";
                OnGet();   
                                                       
            }else{

                var N_modulo = new Modulo{  
                           
                usuario     = usuario,
                repuestos   = repuesto,
                seguro      = seguro,
                impresora   = impresora,
                impresion3d = impresion3D,
                revision    = revision,
                finalizado  = finalizado,
                                               
                };  
                _modulo.AdicionarModulo(N_modulo);

                N_modulo.rol = validado;
                var result = _modulo.Update(N_modulo);

                if(result > 0){

                  mensaje = "Los módulos fueron asignados con exito ";
                  OnGet();                   
                                
                 }else{
                   mensaje = "No se pudo asignar los módulo";
                 }           
            };     
           TempData["mensaje"] = mensaje;
        }
    }
}