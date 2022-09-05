using System;
using HospiEnCasa.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace HospiEnCasa.Persistencia
{
    public interface ISeguroImpresorasRepository
    {
        int AdicionarSeguroImpresora(SeguroImpresora seguroImpresora);
        bool Add(SeguroImpresora seguroImpresora);
        SeguroImpresora Buscar(int id);
        IEnumerable<SeguroImpresora> GetAll();
        List<SeguroImpresora> ObtenerTodo();
        IEnumerable<SeguroImpresora> FindByName(string name);
        IEnumerable<SeguroImpresora> FindMultipleParameter(string value);
        int Update(SeguroImpresora seguroImpresora);
        int Delete(SeguroImpresora seguroImpresora);

        IEnumerable<SeguroImpresora> ObtenerTodosSeguroImpresora();
        List<SeguroImpresora> ObtenerSeguroImpresoraPorNombre(string seguroImpresora);
        IEnumerable<SeguroImpresora> Buscador(string busqueda);
        int ActualizarSeguroImpresora(SeguroImpresora seguroImpresora);
        int EliminarSeguroImpresora(SeguroImpresora seguroImpresora);
    } 
   
}
