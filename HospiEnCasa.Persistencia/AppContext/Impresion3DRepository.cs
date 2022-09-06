using System;
using HospiEnCasa.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace HospiEnCasa.Persistencia
{
    public class Impresion3DRepository : IImpresion3DRepository
    {
      //instancia
        private readonly AppContext _context;

        //constructor
        public Impresion3DRepository(AppContext context)
        {
          _context = context;
        }            
    //     //Guardar
    //     int IImpresion3DRepository.AdicionarImpresiones3D(Impresiones3D impresiones3D){
    //        _context.impresion3D.Add(impresiones3D);
    //        return _context.SaveChanges();
    //     }
    //     //buscar por id
    //     Impresiones3D IImpresion3DRepository.Buscar(int id){
    //        return _context.Impresion3D.Find(id);
    //     }           
    //     //Añadir
    //     bool IImpresion3DRepository.Add(Impresiones3D impresiones3D){
    //         _context.impresion3D.Add(impresiones3D);
    //         return (_context.SaveChanges() > 0 ? true : false);            
    //     }
    //     //enumerar
    //     IEnumerable<Impresiones3D> IImpresion3DRepository.GetAll(){
    //         return _context.impresion3D;
    //     }
    //     //listar
    //     List<Impresiones3D> IImpresion3DRepository.ObtenerTodo(){
    //         return _context.impresion3D.ToList();
    //     }
    //    //buscar por nombre
    //     IEnumerable<Impresiones3D> IImpresion3DRepository.FindByName(string name){
    //         return _context.impresion3D.Where(p => p.cliente.Contains(name) );
    //     }
    //     IEnumerable<Impresiones3D> IImpresion3DRepository.FindMultipleParameter(string value){
    //         return _context.impresion3D.Where(p => p.cliente.Contains(value) 
    //         || p.Tipo_impresion.Contains(value) );
    //     }

    //     int IImpresion3DRepository.Update(Impresiones3D impresiones3D){
    //         _context.impresion3D.Update(impresiones3D);
    //         return _context.SaveChanges();
    //     }

    //     int IImpresion3DRepository.Delete(Impresiones3D impresiones3D){
    //         _context.impresion3D.Remove(impresiones3D);
    //         return _context.SaveChanges();
    //     }

    //     IEnumerable<Impresiones3D> IImpresion3DRepository.ObtenerTodosImpresiones3D(){
    //         return _context.impresion3D;
    //     }

    //     List<Impresiones3D> IImpresion3DRepository.ObtenerImpresiones3DPorNombre(string nombre){
    //         return _context.impresion3D.Where( p => p.cliente.Contains(nombre) ).ToList();
    //     }

    //     IEnumerable<Impresiones3D> IImpresion3DRepository.Buscador(string busqueda){
    //         return _context.impresion3D.Where(p => p.cliente.Contains(busqueda) 
    //         || p.Tipo_impresion.Contains(busqueda));

    //     }

    //     int IImpresion3DRepository.ActualizarImpresiones3D(Impresiones3D impresiones3D){
    //         _context.impresion3D.Update(impresiones3D);
    //         return _context.SaveChanges();
    //     }

    //     int IImpresion3DRepository.EliminarImpresiones3D(Impresiones3D impresiones3D){
    //         _context.impresion3D.Remove(impresiones3D);
    //         return _context.SaveChanges();
    //     }
    }
   
}
