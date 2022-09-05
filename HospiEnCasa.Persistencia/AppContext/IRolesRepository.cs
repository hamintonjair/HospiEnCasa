using System;
using HospiEnCasa.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace HospiEnCasa.Persistencia
{
    public interface IRolesRepository
    {    
        int AdicionarRol(Rol rol);
        bool Add(Rol rol);
        Rol Buscar(int id);
        IEnumerable<Rol> GetAll();
        List<Rol> ObtenerTodo();
        IEnumerable<Rol> FindByName(string name);
        IEnumerable<Rol> FindMultipleParameter(string value);
        int Update(Rol rol);
        int Delete(Rol rol);

        IEnumerable<Rol> ObtenerTodosRol();
        List<Rol> ObtenerRolPorNombre(string rol);
        IEnumerable<Rol> Buscador(string busqueda);
        int ActualizarRol(Rol rol);
        int EliminarRol(Rol rol);
    } 
   
}
