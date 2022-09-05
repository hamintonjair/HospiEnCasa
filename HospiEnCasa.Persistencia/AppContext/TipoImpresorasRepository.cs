using System;
using HospiEnCasa.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace HospiEnCasa.Persistencia
{
    public class TipoImpresorasRepository : ITipoImpresorasRepository
    {
      //instancia 
        private readonly AppContext _context;

        //constructor
        public TipoImpresorasRepository(AppContext context)
        {
          _context = context;
        }   
       //Guardar
        int ITipoImpresorasRepository.AdicionarTipoImpresora(TipoImpresora tipoImpresora){
           _context.TipoImpresoras.Add(tipoImpresora);
           return _context.SaveChanges();
       }       
        //buscar por id
        bool ITipoImpresorasRepository.Add(TipoImpresora tipoImpresora){
            _context.TipoImpresoras.Add(tipoImpresora);
            return (_context.SaveChanges() > 0 ? true : false);            
        }
        //Añadir
        TipoImpresora ITipoImpresorasRepository.Buscar(int id){
            return _context.TipoImpresoras.Find(id);
        }
        //enumerar
        IEnumerable<TipoImpresora> ITipoImpresorasRepository.GetAll(){
            return _context.TipoImpresoras;
        }
        //listar
        List<TipoImpresora> ITipoImpresorasRepository.ObtenerTodo(){
            return _context.TipoImpresoras.ToList();
        }
        //buscar por nombre
        IEnumerable<TipoImpresora> ITipoImpresorasRepository.FindByName(string name){
            return _context.TipoImpresoras.Where(p => p.nombre_impresora.Contains(name) );
        }

        IEnumerable<TipoImpresora> ITipoImpresorasRepository.FindMultipleParameter(string value){
            return _context.TipoImpresoras.Where(p => p.nombre_impresora.Contains(value));
        }
        //actualizar
        int ITipoImpresorasRepository.Update(TipoImpresora tipoImpresora){
            _context.TipoImpresoras.Update(tipoImpresora);
            return _context.SaveChanges();
        }
        //eliminar
        int ITipoImpresorasRepository.Delete(TipoImpresora tipoImpresora){
            _context.TipoImpresoras.Remove(tipoImpresora);
            return _context.SaveChanges();
        }

        IEnumerable<TipoImpresora> ITipoImpresorasRepository.ObtenerTodosTipoImpresora(){
            return _context.TipoImpresoras;
        }

        List<TipoImpresora> ITipoImpresorasRepository.ObtenerTipoImpresoraPorNombre(string nombre){
            return _context.TipoImpresoras.Where( p => p.nombre.Contains(nombre) ).ToList();
        }

        IEnumerable<TipoImpresora> ITipoImpresorasRepository.Buscador(string busqueda){
               return _context.TipoImpresoras.Where(p => p.nombre_impresora.Contains(value));
        }

        int ITipoImpresorasRepository.ActualizarTipoImpresora(TipoImpresora tipoImpresora){
            _context.TipoImpresoras.Update(tipoImpresora);
            return _context.SaveChanges();
        }

        int ITipoImpresorasRepository.EliminarTipoImpresora(TipoImpresora tipoImpresora){
            _context.TipoImpresoras.Remove(tipoImpresora);
            return _context.SaveChanges();
        }
    }
   
}
