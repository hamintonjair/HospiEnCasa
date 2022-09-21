using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using HospiEnCasa.Dominio;
using HospiEnCasa.Persistencia;

namespace HospiEnCasa.WebApp.Pages.Impresoras
{
    public class Tipo_Impresora : PageModel
    {
        private readonly ILogger<Tipo_Impresora> _logger;

        public Tipo_Impresora(ILogger<Tipo_Impresora> logger)
        {
            _logger = logger;
        }

        private ITipoImpresorasRepository tipo_Impresora = new TipoImpresorasRepository(new HospiEnCasa.Persistencia.AppContext());
        public List<TipoImpresora> listadoTipoImpresora {get; set; }

        public void OnGet()
        {
            listadoTipoImpresora = new List<TipoImpresora>();
            listadoTipoImpresora = tipo_Impresora.ObtenerTodo();
        }

        public void OnPost()
        {
            var mensaje = "";  
            var _tipoImp = "";  
            var tipoImpresora = Request.Form["tipoImpresora"];           
          
            //recorremos el listado para sacar el datos que se necesita para comparar
            OnGet();
            foreach (var p in listadoTipoImpresora)
            {
                 _tipoImp = p.nombre_impresora;
            }

            if(_tipoImp == tipoImpresora){
                mensaje = "Ya heciste un tipo de impresora con este nombre " + tipoImpresora ;           
            }

            //VALIDAMOS SI EL DATO INGRESADO ES VACIO
           if(String.IsNullOrEmpty(tipoImpresora)){

                 mensaje= "Error, debes llenar todos los campos";
                     
           }
           
           //si es diferente ingresa a la consicion
           if ( _tipoImp != tipoImpresora ){
          
               var N_tipoImpresora = new TipoImpresora{
                     nombre_impresora = tipoImpresora

                };  

                var result = tipo_Impresora.AdicionarTipoImpresora(N_tipoImpresora);

                if(result > 0){
                        mensaje = "Tipo de impresora Agregado";  
                        OnGet();                        
                        // Response.Redirect("page");  
                }else{
                        mensaje = "No se pudo ingresar el registro";
                       
                }             
           
           }
           TempData["mensaje"] = mensaje;           
        }
    }
}