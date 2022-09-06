using System;
using HospiEnCasa.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace HospiEnCasa.Persistencia
{
    public class LogginRepository : ILogginRepository
    {
      //instancia
        private readonly AppContext _context;

        //constructor
        public LogginRepository(AppContext context)
        {
          _context = context;
        }      
        //Guardar
    //     int ILogginRepository.AdicionarLogin(Login login){
    //        _context.Loggin.Add(login);
    //        return _context.SaveChanges();
    //    }       
    //     //buscar por id
    //     bool ILogginRepository.Add(Login login){
    //         _context.Loggin.Add(login);
    //         return (_context.SaveChanges() > 0 ? true : false);            
    //     }
    //     //Añadir
    //     Login ILogginRepository.Buscar(int id){
    //         return _context.Loggin.Find(id);
    //     }
    //     //enumerar
    //     IEnumerable<Login> ILogginRepository.GetAll(){
    //         return _context.Loggin;
    //     }
    //     //listar
    //     List<Login> ILogginRepository.ObtenerTodo(){
    //         return _context.Loggin.ToList();
    //     }
    //     //buscar por nombre
    //     IEnumerable<Login> ILogginRepository.FindByName(string name){
    //         return _context.Loggin.Where(p => p.rol.Contains(name) );
    //     }

    //     IEnumerable<Login> ILogginRepository.FindMultipleParameter(string value){
    //         return _context.Loggin.Where(p => p.tipo_Rol.Contains(value));
    //     }
    //     //actualizar
    //     int ILogginRepository.Update(Login login){
    //         _context.Loggin.Update(login);
    //         return _context.SaveChanges();
    //     }
    //     //eliminar
    //     int ILogginRepository.Delete(Login login){
    //         _context.Loggin.Remove(login);
    //         return _context.SaveChanges();
    //     }

    //     IEnumerable<Login> ILogginRepository.ObtenerTodosLogin(){
    //         return _context.Loggin;
    //     }

    //     List<Login> ILogginRepository.ObtenerLoginPorNombre(string nombre){
    //         return _context.Loggin.Where( p => p.tipo_Rol.Contains(nombre)).ToList();
    //     }

    //     IEnumerable<Login> ILogginRepository.Buscador(string busqueda){
    //        return _context.Loggin.Where(p => p.tipo_Rol.Contains(busqueda) );
    //     }

    //     int ILogginRepository.ActualizarLogin(Login login){
    //         _context.Loggin.Update(login);
    //         return _context.SaveChanges();
    //     }

    //     int ILogginRepository.EliminarLogin(Login login){
    //         _context.Loggin.Remove(login);
    //         return _context.SaveChanges();
    //     }
       
    }
   
}
