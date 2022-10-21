using System;
namespace Library 
{

    public class Mago
    {
        public string Nombre { get; set; }
        
        public int Vida = 90;
        
        public int Ataque { get; set; } = 45;
        
        public int Defensa = 28;
        
        
         public Mago (string Nombre, int ataque, int vida, int defensa) 
        {
        
            this.Nombre = Nombre;
            this.Vida = vida;
            this.Ataque = ataque;
            this.Defensa = defensa;
       
        }
