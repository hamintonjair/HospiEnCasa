
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
    public class GestionPersona : PageModel
    {
        private readonly ILogger<GestionPersona> _logger;

        public GestionPersona(ILogger<GestionPersona> logger)
        {
            _logger = logger;
        }

        private INivelEstudiosRepository studio = new NivelEstudiosRepository(new HospiEnCasa.Persistencia.AppContext());
        private IPersonaRepository persona = new PersonaRepository(new HospiEnCasa.Persistencia.AppContext());
      
        public List<NivelEstudio> listadoNivelEstudio {get; set; }
        public List<Persona> listadoPersona {get; set; }

      
        public void OnGet()
        {             
            listadoNivelEstudio = new List<NivelEstudio>();
            listadoNivelEstudio = studio.ObtenerTodo();
            listadoPersona = new List<Persona>();
            listadoPersona = persona.ObtenerTodo();
 
        }       

        public void OnPost(){

            var mensaje = "";       
            
             var nombre      = Request.Form["nombre"];
             var apellido    = Request.Form["apellido"];
             var identificacion  = Request.Form["identificacion"];
             var telefono    = Request.Form["telefono"];                 
             var fecha       = Request.Form["fecha"];
             var direccion   = Request.Form["direccion"];
             var email       = Request.Form["email"];
             var _socio       = Request.Form["socio"];
             var nivel_Estudio = Request.Form["profesion"];
             
             var _persona = "";
           //traemos el listado de personas para poder sacar la cedula y comparar           
            OnGet();
             foreach (var p in listadoPersona)
            {
                 _persona = p.cedula;
            }

            //validamos que no exista para poder regiostrarlo
            var validado = studio.Buscar(Int32.Parse(nivel_Estudio));
                          
            if(_persona == identificacion){
                  mensaje = "¡Atención!, Ya existe un registro con esta identificación, " + identificacion;           
            }
            //VALIDAMOS SI EL DATO INGRESADO ES VACIO
           if(String.IsNullOrEmpty(apellido) || String.IsNullOrEmpty(nombre) || 
           String.IsNullOrEmpty(identificacion) || String.IsNullOrEmpty(telefono)
           || String.IsNullOrEmpty(email) ||  String.IsNullOrEmpty(_socio) 
           ||  String.IsNullOrEmpty(nivel_Estudio)){

                 mensaje = "Error, debes llenar todos los campos";               
                 OnGet();    
           
           }
           if ( _persona != identificacion ){

                if (validado.id > 0)
                {  
             
            //    var  Estudio =  validado.id;               
               
                  var N_persona = new Persona{

                        nombre = nombre,
                        apellidos = apellido,
                        cedula = identificacion,             
                        telefono = telefono,
                        fecha_nacimiento = fecha,
                        direccion = direccion,
                        email = email,                       
                                                                       
                        socio =  (_socio == "1" ? Socio.Si : Socio.No),
                    
                     }; 
                                         
                      persona.Add(N_persona);

                      N_persona.nivelEstudio = validado;
                      var result = persona.Update(N_persona);
                      
                      
                    if(result > 0){
                        mensaje = "Nivel de estudio creado con exito" ;                    
                        OnGet();     
                
                    }else{
                        mensaje = "No se pudo agregar el registro";                   
                    }
                }else{
                    mensaje = "Error, No se pudo agregar el registro";                  
                }              
           }
     
         TempData["mensaje"] = mensaje;

        }
        //https://www.youtube.com/watch?v=3mu2K5vXcxc&ab_channel=render2web
       
    //    public IActionResult Edit(int ? id)
    //    {
    //      if(id == null || id == 0)
    //      {
    //         return NotFound();
    //      }

    //      var _persona = persona.Buscar(id);

    //      if(_persona == null)
    //      {
    //           return NotFound();
    //      } 

    //     // return Redirect(".\GestionPersona");
    //    }
    }
}