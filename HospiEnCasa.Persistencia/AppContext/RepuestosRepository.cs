using System;
using HospiEnCasa.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace HospiEnCasa.Persistencia
{
    public class RepuestosRepository : IRepuestosRepository
    {
        //instancia
        private readonly AppContext _context;

        //constructor
        public RepuestosRepository(AppContext context)
        {
          _context = context;
        }         
    //    //Guardar
    //     int IRepuestosRepository.AdicionarRepuesto(Repuesto repuesto){
    //        _context.Repuestos.Add(repuesto);
    //        return _context.SaveChanges();
    //    }       
    //     //buscar por id
    //     bool IRepuestosRepository.Add(Repuesto repuesto){
    //         _context.Repuestos.Add(repuesto);
    //         return (_context.SaveChanges() > 0 ? true : false);            
    //     }
    //     //Añadir
    //     Repuesto IRepuestosRepository.Buscar(int id){
    //         return _context.Repuestos.Find(id);
    //     }
    //     //enumerar
    //     IEnumerable<Repuesto> IRepuestosRepository.GetAll(){
    //         return _context.Repuestos;
    //     }
    //     //listar
    //     List<Repuesto> IRepuestosRepository.ObtenerTodo(){
    //         return _context.Repuestos.ToList();
    //     }
    //     //buscar por nombre
    //     IEnumerable<Repuesto> IRepuestosRepository.FindByName(string name){
    //         return _context.Repuestos.Where(p => p.n_Repuesto.Contains(name) );
    //     }

    //     IEnumerable<Repuesto> IRepuestosRepository.FindMultipleParameter(string value){
    //         return _context.Repuestos.Where(p => p.n_Repuesto.Contains(value));
    //     }
    //     //actualizar
    //     int IRepuestosRepository.Update(Repuesto repuesto){
    //         _context.Repuestos.Update(repuesto);
    //         return _context.SaveChanges();
    //     }
    //     //eliminar
    //     int IRepuestosRepository.Delete(Repuesto repuesto){
    //         _context.Repuestos.Remove(repuesto);
    //         return _context.SaveChanges();
    //     }

    //     IEnumerable<Repuesto> IRepuestosRepository.ObtenerTodosRepuesto(){
    //         return _context.Repuestos;
    //     }

    //     List<Repuesto> IRepuestosRepository.ObtenerRepuestoPorNombre(string nombre){
    //         return _context.Repuestos.Where( p => p.n_Repuesto.Contains(nombre) ).ToList();
    //     }

    //     IEnumerable<Repuesto> IRepuestosRepository.Buscador(string busqueda){
    //         return _context.Repuestos.Where(p => p.n_Repuesto.Contains(busqueda));
    //     }

    //     int IRepuestosRepository.ActualizarRepuesto(Repuesto repuesto){
    //         _context.Repuestos.Update(repuesto);
    //         return _context.SaveChanges();
    //     }

    //     int IRepuestosRepository.EliminarRepuesto(Repuesto repuesto){
    //         _context.Repuestos.Remove(repuesto);
    //         return _context.SaveChanges();
    //     }
    }
   
}
