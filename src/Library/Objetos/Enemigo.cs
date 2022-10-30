namespace RoleplayGame
{
    public abstract class Enemigo : Personaje
    {
        protected int VP { get; set; } // protegido asi solamente el código de la misma clase puede acceder al tipo.

        protected Enemigo(string nombre) : base(nombre)
        {
        }

        public int puntosDeVictoria { get { return this.VP;} }

    }

}