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
                int valorLibro = 0;
                foreach (Hechizo hechizo in this.Hechizos)
                {
                    valorLibro += hechizo.valorAtaque;  //En este bucle le asignamos el valor de los hechizos que esten en en libro.
                }
                return valorLibro;          
            
            } 
        }

        public int valorDefensa
        {
            get
            {
                int valorLibro = 0;
                foreach (Hechizo hechizo in this.Hechizos)
                {
                    valorLibro += hechizo.valorDefensa;  
                }
                return valorLibro;
        
            }

        }
    }
}