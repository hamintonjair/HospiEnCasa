using System;
using HospiEnCasa.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace HospiEnCasa.Persistencia
{
    public class ImpresorasRepository : IImpresorasRepository
    {
      //instancia
        private readonly AppContext _context;

        //constructor
        public ImpresorasRepository(AppContext context)
        {
          _context = context;
        }     
         //Guardar
        int IImpresorasRepository.AdicionarImpresora(Impresora impresora){
           _context.Impresoras.Add(impresora);
           return _context.SaveChanges();
       }       
        //buscar por id
        bool IImpresorasRepository.Add(Impresora impresora){
            _context.Impresoras.Add(impresora);
            return (_context.SaveChanges() > 0 ? true : false);            
        }
        //Añadir
        Impresora IImpresorasRepository.Buscar(int id){
            return _context.Impresoras.Find(id);
        }
        //enumerar
        IEnumerable<Impresora> IImpresorasRepository.GetAll(){
            return _context.Impresoras;
        }
        //listar
        List<Impresora> IImpresorasRepository.ObtenerTodo(){
            return _context.Impresoras.ToList();
        }
        //buscar por nombre
        IEnumerable<Impresora> IImpresorasRepository.FindByName(string name){
            return _context.Impresoras.Where(p => p.nombre.Contains(name) );
        }

        IEnumerable<Impresora> IImpresorasRepository.FindMultipleParameter(string value){
            return _context.Impresoras.Where(p => p.nombre.Contains(value) ||
              p.marca.Contains(value) || p.placa.Contains(value) || p.TipoImpresoraId.Contains(value)
              || p.ano_modelo.Contains(value) ||  p.velocidad_imp.Contains(value) ||  p.volumen_imp.Contains(value)||
              p.pais_origen.Contains(value) || p.fecha_mantenimiento.Contains(value) || p.detalles.Contains(value)||
              p.otros_caracteristicas.Contains(value) ||  p.seguro.Contains(value));
        }
        //actualizar
        int IImpresorasRepository.Update(Impresora impresora){
            _context.Impresoras.Update(impresora);
            return _context.SaveChanges();
        }
        //eliminar
        int IImpresorasRepository.Delete(Impresora impresora){
            _context.Impresoras.Remove(impresora);
            return _context.SaveChanges();
        }

        IEnumerable<Impresora> IImpresorasRepository.ObtenerTodosImpresora(){
            return _context.Impresoras;
        }

        List<Impresora> IImpresorasRepository.ObtenerImpresoraPorNombre(string nombre){
            return _context.Impresoras.Where( p => p.nombre.Contains(nombre) ).ToList();
        }

        IEnumerable<Impresora> IImpresorasRepository.Buscador(string busqueda){
                    return _context.Impresoras.Where(p => p.nombre.Contains(value) ||
              p.marca.Contains(value) ||  p.placa.Contains(value)  p.TipoImpresoraId.Contains(value)
              ||p.ano_modelo.Contains(value) || p.velocidad_imp.Contains(value) ||  p.volumen_imp.Contains(value)||
              p.pais_origen.Contains(value) || p.fecha_mantenimiento.Contains(value) || p.detalles.Contains(value)||
              p.otros_caracteristicas.Contains(value) || p.seguro.Contains(value));
        }

        int IImpresorasRepository.ActualizarImpresora(Impresora impresora){
            _context.Impresoras.Update(impresora);
            return _context.SaveChanges();
        }

        int IImpresorasRepository.EliminarImpresora(Impresora impresora){
            _context.Impresoras.Remove(impresora);
            return _context.SaveChanges();
        }
       
    }
   
}
