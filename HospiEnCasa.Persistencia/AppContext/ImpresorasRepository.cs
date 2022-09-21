using System;
using HospiEnCasa.Dominio;
using System.Linq;
using Microsoft.EntityFrameworkCore; //para pode uar el include
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
            _context.Impresoras.Include(p => p.tipoImpresora).ToList();
            return _context.Impresoras.ToList(); 
        }
        //buscar por nombre
        IEnumerable<Impresora> IImpresorasRepository.FindByName(string name){
            return _context.Impresoras.Where(p => p.nombre.Contains(name) );
        }

        IEnumerable<Impresora> IImpresorasRepository.FindMultipleParameter(string value){
            return _context.Impresoras.Where(p => p.nombre.Contains(value) || 
            p.marca.Contains(value) || p.placa.Contains(value)|| p.velocidad_imp.Contains(value) || 
          p.pais_origen.Contains(value));
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
                 return _context.Impresoras.Where(p => p.nombre.Contains(busqueda) ||
              p.marca.Contains(busqueda) ||  p.placa.Contains(busqueda) ||
              p.velocidad_imp.Contains(busqueda) ||  p.pais_origen.Contains(busqueda) );
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
