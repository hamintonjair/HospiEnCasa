using System;
using HospiEnCasa.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace HospiEnCasa.Persistencia
{
    public interface ICompraRepuestosRepository
    {
       
        int AdicionarCompraRepuesto(CompraRepuesto compraRepuesto);
        bool Add(CompraRepuesto compraRepuesto);
        CompraRepuesto Buscar(int id);
        IEnumerable<CompraRepuesto> GetAll();
        List<CompraRepuesto> ObtenerTodo();
        IEnumerable<CompraRepuesto> FindByName(string name);
        IEnumerable<CompraRepuesto> FindMultipleParameter(string value);
        int Update(CompraRepuesto compraRepuesto);
        int Delete(CompraRepuesto compraRepuesto);

        IEnumerable<CompraRepuesto> ObtenerTodosC_Repuestos();
        List<CompraRepuesto> ObtenerC_RepuestosPorNombre(string estudio);
        IEnumerable<CompraRepuesto> Buscador(string busqueda);
        int ActualizarC_Repuestos(CompraRepuesto compraRepuesto);
        int EliminarC_Repuestos(CompraRepuesto compraRepuesto);
      
    } 
   
}
