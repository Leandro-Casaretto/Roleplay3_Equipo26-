using System.Collections.Generic;

namespace RoleplayGame
{
    public class LibroDeHechizos: IObjeto
    {
        private List<IHechizo> hechizos = new List<IHechizo>();
        
        public int valorAtaque
        {
            get
            {
                int value = 0;
                foreach (IHechizo hechizo in this.hechizos)
                {
                    value += hechizo.valorAtaque;
                }
                return value;
            }
        }

        public int valorDefensa
        {
            get
            {
                int value = 0;

                foreach (IHechizo hechizo in this.hechizos)
                {
                    value += hechizo.valorDefensa;
                }
                return value;
            }
        }

        public void agregarHechizo(IHechizo hechizo)
        {
            this.hechizos.Add(hechizo);
        }

        public void quitarHechizo(IHechizo hechizo)
        {
            this.hechizos.Remove(hechizo);
        }
    }
}