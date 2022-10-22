using System;

namespace RoleplayGame
{
    public class Mago : IPersonaje  //Heredamos de la interfaz
    {
        public Mago(string nombre)
        {
            this.Nombre = nombre;
            this.CapaOscura = new CapaOscura();  
            this.BaculoHelado = new BaculoHelado(); 
        }

        //Establecemos las properties
        public string Nombre {get; set;}

        public CapaOscura CapaOscura {get; set;}

        public BaculoHelado BaculoHelado {get; set;}

       
        private int vida = 100; //Establecemos la vida

        public int valorAtaque
        {
            get
            {
                return BaculoHelado.valorAtaque;
            }
        }
         
          public int valorDefensa
        {
            get
            {
                return CapaOscura.valorDefensa;
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
            this.Vida = 100;
        }
    }
}
    
      
