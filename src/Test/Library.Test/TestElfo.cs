using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    [TestFixture]
    public class TestElfo
    {

        [Test]
        public void AgregarElementoAtaque()
        {
            Elfo eduardo = new Elfo("Eduardo"); 
            eduardo.agregarElemento(new Martillo()); 

            Assert.AreEqual(40, eduardo.valorAtaque);
        }

        [Test]
        public void AgregarElementoDefensa()
        {
            Elfo eduardo = new Elfo("Eduardo"); 
            Armadura armadura = new Armadura(); 
            
            eduardo.agregarElemento(armadura);
            

            Assert.AreEqual(30, eduardo.valorDefensa);
        }

        [Test]
        public void TestAtaque()
        {
            Elfo eduardo = new Elfo("Eduardo"); 
            Enano pedro = new Enano("Pedro"); 

            pedro.recibirAtaque(eduardo.valorAtaque);

            Assert.AreEqual(20, eduardo.Vida);
        }

        [Test]
        public void TestCurar()
        {
            Elfo eduardo = new Elfo("Eduardo"); 
            eduardo.recuperarVida();
            Assert.AreEqual(100, eduardo.Vida);
        }

        [Test]
        public void RecibirAtaque()
        {
            Elfo eduardo = new Elfo("Eduardo"); 

            Enano martin = new Enano("Martin"); 
            martin.agregarElemento(new Martillo()); 

            eduardo.recibirAtaque(martin.valorAtaque);
            Assert.AreEqual(60, eduardo.Vida);
        }
    }
}