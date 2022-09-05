using System;
using HospiEnCasa.Dominio;
using HospiEnCasa.Persistencia;
using System.Linq;
using System.Collections.Generic;

namespace HospiEnCasa.Persistencia
{
    public class CompraRepuestosRepository : ICompraRepuestosRepository
    {
      //instancia
      private readonly AppContext _context;

        //constructor
        public CompraRepuestosRepository(AppContext context)
        {
          _context = context;
        }   
        //Guardar
        int ICompraRepuestosRepository.AdicionarCompraRepuesto(CompraRepuesto compraRepuestos){
           _context.CompraRepuestos.Add(compraRepuestos);
           return _context.SaveChanges();
       }       
        //buscar por id
        bool ICompraRepuestosRepository.Add(CompraRepuesto compraRepuestos){
            _context.CompraRepuestos.Add(compraRepuestos);
            return (_context.SaveChanges() > 0 ? true : false);            
        }
        //Añadir
        CompraRepuesto ICompraRepuestosRepository.Buscar(int id){
            return _context.CompraRepuestos.Find(id);
        }
        //enumerar
        IEnumerable<CompraRepuesto> ICompraRepuestosRepository.GetAll(){
            return _context.CompraRepuestos;
        }
        //listar
        List<CompraRepuesto> ICompraRepuestosRepository.ObtenerTodo(){
            return _context.CompraRepuestos.ToList();
        }
        //buscar por nombre
        IEnumerable<CompraRepuesto> ICompraRepuestosRepository.FindByName(string name){
            return _context.CompraRepuestos.Where(p => p.tipo_repuesto.Contains(name) );
        }

        IEnumerable<CompraRepuesto> ICompraRepuestosRepository.FindMultipleParameter(string value){
            return _context.CompraRepuestos.Where(p => p.tipo_repuesto.Contains(value) ||
            p.valor.Contains(value) || p.fecha_compra.Contains(value) || p.repuesto1.Contains(value));
        }
        //actualizar
        int ICompraRepuestosRepository.Update(CompraRepuesto compraRepuestos){
            _context.CompraRepuestos.Update(compraRepuestos);
            return _context.SaveChanges();
        }
        //eliminar
        int ICompraRepuestosRepository.Delete(CompraRepuesto compraRepuestos){
            _context.CompraRepuestos.Remove(compraRepuestos);
            return _context.SaveChanges();
        }

        IEnumerable<CompraRepuesto> ICompraRepuestosRepository.ObtenerTodosC_Repuestos(){
            return _context.CompraRepuestos;
        }

        List<CompraRepuesto> ICompraRepuestosRepository.ObtenerC_RepuestosPorNombre(string nombre){
            return _context.CompraRepuestos.Where( p => p.tipo_repuesto.Contains(nombre) ).ToList();
        }

        IEnumerable<CompraRepuesto> ICompraRepuestosRepository.Buscador(string busqueda){
            return _context.CompraRepuestos.Where(p => p.tipo_repuesto.Contains(value) ||
              p.valor.Contains(value) ||  p.fecha_compra.Contains(value) || p.repuesto1.Contains(value));
        }

        int ICompraRepuestosRepository.ActualizarC_Repuestos(CompraRepuesto compraRepuestos){
            _context.CompraRepuestos.Update(compraRepuestos);
            return _context.SaveChanges();
        }

        int ICompraRepuestosRepository.EliminarC_Repuestos(CompraRepuesto compraRepuestos){
            _context.CompraRepuestos.Remove(compraRepuestos);
            return _context.SaveChanges();
        }
       
    }
   
}
