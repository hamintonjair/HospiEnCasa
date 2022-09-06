using System;
using HospiEnCasa.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace HospiEnCasa.Persistencia
{
    public class RevisionesRepository : IRevisionesRepository
    {
     //instancia
        private readonly AppContext _context;

        //constructor
        public RevisionesRepository(AppContext context)
        {
          _context = context;
        }      
       //Guardar
    //     int IRevisionesRepository.AdicionarRevision(Revision revision){
    //        _context.Revisiones.Add(revision);
    //        return _context.SaveChanges();
    //    }       
    //     //buscar por id
    //     bool IRevisionesRepository.Add(Revision revision){
    //         _context.Revisiones.Add(revision);
    //         return (_context.SaveChanges() > 0 ? true : false);            
    //     }
    //     //Añadir
    //     Revision IRevisionesRepository.Buscar(int id){
    //         return _context.Revisiones.Find(id);
    //     }
    //     //enumerar
    //     IEnumerable<Revision> IRevisionesRepository.GetAll(){
    //         return _context.Revisiones;
    //     }
    //     //listar
    //     List<Revision> IRevisionesRepository.ObtenerTodo(){
    //         return _context.Revisiones.ToList();
    //     }
    //     //buscar por nombre
    //     // IEnumerable<Revision> IRevisionesRepository.FindByName(string name){
    //     //     return _context.Revisiones.Where(p => p.persona.Contains(name) );
    //     // }

    //     // IEnumerable<Revision> IRevisionesRepository.FindMultipleParameter(string value){
    //     //     return _context.Revisiones.Where(p =>  p.detalles.Contains(value) 
    //     //     || p.persona.Contains(value));
    //     // }
    //     //actualizar
    //     int IRevisionesRepository.Update(Revision revision){
    //         _context.Revisiones.Update(revision);
    //         return _context.SaveChanges();
    //     }
    //     //eliminar
    //     int IRevisionesRepository.Delete(Revision revision){
    //         _context.Revisiones.Remove(revision);
    //         return _context.SaveChanges();
    //     }

    //     IEnumerable<Revision> IRevisionesRepository.ObtenerTodosRevision(){
    //         return _context.Revisiones;
    //     }

    //     // List<Revision> IRevisionesRepository.ObtenerRevisionPorNombre(string nombre){
    //     //     return _context.Revisiones.Where( p => p.persona.Contains(nombre));
    //     // }

    //     // IEnumerable<Revision> IRevisionesRepository.Buscador(string busqueda){
    //     //    return _context.Revisiones.Where(p =>  p.persona.Contains(busqueda));
    //     // }

    //     int IRevisionesRepository.ActualizarRevision(Revision revision){
    //         _context.Revisiones.Update(revision);
    //         return _context.SaveChanges();
    //     }

    //     int IRevisionesRepository.EliminarRevision(Revision revision){
    //         _context.Revisiones.Remove(revision);
    //         return _context.SaveChanges();
    //     }
    }
   
}
