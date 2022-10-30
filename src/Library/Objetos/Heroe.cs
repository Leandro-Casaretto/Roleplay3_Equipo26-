namespace RoleplayGame
{
    public abstract class Heroe : Personaje
    {
        protected int totalVP{ get; set; } // protegido asi solamente el código de la misma clase puede acceder al tipo.
        
        protected Heroe(string nombre) : base (nombre)
        {
            this.totalVP = 0;
        }

        public int puntosDeVictoria
        {
            get
            {
                return this.totalVP;
            }
            set
            {
                this.totalVP = value;
            }
        }
        public virtual int puntosTotales(int vp)
        {
            return totalVP += vp;
        }
    }

}