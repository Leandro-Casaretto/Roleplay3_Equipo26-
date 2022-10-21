using System;


namespace Library
{
    public class Enano
    {
        public string Nombre { get; set; }
        
        public int Vida = 130;
        
        public int Ataque { get; set; } = 15;
        
        public int Defensa = 40;
        
        
         public Enano (string nombre, int vida, int ataque, int defensa) 
        {
            this.Nombre = nombre;
            this.Vida = vida;
            this.Ataque = ataque;
            this.Defensa = defensa;
            
        }
        
        
        
      
