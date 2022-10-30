using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    [TestFixture]
    public class EncounterTest
    {
        [Test]
        public void agregarHeroe()
        {
            Encuentro encuentro = new Encuentro();

            Personaje elfo = new Elfo("Jose");
            encuentro.agregarPersonaje(elfo);
            Assert.Contains(elfo, encuentro.Jugadores);  
        }
        [Test]
        public void agregarEnemigo()
        {
            Encuentro encuentro = new Encuentro();

            Personaje ElDemonio = new ElDemonio("Demonio");
            encuentro.agregarPersonaje(ElDemonio);
            Assert.Contains(ElDemonio, encuentro.Jugadores);
        }

        [Test]
        public void DoEncounterHeroWinsTest()
        {
            Encuentro encuentro = new Encuentro();

            Personaje enano = new Enano("Jose");
            encuentro.agregarPersonaje(enano);
            enano.agregarElemento(new Martillo());
            Personaje ElDemonio = new ElDemonio("Demonio");
            encuentro.agregarPersonaje(ElDemonio);

            encuentro.Batallar();
            Assert.IsTrue(ElDemonio.Vida <= 0);
        }

    }
}
