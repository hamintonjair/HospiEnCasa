using System;
using HospiEnCasa.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace HospiEnCasa.Persistencia
{
    public interface IModuloRepository
    {
       
        int AdicionarModulo(Modulo modulo);
        bool Add(Modulo modulo);
        Modulo Buscar(int id);
        IEnumerable<Modulo> GetAll();
        List<Modulo> ObtenerTodo();
        // IEnumerable<Modulo> FindByName(string name);
        // IEnumerable<Modulo> FindMultipleParameter(string value);
        int Update(Modulo modulo);
        int Delete(Modulo modulo);

        IEnumerable<Modulo> ObtenerTodosModulo();
        // List<Modulo> ObtenerModuloPorNombre(string modulo);
        // IEnumerable<Modulo> Buscador(string busqueda);
        int ActualizarModulo(Modulo modulo);
        int EliminarModulo(Modulo modulo);
      
    } 
   
}
