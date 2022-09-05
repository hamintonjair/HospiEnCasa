using System;
using HospiEnCasa.Dominio;
using HospiEnCasa.Persistencia;
using System.Linq;
using System.Collections.Generic;

namespace HospiEnCasa.Persistencia
{
    public class NivelEstudiosRepository : INivelEstudiosRepository
    {
      //instancia
        private readonly AppContext _context;

        //constructor
        public NivelEstudiosRepository(AppContext context)
        {
          _context = context;
        }   
        //Guardar
        int INivelEstudiosRepository.AdicionarNivelEstudio(NivelEstudio nivelEstudio){
           _context.NivelEstudios.Add(nivelEstudio);
           return _context.SaveChanges();
        }
        //buscar
        NivelEstudio INivelEstudiosRepository.Buscar(int id){
           return _context.NivelEstudios.Find(id);
        }           
        //Añadir
        bool INivelEstudiosRepository.Add(NivelEstudio nivelEstudio){
            _context.NivelEstudios.Add(nivelEstudio);
            return (_context.SaveChanges() > 0 ? true : false);            
        }
        //enumerar
        IEnumerable<NivelEstudio> INivelEstudiosRepository.GetAll(){
            return _context.NivelEstudios;
        }
        //listar
        List<NivelEstudio> INivelEstudiosRepository.ObtenerTodo(){
            return _context.NivelEstudios.ToList();
        }

        IEnumerable<NivelEstudio> INivelEstudiosRepository.FindByName(string name){
            return _context.NivelEstudios.Where(p => p.estudio.Contains(name) );
        }
        IEnumerable<NivelEstudio> INivelEstudiosRepository.FindMultipleParameter(string value){
            return _context.NivelEstudios.Where(p => p.estudio.Contains(value));
        }

        int INivelEstudiosRepository.Update(NivelEstudio nivelEstudio){
            _context.NivelEstudios.Update(nivelEstudio);
            return _context.SaveChanges();
        }

        int INivelEstudiosRepository.Delete(NivelEstudio nivelEstudio){
            _context.NivelEstudios.Remove(nivelEstudio);
            return _context.SaveChanges();
        }

        IEnumerable<NivelEstudio> INivelEstudiosRepository.ObtenerTodosNivelEstudio(){
            return _context.NivelEstudios;
        }

        List<NivelEstudio> INivelEstudiosRepository.ObtenerNivelEstudioPorNombre(string nombre){
            return _context.NivelEstudios.Where( p => p.estudio.Contains(nombre) ).ToList();
        }

        IEnumerable<NivelEstudio> INivelEstudiosRepository.Buscador(string busqueda){
            return _context.NivelEstudios.Where( p => p.estudio.Contains(busqueda));
        }

        int INivelEstudiosRepository.ActualizarNivelEstudio(NivelEstudio nivelEstudio){
            _context.NivelEstudios.Update(nivelEstudio);
            return _context.SaveChanges();
        }

        int INivelEstudiosRepository.EliminarNivelEstudio(NivelEstudio nivelEstudio){
            _context.NivelEstudios.Remove(nivelEstudio);
            return _context.SaveChanges();
        }
    }
   
}
