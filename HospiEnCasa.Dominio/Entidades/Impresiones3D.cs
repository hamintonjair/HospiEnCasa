using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospiEnCasa.Dominio
{
    public class Impresiones3D : Impresora
    {
       public int id { get; set; }
       public string cliente { get; set; }
       public string Tipo_impresion { get; set; }
       public int cantidad { get; set; }
       public decimal precio { get; set; }      

    }
}