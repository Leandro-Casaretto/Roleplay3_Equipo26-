using  System.Collections.Generic;
namespace RoleplayGame
{
    public interface IEnemigo  //Usamos interfaces ya que con las clases no podemos realizar herencia múltiple
    {
        string Nombre {get; set;}
        int Vida{get; set;}
        int valorAtaque{get;}
        int valorDefensa{get;}

        void perderVida(IEnemigo atacante);

        void recuperarVida(IEnemigo actual);
    
        int Vp {get; set;} 
        public int VP
        {
            get
            {
                return this.Vp;
            }
            set
            {
                this.Vp = value;
            }
        }






    }
}