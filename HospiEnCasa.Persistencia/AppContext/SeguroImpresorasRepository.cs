using System;
using HospiEnCasa.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace HospiEnCasa.Persistencia
{
    public class SeguroImpresorasRepository : ISeguroImpresorasRepository
    {
      //instancia
        private readonly AppContext _context;

        //constructor
        public SeguroImpresorasRepository(AppContext context)
        {
          _context = context;
        }       
       //Guardar
    //     int ISeguroImpresorasRepository.AdicionarSeguroImpresora(SeguroImpresora seguroImpresora){
    //        _context.SeguroImpresoras.Add(seguroImpresora);
    //        return _context.SaveChanges();
    //    }       
    //     //buscar por id
    //     bool ISeguroImpresorasRepository.Add(SeguroImpresora seguroImpresora){
    //         _context.SeguroImpresoras.Add(seguroImpresora);
    //         return (_context.SaveChanges() > 0 ? true : false);            
    //     }
    //     //Añadir
    //     SeguroImpresora ISeguroImpresorasRepository.Buscar(int id){
    //         return _context.SeguroImpresoras.Find(id);
    //     }
    //     //enumerar
    //     IEnumerable<SeguroImpresora> ISeguroImpresorasRepository.GetAll(){
    //         return _context.SeguroImpresoras;
    //     }
    //     //listar
    //     List<SeguroImpresora> ISeguroImpresorasRepository.ObtenerTodo(){
    //         return _context.SeguroImpresoras.ToList();
    //     }
    //     //buscar por nombre
    //     // IEnumerable<SeguroImpresora> ISeguroImpresorasRepository.FindByName(string name){
    //     //     return _context.SeguroImpresoras.Where(p => p.tipo_seguro.Contains(name));
    //     // }

    //     // IEnumerable<SeguroImpresora> ISeguroImpresorasRepository.FindMultipleParameter(string value){
    //     //     return _context.SeguroImpresoras.Where(p => p.tipo_seguro.Contains(value));
    //     // }
    //     //actualizar
    //     int ISeguroImpresorasRepository.Update(SeguroImpresora seguroImpresora){
    //         _context.SeguroImpresoras.Update(seguroImpresora);
    //         return _context.SaveChanges();
    //     }
    //     //eliminar
    //     int ISeguroImpresorasRepository.Delete(SeguroImpresora seguroImpresora){
    //         _context.SeguroImpresoras.Remove(seguroImpresora);
    //         return _context.SaveChanges();
    //     }

    //     IEnumerable<SeguroImpresora> ISeguroImpresorasRepository.ObtenerTodosSeguroImpresora(){
    //         return _context.SeguroImpresoras;
    //     }

    //     List<SeguroImpresora> ISeguroImpresorasRepository.ObtenerSeguroImpresoraPorNombre(string nombre){
    //         return _context.SeguroImpresoras.Where( p => p.tipo_seguro.Contains(nombre) ).ToList();
    //     }

    //     IEnumerable<SeguroImpresora> ISeguroImpresorasRepository.Buscador(string busqueda){
    //          return _context.SeguroImpresoras.Where(p => p.tipo_seguro.Contains(busqueda));
    //     }

    //     int ISeguroImpresorasRepository.ActualizarSeguroImpresora(SeguroImpresora seguroImpresora){
    //         _context.SeguroImpresoras.Update(seguroImpresora);
    //         return _context.SaveChanges();
    //     }

    //     int ISeguroImpresorasRepository.EliminarSeguroImpresora(SeguroImpresora seguroImpresora){
    //         _context.SeguroImpresoras.Remove(seguroImpresora);
    //         return _context.SaveChanges();
    //     }
    }
   
}
