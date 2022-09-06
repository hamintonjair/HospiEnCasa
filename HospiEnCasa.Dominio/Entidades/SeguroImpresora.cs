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
       public Decimal precio { get; set; }
       public DateTime fecha_activacion { get; set; }
       public DateTime fecha_vencimiento { get; set; } 
    }
}