using System;
using HospiEnCasa.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace HospiEnCasa.Persistencia
{
    public interface INivelEstudiosRepository
    {
        
        int AdicionarNivelEstudio(NivelEstudio nivelEstudio);
        bool Add(NivelEstudio nivelEstudio);
        NivelEstudio Buscar(int id);
        IEnumerable<NivelEstudio> GetAll();
        List<NivelEstudio> ObtenerTodo();
        IEnumerable<NivelEstudio> FindByName(string name);
        IEnumerable<NivelEstudio> FindMultipleParameter(string value);
        int Update(NivelEstudio nivelEstudio);
        int Delete(NivelEstudio nivelEstudio);

        IEnumerable<NivelEstudio> ObtenerTodosNivelEstudio();
        List<NivelEstudio> ObtenerNivelEstudioPorNombre(string nombre);
        IEnumerable<NivelEstudio> Buscador(string busqueda);
        int ActualizarNivelEstudio(NivelEstudio nivelEstudio);
        int EliminarNivelEstudio(NivelEstudio nivelEstudio);
    
    } 
   
}
