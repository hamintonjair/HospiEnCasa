using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospiEnCasa.Dominio
{
    public class CompraRepuesto : Repuesto
    {
        public int id { get; set; }
        public string tipo_repuesto { get; set; }
        public decimal valor { get; set; }
        public DateTime fecha_compra { get; set; }
       
    }
}