using System;
using HospiEnCasa.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace HospiEnCasa.Persistencia
{
    public interface IRevisionesRepository
    {    

        int AdicionarRevision(Revision Revision);
        bool Add(Revision Revision);
        Revision Buscar(int id);
        IEnumerable<Revision> GetAll();
        List<Revision> ObtenerTodo();
        IEnumerable<Revision> FindByName(string name);
        IEnumerable<Revision> FindMultipleParameter(string value);
        int Update(Revision Revision);
        int Delete(Revision Revision);

        IEnumerable<Revision> ObtenerTodosRevision();
        List<Revision> ObtenerRevisionPorNombre(string Revision);
        IEnumerable<Revision> Buscador(string busqueda);
        int ActualizarRevision(Revision Revision);
        int EliminarRevision(Revision Revision);
    } 
   
}
