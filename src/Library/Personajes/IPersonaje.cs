using  System.Collections.Generic;
namespace RoleplayGame
{
    public interface IPersonaje  //Usamos interfaces ya que con las clases no podemos realizar herencia múltiple
    {
        string Nombre {get; set;}
        int Vida{get; set;}
        int valorAtaque{get;}
        int valorDefensa{get;}

        void perderVida(IPersonaje atacante);

        void recuperarVida(IPersonaje actual);
    
        int Vp {get; set;}
        public int VP
        {
            get
            {
                return this.Vp;
            }
            set
            {
                this.Vp=value;
            }
        }

        public void sumVp(int vpEnemigo)
        {   
            if(Vp_enemigo>5)
            {
                this.Curar();
            }
            this.VP=VP+Vp_enemigo;
        }






    }
}