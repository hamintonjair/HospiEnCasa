
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospiEnCasa.Dominio
{
    public class SeguroImpresora
    {
       public int id { get; set; }
       public string tipo_seguro { get; set; }
       public string precio { get; set; }            
       public string fecha_activacion { get; set; }
       public string fecha_vencimiento { get; set; } 
           //agregación  
       public Impresora impresora { get; set; }
    }
}