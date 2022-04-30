using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rockola
{
    public class Canciones
    {
        public string Nombre { get; set; }
        public string Artista { get; set; }
        public string Album { get; set; }
        public decimal duracion { get; set; }
        public Canciones(string Nombre, string Artista, string Album, decimal duracion)
        {
            this.Nombre = Nombre;
            this.Artista = Artista;
            this.Album = Album;
            this.duracion = duracion;
        }
        public void Reproducir()
        {
            Console.WriteLine("Se esta reproduciendo la canción {0} de {1} del album {2} con duracion de {3} minutos.", Nombre,Artista, Album, duracion);
        }
        public void Repertorio()
        {
            Console.WriteLine("\nRepertorio:\nCanción: {0} de {1} del album {2} con duracion de {3} minutos.", Nombre, Artista, Album, duracion);
        }
    }
}
