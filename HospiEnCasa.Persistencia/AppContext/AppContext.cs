using System.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospiEnCasa.Dominio;
using Microsoft.EntityFrameworkCore;

namespace HospiEnCasa.Persistencia
{
    public class AppContext : DbContext
    {
       public DbSet<Persona> Personas {get; set;}
       public DbSet<CompraRepuesto> CompraRepuestos {get; set;}             
       public DbSet<Impresiones3D> Impresion3D {get; set;}
       public DbSet<Impresora> Impresoras {get; set;}          
       public DbSet<Login> Loggin {get; set;}  
       public DbSet<NivelEstudio> NivelEstudios {get; set;}
       public DbSet<Repuesto> Repuestos {get; set;}          
       public DbSet<Revision> Revisiones {get; set;}  
       public DbSet<Rol> Roles {get; set;}
       public DbSet<SeguroImpresora> SeguroImpresoras {get; set;}          
       public DbSet<TipoImpresora> TipoImpresoras {get; set;}  
       
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {
            if(!optionsBuilder.IsConfigured)
            {
               //cambian "MONO\\SQLEXPRESS" por el nombre de su instancia de la DB
               //crean la base de datos con este nombre "MantenimientoImpresora"
               //si tienen usuario copia este " User id=sa" y el password "menaH01+" lo reemplazas por el que hayas puesto
                 optionsBuilder.UseSqlServer("Server=MONO\\SQLEXPRESS; database=MantenimientoImpresora; User id=sa;password=menaH01+; Integrated Security=True;");
            }
       }

    }
}