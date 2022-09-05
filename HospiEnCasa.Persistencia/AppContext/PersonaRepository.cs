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
        int IPersonaRepository.AdicionarPersona(Persona persona){
           _context.Impresoras.Add(persona);
           return _context.SaveChanges();
       }       
        //buscar por id
        bool IPersonaRepository.Add(Persona persona){
            _context.Impresoras.Add(persona);
            return (_context.SaveChanges() > 0 ? true : false);            
        }
        //Añadir
        Persona IPersonaRepository.Buscar(int id){
            return _context.Impresoras.Find(id);
        }
        //enumerar
        IEnumerable<Persona> IPersonaRepository.GetAll(){
            return _context.Impresoras;
        }
        //listar
        List<Persona> IPersonaRepository.ObtenerTodo(){
            return _context.Impresoras.ToList();
        }
        //buscar por nombre
        IEnumerable<Persona> IPersonaRepository.FindByName(string name){
            return _context.Impresoras.Where(p => p.nombre.Contains(name) );
        }

        IEnumerable<Persona> IPersonaRepository.FindMultipleParameter(string value){
            return _context.Impresoras.Where(p => p.nombre.Contains(value) ||
              p.apellidos.Contains(value) || p.cedula.Contains(value) || p.telefono.Contains(value)
              || p.fecha_nacimiento.Contains(value) ||  p.password.Contains(value) ||  p.volumen_imp.Contains(value)||
              p.direccion.Contains(value) || p.nivelEstudioId.Contains(value));
        }
        //actualizar
        int IPersonaRepository.Update(Persona persona){
            _context.Impresoras.Update(persona);
            return _context.SaveChanges();
        }
        //eliminar
        int IPersonaRepository.Delete(Persona persona){
            _context.Impresoras.Remove(persona);
            return _context.SaveChanges();
        }

        IEnumerable<Persona> IPersonaRepository.ObtenerTodosPersona(){
            return _context.Impresoras;
        }

        List<Persona> IPersonaRepository.ObtenerPersonaPorNombre(string nombre){
            return _context.Impresoras.Where( p => p.nombre.Contains(nombre) ).ToList();
        }

        IEnumerable<Persona> IPersonaRepository.Buscador(string busqueda){
                    return _context.Impresoras.Where(p => p.nombre.Contains(value) ||
              p.apellidos.Contains(value) || p.cedula.Contains(value) || p.telefono.Contains(value)
              || p.fecha_nacimiento.Contains(value) ||  p.password.Contains(value) ||  p.volumen_imp.Contains(value)||
              p.direccion.Contains(value) || p.nivelEstudioId.Contains(value));
        }

        int IPersonaRepository.ActualizarPersona(Persona persona){
            _context.Impresoras.Update(persona);
            return _context.SaveChanges();
        }

        int IPersonaRepository.EliminarPersona(Persona persona){
            _context.Impresoras.Remove(persona);
            return _context.SaveChanges();
        }
  }
   
}
