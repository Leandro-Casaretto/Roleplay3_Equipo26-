using  System.Collections.Generic;
namespace RoleplayGame
{
    public interface IPersonaje  //COMENTARIO
    {
        string Nombre {get; set;}
        int Vida{get; set;}
        int valorAtaque{get;}
        int valorDefensa{get;}

        void perderVida(IPersonaje atacante);

        void recuperarVida(IPersonaje actual);
    }
}