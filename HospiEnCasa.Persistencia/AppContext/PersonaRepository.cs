using System;
using HospiEnCasa.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace HospiEnCasa.Persistencia
{
  public class PersonaRepository : IPersonaRepository
  {
    //instancia
    private readonly AppContext _context;

        //constructor
      public PersonaRepository(AppContext context)
      {
          _context = context;
      }   
   
      //Guardar
    //     int IPersonaRepository.AdicionarPersona(Persona persona){
    //        _context.Personas.Add(persona);
    //        return _context.SaveChanges();
    //    }       
    //     //buscar por id
    //     bool IPersonaRepository.Add(Persona persona){
    //         _context.Personas.Add(persona);
    //         return (_context.SaveChanges() > 0 ? true : false);            
    //     }
    //     //Añadir
    //     Persona IPersonaRepository.Buscar(int id){
    //         return _context.Personas.Find(id);
    //     }
    //     //enumerar
    //     IEnumerable<Persona> IPersonaRepository.GetAll(){
    //         return _context.Personas;
    //     }
    //     //listar
    //     List<Persona> IPersonaRepository.ObtenerTodo(){
    //         return _context.Personas.ToList();
    //     }
    //     //buscar por nombre
    //     IEnumerable<Persona> IPersonaRepository.FindByName(string name){
    //         return _context.Personas.Where(p => p.nombre.Contains(name) );
    //     }

    //     IEnumerable<Persona> IPersonaRepository.FindMultipleParameter(string value){
    //         return _context.Personas.Where(p => p.nombre.Contains(value) ||
    //           p.apellidos.Contains(value) || p.cedula.Contains(value));
    //     }
    //     //actualizar
    //     int IPersonaRepository.Update(Persona persona){
    //         _context.Personas.Update(persona);
    //         return _context.SaveChanges();
    //     }
    //     //eliminar
    //     int IPersonaRepository.Delete(Persona persona){
    //         _context.Personas.Remove(persona);
    //         return _context.SaveChanges();
    //     }

    //     IEnumerable<Persona> IPersonaRepository.ObtenerTodosPersona(){
    //         return _context.Personas;
    //     }

    //     List<Persona> IPersonaRepository.ObtenerPersonaPorNombre(string nombre){
    //         return _context.Personas.Where( p => p.nombre.Contains(nombre) ).ToList();
    //     }

    //     IEnumerable<Persona> IPersonaRepository.Buscador(string busqueda){
    //          return _context.Personas.Where(p => p.nombre.Contains(busqueda) ||
    //           p.apellidos.Contains(busqueda) || p.cedula.Contains(busqueda) || p.telefono.Contains(busqueda)
    //           ||  p.direccion.Contains(busqueda));
    //     }

    //     int IPersonaRepository.ActualizarPersona(Persona persona){
    //         _context.Personas.Update(persona);
    //         return _context.SaveChanges();
    //     }

    //     int IPersonaRepository.EliminarPersona(Persona persona){
    //         _context.Personas.Remove(persona);
    //         return _context.SaveChanges();
    //     }
  }
   
}
