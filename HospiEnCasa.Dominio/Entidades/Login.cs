using System.ComponentModel.Design.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospiEnCasa.Dominio
{
    public class Login : Rol
    {
       public int id { get; set; }    
       public string password { get; set; }   
       public  Rol rol { get; set; } 

    
    }
}