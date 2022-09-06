using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospiEnCasa.Dominio
{ 
    public class Revision : Impresora
    {
       public int id { get; set; }
       public decimal valor { get; set; }
       public string detalles { get; set; }
       public DateTime fecha_revision { get; set; }   
        //agregación     
        public Persona persona { get; set; }
        public CompraRepuesto compra { get; set; }
        public Estado estado { get; set; }
      

    
    }
    
}