using System;

namespace Library
{
    public class Elfo
    { 
    
        public string Nombre {get; set;}
        public int Vida = 110;
        public int Ataque {get; set;} = 25;
        public int habilidadMagica = 40; /// hechizo que devuelve 20 de vida a integrantes del equipo
        
        public Elfo (string nombre, int vida, int ataque, int defensa)
        {
          this.Nombre = nombre;
          this.Vida = vida;
          this.Ataque = ataque;
          this.habilidadMagica = defensa;
        }
    }
}
