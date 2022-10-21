namespace Library
{
    public class LibroDeEchizos
    {
        public int Daño {get; set;} = 0;
        public int Defensa {get; set;} = 0;

        public void NuevoEchizo(Echizo echizo)
        {
            this.Ataque += hechizo.Ataque;
            this.Defensa += hechizo.Defensa;
        }
