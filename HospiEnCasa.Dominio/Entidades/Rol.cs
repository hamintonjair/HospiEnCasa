using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospiEnCasa.Dominio
{
    public class Rol
    {
       public int id { get; set; }  
       public string tipo_Rol { get; set; }   
       public string password { get; set; }
       public Persona persona { get; set; }  

    }
}