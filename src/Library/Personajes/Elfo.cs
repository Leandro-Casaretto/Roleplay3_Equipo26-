using System;

namespace RoleplayGame
{
    public class Elfo : IPersonaje  //Heredamos de la interfaz
    {
        public Elfo(string nombre)
        {
            this.Nombre = nombre;
            this.BotasDeOro = new BotasDeOro();  
            this.ArcoPesado = new ArcoPesado(); //El el Elfo tiene el rol de ser arquero
        }

        //Establecemos las properties
        public string Nombre {get; set;}

        public ArcoPesado ArcoPesado {get; set;}

        public BotasDeOro BotasDeOro {get; set;}

    
        private int vida = 100; //Establecemos la vida

        public int valorAtaque
        {
            get
            {
                return ArcoPesado.valorAtaque;
            }
        }
        
        public int valorDefensa
        {
            get
            {
                return BotasDeOro.valorDefensa;
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
    
    
