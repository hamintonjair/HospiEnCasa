using System;
using HospiEnCasa.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace HospiEnCasa.Persistencia
{
    public interface IRevisionesRepository
    {    

        int AdicionarRevision(Revision revision);
        bool Add(Revision revision);
        Revision Buscar(int id);
        IEnumerable<Revision> GetAll();
        List<Revision> ObtenerTodo();
        // IEnumerable<Revision> FindByName(string name);
        // IEnumerable<Revision> FindMultipleParameter(string value);
        int Update(Revision revision);
        int Delete(Revision revision);

        IEnumerable<Revision> ObtenerTodosRevision();
        // List<Revision> ObtenerRevisionPorNombre(string Revision);
        // IEnumerable<Revision> Buscador(string busqueda);
        int ActualizarRevision(Revision revision);
        int EliminarRevision(Revision revision);
    } 
   
}
