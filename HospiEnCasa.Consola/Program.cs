using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospiEnCasa.Dominio;
using HospiEnCasa.Persistencia;


namespace HospiEnCasa.Consola
{
    class Program
    {
        //instancia del repositorio
        private static Persistencia.INivelEstudiosRepository nivelEstudiosRepository = new NivelEstudiosRepository( new HospiEnCasa.Persistencia.AppContext());
        
        public static void Main(string[] args)
        {
             
           // addNivelStudio();     
            //  FindAll(); 
            FindByName();
            //    Find();            
            // Update();
            // Delete();                 
            // ObtenerTodosNivelEstudio();
            // BuscarPorNombre();
            // Buscador();
            //  Buscar();
            //ActualizarNivelEstudio();
            //EliminarNivelEstudio();

           
        }
   
        public static void addNivelStudio(){
            
            Console.WriteLine("Registrando Nivel de estudio...");

           var nivelEstudio = new NivelEstudio{
                estudio = "Ingeniero"
      
            };
           try
            {
                var  result = nivelEstudiosRepository.AdicionarNivelEstudio(nivelEstudio);

                    if(result > 0){
                        Console.WriteLine("Profesión insertado con exito..");
                    }else{
                        Console.WriteLine("Error" , "No se pudo insertar la profesión.");
                    }
            }catch (System.Exception e){
                Console.WriteLine("Ocurrio un error: " + e );
                throw;
            }       
        }
       

        public static void FindAll(){
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Listado de Nivel de estudio");
            Console.WriteLine("-----------------------------------------------");
            
            var resultGeneral = nivelEstudiosRepository.GetAll();

            foreach (var resultNivelEstudio in resultGeneral)
            {
                Console.WriteLine("Id: " + resultNivelEstudio.id +", Nivel estudio: " + resultNivelEstudio.estudio);
            }
        }

        public static void FindByName(){

            var result = nivelEstudiosRepository.FindByName("profesional");

            foreach (var Estudio in result)
            {
                Console.WriteLine("Id: " + Estudio.id +", Profesión: " + Estudio.estudio );
            }
        }

        //por id
        public static void Find(){

            var result = nivelEstudiosRepository.Buscar(1);
            Console.WriteLine( result.estudio );
        }

        public static void Update(){

            var result = nivelEstudiosRepository.Buscar(5);

            if( result != null){

                result.estudio = "primaria";              

                var res = nivelEstudiosRepository.Update(result);

                if(res > 0){
                    Console.WriteLine("Se actualizo con exito");
                }else{
                    Console.WriteLine("No fue posible actualizar");
                }
            }else{
                Console.WriteLine("No existe persona a actualizar");
            }

        }

        public static void Delete(){

            var result = nivelEstudiosRepository.Buscar(5);

            if( result != null){

                var res = nivelEstudiosRepository.Delete(result);

                if(res > 0){
                    Console.WriteLine("Se elimino con exito");
                }else{
                    Console.WriteLine("No fue posible eliminar");
                }
            }else{
                Console.WriteLine("No existe persona a eliminar");
            }

        }       


        public static void ObtenerTodosNivelEstudio(){

            var listadoNivelEstudios = nivelEstudiosRepository.ObtenerTodosNivelEstudio();

            foreach (var Estudio in listadoNivelEstudios)
            {
                Console.WriteLine("Id: " + Estudio.id + ", Nivel estudio: " + Estudio.estudio);
            }

        }

        public static void BuscarPorNombre(){
             
             var listadoNivelEstudios = nivelEstudiosRepository.ObtenerNivelEstudioPorNombre( "profesional" );

             foreach (var Estudio in listadoNivelEstudios)
             {
                Console.WriteLine("Id: " + Estudio.id + ", Nivel estudio: " + Estudio.estudio );
             }

        }

        public static void Buscador(){
             
             var listadoNivelEstudios = nivelEstudiosRepository.Buscador( "12" );

             foreach (var Estudio in listadoNivelEstudios)
             {
                Console.WriteLine("Id: " + Estudio.id + ", Nivel estudio: " + Estudio.estudio );
             }

        }

        public static void ActualizarNivelEstudio(){

            var Estudio = nivelEstudiosRepository.Buscar(3);

            if( Estudio != null){

                Estudio.estudio = " Ingeniero de sistemas";          
               
                var result = nivelEstudiosRepository.ActualizarNivelEstudio(Estudio);

                if( result > 0 )
                    Console.WriteLine("Se actualizo con exito, se afectaron " + result + " registros.");
                else
                    Console.WriteLine("No se logro actualizar");

            }else{
                Console.WriteLine("No existe la persona a actualizar");
            }
        }

        public static void EliminarNivelEstudio(){

            var Estudio = nivelEstudiosRepository.Buscar(3);

            if( Estudio != null){

                var result = nivelEstudiosRepository.EliminarNivelEstudio(Estudio);

                if( result > 0 )
                    Console.WriteLine("Se elimino con exito, se afectaron " + result + " registros.");
                else
                    Console.WriteLine("No se logro eliminar");

            }else{
                Console.WriteLine("No existe la persona a eliminar");
            }
        }

        // public static void Find(){

          
        // }
    }
}
