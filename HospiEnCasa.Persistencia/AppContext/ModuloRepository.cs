using System;
using HospiEnCasa.Dominio;
using HospiEnCasa.Persistencia;
using System.Linq;
using Microsoft.EntityFrameworkCore; //para pode uar el include
using System.Collections.Generic;

namespace HospiEnCasa.Persistencia
{
    public class ModuloRepository : IModuloRepository
    {
      //instancia
        private readonly AppContext _context;

        //constructor
        public ModuloRepository(AppContext context)
        {
          _context = context;
        }   
        //Guardar
        int IModuloRepository.AdicionarModulo(Modulo modulos){
           _context.Modulos.Add(modulos);
           return _context.SaveChanges();
       }       
        //buscar por id
        bool IModuloRepository.Add(Modulo modulos){
            _context.Modulos.Add(modulos);
            return (_context.SaveChanges() > 0 ? true : false);            
        }
        //buscar por id
        Modulo IModuloRepository.Buscar(int id){
            return _context.Modulos.Find(id);
        }
        //enumerar
        IEnumerable<Modulo> IModuloRepository.GetAll(){
            return _context.Modulos;
        }
        //listar
        List<Modulo> IModuloRepository.ObtenerTodo(){           
            return _context.Modulos.Include(p => p.rol).ToList();
        }
        //buscar por nombre
        // IEnumerable<Modulo> IModuloRepository.FindByName(string name){
        //     return _context.Modulos.Where(p => p.modulos.Contains(name) );
        // }

        // IEnumerable<Modulo> IModuloRepository.FindMultipleParameter(string value){
        //     return _context.Modulos.Where(p => p.modulos.Contains(value));
        // }
        //actualizar
        int IModuloRepository.Update(Modulo modulos){
            _context.Modulos.Update(modulos);
            return _context.SaveChanges();
        }
        //eliminar
        int IModuloRepository.Delete(Modulo modulos){
            _context.Modulos.Remove(modulos);
            return _context.SaveChanges();
        }

        IEnumerable<Modulo> IModuloRepository.ObtenerTodosModulo(){
            return _context.Modulos;
        }

        // List<Modulo> IModuloRepository.ObtenerModuloPorNombre(string nombre){
        //     return _context.Modulos.Where( p => p.modulos.Contains(nombre) ).ToList();
        // }

        // IEnumerable<Modulo> IModuloRepository.Buscador(string busqueda){
        //     return _context.Modulos.Where(p => p.modulos.Contains(busqueda));
        // }

        int IModuloRepository.ActualizarModulo(Modulo modulos){
            _context.Modulos.Update(modulos);
            return _context.SaveChanges();
        }

        int IModuloRepository.EliminarModulo(Modulo modulos){
            _context.Modulos.Remove(modulos);
            return _context.SaveChanges();
        }
       
     }  
}
