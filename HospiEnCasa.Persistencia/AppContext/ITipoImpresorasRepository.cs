using System;
using HospiEnCasa.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace HospiEnCasa.Persistencia
{
    public interface ITipoImpresorasRepository
    {
        int Add(TipoImpresora tipoImpresora);
        int AdicionarTipoImpresora(TipoImpresora tipoImpresora);
        bool Add(TipoImpresora tipoImpresora);
        TipoImpresora Buscar(int id);
        IEnumerable<TipoImpresora> GetAll();
        List<TipoImpresora> ObtenerTodo();
        IEnumerable<TipoImpresora> FindByName(string name);
        IEnumerable<TipoImpresora> FindMultipleParameter(string value);
        int Update(TipoImpresora tipoImpresora);
        int Delete(TipoImpresora tipoImpresora);

        IEnumerable<TipoImpresora> ObtenerTodosTipoImpresora();
        List<TipoImpresora> ObtenerTipoImpresoraPorNombre(string tipoImpresora);
        IEnumerable<TipoImpresora> Buscador(string busqueda);
        int ActualizarTipoImpresora(TipoImpresora tipoImpresora);
        int EliminarTipoImpresora(TipoImpresora tipoImpresora);
    } 
   
}
