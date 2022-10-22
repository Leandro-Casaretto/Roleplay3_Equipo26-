using System;

namespace RoleplayGame
{
    public class Enano : IPersonaje  //Heredamos de la interfaz
    {
        public Enano(string nombre)
        {
            this.Nombre = nombre;  
            this.Armadura = new Armadura();  //Con estos items le agregamos mucha resistencia
            this.Martillo = new Martillo();
        }

        //Establecemos las properties
        public string Nombre {get; set;}

        public Armadura Armadura {get; set;}

        public Martillo Martillo {get; set;}

        private int vida = 200; //Establecemos la vida

        public int valorDefensa
        {
            get
            {
                return Armadura.valorDefensa;
            }
        }
          public int valorAtaque
        {
            get
            {
                return Martillo.valorAtaque;
            }
        }

        public int Vida
        {
            get
            {
                return this.vida;
            }
            set  //Ponemos este set vacío ya que de lo contrario no podríamos cambiar la vida después
            {
                
            }
        }

        public void perderVida(IPersonaje atacante)
        {
            if (atacante.valorAtaque > this.valorDefensa)
            {
                this.Vida -= (atacante.valorAtaque - this.valorDefensa);
            }
        }

        public void recuperarVida(IPersonaje actual)
        {
            this.Vida = 200;
        }
    }
}
    
      
