using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospiEnCasa.Dominio
{
    public class Modulo
    {
        public int id { get; set; }
        public string usuario { get; set; }    
        public string repuestos { get; set; }  
        public string seguro { get; set; } 
        public string impresora { get; set; }    
        public string impresion3d { get; set; }  
        public string revision { get; set; }    
        public string finalizado { get; set; }    
        public Rol rol { get; set; }       
    }
}