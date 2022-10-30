using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    [TestFixture]
    public class TestEnano
    {

        [Test]
        public void AgregarElementoAtaque()
        {
            Enano Jose = new Enano("Jose"); 
            Jose.agregarElemento(new ArcoPesado()); 

            Assert.AreEqual(40, Jose.valorAtaque);
        }

        [Test]
        public void AgregarElementoDefensa()
        {
            Enano Jose = new Enano("Jose"); 
            Armadura armadura = new Armadura(); 
            
            Jose.agregarElemento(armadura);
            

            Assert.AreEqual(30, Jose.valorDefensa);
        }

        [Test]
        public void TestAtaque()
        {
            Enano Jose = new Enano("Jose"); 
            Elfo Pedro = new Elfo("Pedro"); 

            Pedro.recibirAtaque(Jose.valorAtaque);

            Assert.AreEqual(20, Pedro.Vida);
        }

        [Test]
        public void TestCurar()
        {
            Enano Jose = new Enano("Jose"); 
            Jose.recuperarVida();
            Assert.AreEqual(100, Jose.Vida);
        }

        [Test]
        public void RecibirAtaque()
        {
            Enano Jose = new Enano("Jose"); 

            Elfo martin = new Elfo("Martin"); 
            martin.agregarElemento(new ArcoPesado()); 

            Jose.recibirAtaque(martin.valorAtaque);
            Assert.AreEqual(60, Jose.Vida);
        }
    }
}