using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospiEnCasa.Dominio
{ 
    public class Revision
    {
       public int id { get; set; }
       public string valor { get; set; }
       public string detalles { get; set; }
       public string fecha_revision { get; set; }     
        //agregación     
       public Persona persona { get; set; }
       public Impresora impresora { get; set; }
       public Repuesto repuesto { get; set; }
       public TipoRevision revision { get; set; }
       public Estado estado { get; set; }
    }
    
}