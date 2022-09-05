using System;
using HospiEnCasa.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace HospiEnCasa.Persistencia
{
    public class RolesRepository : IRolesRepository
    {
      //instancia
        private readonly AppContext _context;

        //constructor
        public RolesRepository(AppContext context)
        {
          _context = context;
        }     
       //Guardar
        int IRolesRepository.AdicionarRol(Rol rol){
           _context.Roles.Add(rol);
           return _context.SaveChanges();
       }       
        //buscar por id
        bool IRolesRepository.Add(Rol rol){
            _context.Roles.Add(rol);
            return (_context.SaveChanges() > 0 ? true : false);            
        }
        //Añadir
        Rol IRolesRepository.Buscar(int id){
            return _context.Roles.Find(id);
        }
        //enumerar
        IEnumerable<Rol> IRolesRepository.GetAll(){
            return _context.Roles;
        }
        //listar
        List<Rol> IRolesRepository.ObtenerTodo(){
            return _context.Roles.ToList();
        }
        //buscar por nombre
        IEnumerable<Rol> IRolesRepository.FindByName(string name){
            return _context.Roles.Where(p => p.nombre.Contains(name) );
        }

        IEnumerable<Rol> IRolesRepository.FindMultipleParameter(string value){
            return _context.Roles.Where(p => p.nombre.Contains(value) ||
              p.personaId.Contains(value));
        }
        //actualizar
        int IRolesRepository.Update(Rol rol){
            _context.Roles.Update(rol);
            return _context.SaveChanges();
        }
        //eliminar
        int IRolesRepository.Delete(Rol rol){
            _context.Roles.Remove(rol);
            return _context.SaveChanges();
        }

        IEnumerable<Rol> IRolesRepository.ObtenerTodosRol(){
            return _context.Roles;
        }

        List<Rol> IRolesRepository.ObtenerRolPorNombre(string nombre){
            return _context.Roles.Where( p => p.nombre.Contains(nombre) ).ToList();
        }

        IEnumerable<Rol> IRolesRepository.Buscador(string busqueda){
            return _context.Roles.Where(p => p.nombre.Contains(value) ||
              p.personaId.Contains(value));
        }

        int IRolesRepository.ActualizarRol(Rol rol){
            _context.Roles.Update(rol);
            return _context.SaveChanges();
        }

        int IRolesRepository.EliminarRol(Rol rol){
            _context.Roles.Remove(rol);
            return _context.SaveChanges();
        }
    }
   
}
