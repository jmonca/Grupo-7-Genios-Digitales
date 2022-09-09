using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;

namespace MascotaFeliz.App.consola
{

    class Program
    {

        private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());
        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
           //ListarDuenos();
           //AddDueno();
           //BuscarDueno(2);


           //AddVeterinario();
          

           //AddMascota();
           //ListarMascotas();
           //BuscarMascota(1);
           

           
           
        }
        private static void AddDueno()
        {
            var dueno = new Dueno
            {
                //Cedula = "1212",
                Nombres = "Juan",
                Apellidos = "Sin Miedo",
                Direccion = "Bajo un puente",
                Telefono = "1234567891",
                Correo = "juansinmiedo@gmail.com"
            };
            _repoDueno.AddDueno(dueno);
        }
        private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {

                Nombres = "Carlos",
                Apellidos = "El propio",
                Direccion = "SantaMarta",
                Telefono = "1234567891",                              
                TarjetaProfesional = "555555555",

            };
            _repoVeterinario.AddVeterinario(veterinario);
        }
        private static void AddMascota()
        {
            var mascota = new Mascota
            {

                Nombre = "Danger",
                Color = "Blanco",
                Raza = "criollo",
                Especie = "7337891",                              
                
            };
            _repoMascota.AddMascota(mascota);
        }
        private static void ListarDuenos()
        {
            var duenos = _repoDueno.GetAllDuenos();
            foreach (Dueno d in duenos)
            {
               Console.WriteLine(d.Nombres + " " + d.Apellidos);  
            }
        }                                                 
        private static void ListarMascotas()
        {
            var mascotas = _repoMascota.GetAllMascotas();
            foreach (Mascota d in mascotas)
            {
               Console.WriteLine(d.Nombre + " " + d.Color + " " + d.Raza);  
            }
        }               
        private static void BuscarMascota(int idMascota)

        {   
            var mascota = _repoMascota.GetMascota(idMascota);
            Console.WriteLine(mascota.Nombre + " " + mascota.Color + " " + mascota.Raza);
                    
                 
        }
                          
    }
}
