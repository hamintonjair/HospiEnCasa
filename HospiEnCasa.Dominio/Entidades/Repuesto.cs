using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospiEnCasa.Dominio
{
    public class Repuesto
    {
       public int id { get; set; }
       public string n_Repuesto { get; set; }
       public string cantidad { get; set; }
       public string valor { get; set; }  
    }
}