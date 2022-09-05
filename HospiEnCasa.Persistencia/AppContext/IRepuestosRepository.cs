using System;
using HospiEnCasa.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace HospiEnCasa.Persistencia
{
    public interface IRepuestosRepository
    {
        int Add(Repuesto repuesto);

        int AdicionarRepuesto(Repuesto repuesto);
        bool Add(Repuesto repuesto);
        Repuesto Buscar(int id);
        IEnumerable<Repuesto> GetAll();
        List<Repuesto> ObtenerTodo();
        IEnumerable<Repuesto> FindByName(string name);
        IEnumerable<Repuesto> FindMultipleParameter(string value);
        int Update(Repuesto repuesto);
        int Delete(Repuesto repuesto);

        IEnumerable<Repuesto> ObtenerTodosRepuesto();
        List<Repuesto> ObtenerRepuestoPorNombre(string repuesto);
        IEnumerable<Repuesto> Buscador(string busqueda);
        int ActualizarRepuesto(Repuesto repuesto);
        int EliminarRepuesto(Repuesto repuesto);
    } 
   
}
