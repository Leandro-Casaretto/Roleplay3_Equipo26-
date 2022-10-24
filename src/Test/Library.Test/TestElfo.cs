using System;
using System.Collections.Generic;
using NUnit.Framework;
using RoleplayGame;


namespace Test.Library
{
    public class TestElfo
    {
        [Test]
        public void testNombre()
        {
            Elfo TestNombre = new Elfo("Test");
            Assert.AreEqual(TestNombre.Nombre,"Test");
        }

        [Test]

        public void ataqueElfo()
        {
            Elfo TestAtaque = new Elfo("Test");
            IObjeto Arco = new ArcoPesado();

            int Ataque = Arco.valorAtaque;
            int ataqueReal = 20;

            Assert.AreEqual(ataqueReal,Ataque);
        }

        [Test]

        public void defensaElfo()
        {
            Elfo TestDefensa = new Elfo("Test");
            IObjeto Botas = new BotasDeOro();

            int Defensa = Botas.valorDefensa;
            int defensaReal = 5;

            Assert.AreEqual(defensaReal,Defensa);
        }

    }
}