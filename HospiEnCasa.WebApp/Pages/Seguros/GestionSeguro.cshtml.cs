using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using HospiEnCasa.Dominio;
using HospiEnCasa.Persistencia;

namespace HospiEnCasa.WebApp.Pages.Seguros
{
    public class GestionSeguro : PageModel
    {
        private readonly ILogger<GestionSeguro> _logger;

        public GestionSeguro(ILogger<GestionSeguro> logger)
        {
            _logger = logger;
        }

        private ISeguroImpresorasRepository seguro = new SeguroImpresorasRepository(new HospiEnCasa.Persistencia.AppContext());        
        private IImpresorasRepository _impresora = new ImpresorasRepository(new HospiEnCasa.Persistencia.AppContext());
        public List<SeguroImpresora> listadoSeguro {get; set; }  
        public List<Impresora> listadoImpresora {get; set; }

        public void OnGet()
        {
            listadoSeguro = new List<SeguroImpresora>();
            listadoSeguro = seguro.ObtenerTodo();
            listadoImpresora = new List<Impresora>();
            listadoImpresora = _impresora.ObtenerTodo();
        }
         public void OnPost()
        {
            var mensaje = "";  
            var tipoSeguro       = Request.Form["tipoSeguro"];
            var precio           = Request.Form["precio"];
            var fechaActivacion  = Request.Form["fechaActivacion"];
            var fechaVencimiento =Request.Form["fechaVencimiento"];
            var impresora =Request.Form["impresora"];
            
           
              Console.WriteLine("No" +tipoSeguro + " , " +precio+ " , " + fechaActivacion, fechaVencimiento); 
            //VALIDAMOS SI EL DATO INGRESADO ES VACIO
           if(String.IsNullOrEmpty(tipoSeguro) || String.IsNullOrEmpty(fechaActivacion) || String.IsNullOrEmpty(fechaVencimiento) 
           || String.IsNullOrEmpty(precio)){

                  mensaje = "Error, debes llenar todos los campos";
                      
           }else{
          
               var N_seguros = new SeguroImpresora{

                    tipo_seguro = tipoSeguro,
                    precio =  precio,
                    fecha_activacion = fechaActivacion,
                    fecha_vencimiento = fechaVencimiento,
                };

                //validamos que no exista para poder regiostrarlo
                var _validado = _impresora.Buscar(Int32.Parse(impresora));
                var validado = seguro.FindByName(tipoSeguro);

                if(validado != null){

                     seguro.AdicionarSeguroImpresora(N_seguros);

                     N_seguros.impresora = _validado;
                    var result = seguro.Update(N_seguros);
                    if(result > 0){
                        mensaje = "Seguro Agrregado con exito"; 
                        OnGet();                        
                        // Response.Redirect("page");  
                    }else{
                      mensaje= "No se pudo ingresar el registro";
                    }
                }else{
                    mensaje = "Ya heciste un seguro con esté Nombre";
                }
            }
           TempData["mensaje"] = mensaje;
        }
    }
}