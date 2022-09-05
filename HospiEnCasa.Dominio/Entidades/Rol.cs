using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospiEnCasa.Dominio
{
    public class Rol : Persona
    {
       public int id { get; set; }
       public string nombre { get; set; }
       public int personaId { get; set; }
    }
}