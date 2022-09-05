using System;
using HospiEnCasa.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace HospiEnCasa.Persistencia
{
    public interface IImpresion3DRepository
    {    
        int AdicionarImpresiones3D(Impresiones3D impresiones3D);
        bool Add(Impresiones3D impresiones3D);
        Impresiones3D Buscar(int id);
        IEnumerable<Impresiones3D> GetAll();
        List<Impresiones3D> ObtenerTodo();
        IEnumerable<Impresiones3D> FindByName(string name);
        IEnumerable<Impresiones3D> FindMultipleParameter(string value);
        int Update(Impresiones3D impresiones3D);
        int Delete(Impresiones3D impresiones3D);

        IEnumerable<Impresiones3D> ObtenerTodosImpresiones3D();
        List<Impresiones3D> ObtenerImpresiones3DPorNombre(string impresion3D);
        IEnumerable<Impresiones3D> Buscador(string busqueda);
        int ActualizarImpresiones3D(Impresiones3D impresiones3D);
        int EliminarImpresiones3D(Impresiones3D impresiones3D);
        
    } 
   
}
