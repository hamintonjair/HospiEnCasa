using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospiEnCasa.Dominio
{
    public class Impresiones3D
    {
       public int id { get; set; }
       public string cliente { get; set; }
       public string Tipo_impresion { get; set; }
       public string cantidad { get; set; }
       public string precio { get; set; }  
           //agregación  
       public Impresora impresora { get; set; }       

    }
}