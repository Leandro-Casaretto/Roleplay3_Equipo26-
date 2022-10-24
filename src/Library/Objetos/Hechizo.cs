
namespace RoleplayGame
{
    public class Hechizo: IObjeto  //A partir de esta clase es que vamos a poder crear distintos hechizos
    {
        public int valorAtaque
        {
            get
            {
                return 50;
            }
        }
        public int valorDefensa
        {
            get
            {
                return 30;
            }
        }
    }
}