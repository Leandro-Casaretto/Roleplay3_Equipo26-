using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    [TestFixture]
    public class TestMago
    {

        [Test]
        public void AgregarElementoAtaque()
        {
            Mago Matias = new Mago("Matias"); 
            Matias.agregarElemento(new BaculoHelado()); 

            Assert.AreEqual(40, Matias.valorAtaque);
        }

        [Test]
        public void AgregarElementoDefensa()
        {
            Mago Matias = new Mago("Matias"); 
            CapaOscura capaOscura = new CapaOscura(); 
            
            Matias.agregarElemento(capaOscura);
            

            Assert.AreEqual(30, Matias.valorDefensa);
        }

        [Test]
        public void TestAtaque()
        {
            Mago Matias = new Mago("Matias"); 
            Elfo Pedro = new Elfo("Pedro"); 

            Pedro.recibirAtaque(Matias.valorAtaque);

            Assert.AreEqual(20, Pedro.Vida);
        }

        [Test]
        public void TestCurar()
        {
            Mago Matias = new Mago("Matias"); 
            Matias.recuperarVida();
            Assert.AreEqual(100, Matias.Vida);
        }

        [Test]
        public void RecibirAtaque()
        {
            Mago Matias = new Mago("Matias"); 

            Elfo martin = new Elfo("Martin"); 
            martin.agregarElemento(new ArcoPesado()); 

            Matias.recibirAtaque(martin.valorAtaque);
            Assert.AreEqual(60, Matias.Vida);
        }
    }
}