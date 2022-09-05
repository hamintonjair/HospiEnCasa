using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospiEnCasa.Dominio
{
    public class Repuesto
    {
       public int id { get; set; }
       public string repuesto1 { get; set; }
       public int cantidad { get; set; }
       public decimal valor { get; set; }
    }
}