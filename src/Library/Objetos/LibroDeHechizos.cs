using System.Collections.Generic;

namespace RoleplayGame
{
    public class LibroDeHechizos: IObjeto
    {
        public Hechizo[] Hechizos {get; set;}
        
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
                return 50;  
            }
        }
    }
}