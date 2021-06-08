using System;
using EFCoreTutorial.DAL;
using EFCoreTutorial.Models;
namespace EFCoreTutorial
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var context = new Contexto())
            {

                var std = new Libro()
                {
                    LibroId = 1,
                    Autor = "Jose Jose",
                    Titulo = "Lo que el viento trajo",
                    Editorial = "Carlito Editorial",
                    Precio = 5000.50
                };

                context.Libros.Add(std);
                context.SaveChanges();
                
                std = context.Libros.Find(1);
                Console.WriteLine(std.LibroId);
                Console.WriteLine(std.Autor);
                Console.WriteLine(std.Titulo);
                Console.WriteLine(std.Editorial);
                Console.WriteLine(std.Precio);
                
            }
            
            Console.WriteLine("Hello World!");
        }
    }
}
