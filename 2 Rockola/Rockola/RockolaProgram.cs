using Rockola;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectosHugoP
{
    class Rockola
    {
        static char DesicionDinero = 's';
        static void Rocko(string NombreCancion,string Artista, string Album)
        {
            bool ckola;


            Canciones cancion = new Canciones(NombreCancion,Artista,Album, 3.5M);
            cancion.Reproducir();

            Canciones cancion0 = new Canciones("Evil", "Interpol", "Turn On The Brights Lights", 3.5M);
            cancion0.Repertorio();

            Canciones cancion1 = new Canciones("Beat It", "Michael Jackson", "Thriller", 4.9M);
            cancion1.Repertorio();
            cancion.Repertorio();

            Console.WriteLine("\n¿Desea buscar otra canción?\nS/N");
            DesicionDinero = Console.ReadKey().KeyChar;

            if (DesicionDinero == 's')
            {

                Console.WriteLine("\nEscribre el nombre de la cancion: ");
                NombreCancion = Console.ReadLine();
                Console.WriteLine("Escribe el nombre del artista: ");
                Artista = Console.ReadLine();
                Console.WriteLine("Escribe el nombre del album: ");
                Album = Console.ReadLine();
                Console.WriteLine("\nBuscando...\n");


                Rocko(NombreCancion, Artista, Album);
            }
        }
       static void Main(string[] args)
        {
            string NombreCancion, Artista, Album;
            int DesicionRepertorio;
            //decimal Duracion;

            Console.WriteLine("¡Bienvenido a la Rockola!\nIngresa $20.00\nS/N");
            DesicionDinero = Console.ReadKey().KeyChar;

            if (DesicionDinero == 's')
            {
                Canciones cancion0 = new Canciones("Evil", "Interpol", "Turn On The Brights Lights",3.5M);
                Console.Write("\n1");
                cancion0.Repertorio();

                Canciones cancion1 = new Canciones("Beat It", "Michael Jackson", "Thriller", 4.9M);
                Console.Write("\n2");
                cancion1.Repertorio();

                Console.WriteLine("\n3.\nBuscar nueva.");

                Console.WriteLine("\nSelecciona una opcion.");
                DesicionRepertorio = Convert.ToInt32(Console.ReadLine());
                if (DesicionRepertorio == 3)
                {

                Console.WriteLine("\nBusca una nueva cancion\nEscribre el nombre de la cancion: ");
                NombreCancion = Console.ReadLine();
                Console.WriteLine("Escribe el nombre del artista: ");
                Artista = Console.ReadLine();
                Console.WriteLine("Escribe el nombre del album: ");
                Album = Console.ReadLine();
                Console.WriteLine("\nBuscando...\n");

                Rocko(NombreCancion, Artista, Album);
                Console.ReadKey();
                }if(DesicionRepertorio == 1)
                {
                    cancion0.Reproducir();
                    Console.WriteLine("\nBusca una nueva cancion\nEscribre el nombre de la cancion: ");
                    NombreCancion = Console.ReadLine();
                    Console.WriteLine("Escribe el nombre del artista: ");
                    Artista = Console.ReadLine();
                    Console.WriteLine("Escribe el nombre del album: ");
                    Album = Console.ReadLine();
                    Console.WriteLine("\nBuscando...\n");

                    Rocko(NombreCancion, Artista, Album);
                    Console.ReadKey();

                }
                cancion1.Reproducir();
                Console.WriteLine("\nBusca una nueva cancion\nEscribre el nombre de la cancion: ");
                NombreCancion = Console.ReadLine();
                Console.WriteLine("Escribe el nombre del artista: ");
                Artista = Console.ReadLine();
                Console.WriteLine("Escribe el nombre del album: ");
                Album = Console.ReadLine();
                Console.WriteLine("\nBuscando...\n");

                Rocko(NombreCancion, Artista, Album);
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("\nDebes ingresar dinero.");
            }
        }
    }
}