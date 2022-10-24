using System;
using System.Collections.Generic;
using NUnit.Framework;
using RoleplayGame;


namespace Test.Library
{
    public class TestMago
    {
        [Test]
        public void testNombre()
        {
            Mago TestNombre = new Mago("Test Nombre");

            Assert.AreEqual(TestNombre.Nombre,"Test Nombre");
        }

        [Test]

        public void ataqueMago()
        {
            Mago TestAtaque = new Mago("Test Ataque");
            IObjeto BaculoHelado = new BaculoHelado();
    
            int Ataque = BaculoHelado.valorAtaque;
            int ataqueReal = 80;

            Assert.AreEqual(ataqueReal,Ataque);
        }

        [Test]

        public void defensaMago()
        {
            Mago TestDefensa = new Mago("Test Defensa");
            IObjeto CapaOscura = new CapaOscura();

            int Defensa = CapaOscura.valorDefensa;
            int defensaReal = 40;

            Assert.AreEqual(defensaReal,Defensa);
        }

    }
}