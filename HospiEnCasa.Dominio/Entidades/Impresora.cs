using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospiEnCasa.Dominio
{
    public class Impresora
    {
       public int id { get; set; }
       public string nombre { get; set; }
       public string marca { get; set; }
       public string placa { get; set; }       
       public string ano_modelo { get; set; }
       public string velocidad_imp { get; set; }
       public string volumen_imp { get; set; }
       public string pais_origen { get; set; }
       public string fecha_mantenimiento { get; set; }
       public string detalles { get; set; }
       public string otros_caracteristicas { get; set; } 
           //agregación   
       public TipoImpresora tipoImpresora { get; set; }    

    }
}