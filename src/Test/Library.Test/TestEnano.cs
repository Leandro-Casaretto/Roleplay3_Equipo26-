using System;
using System.Collections.Generic;
using NUnit.Framework;
using RoleplayGame;


namespace Test.Library
{
    public class TestEnano
    {
        [Test]
        public void testNombre()
        {
            Enano TestNombre = new Enano("Test Nombre");

            Assert.AreEqual(TestNombre.Nombre,"Test Nombre");
        }

        [Test]

        public void ataqueEnano()
        {
            Enano TestAtaque = new Enano("Test Ataque");
            IObjeto Martillo = new Martillo();
    
            int Ataque = Martillo.valorAtaque;
            int ataqueReal = 30;

            Assert.AreEqual(ataqueReal,Ataque);
        }

        [Test]

        public void defensaEnano()
        {
            Enano TestDefensa = new Enano("Test Defensa");
            IObjeto Casco = new CascoDeOro();

            int Defensa = Casco.valorDefensa;
            int defensaReal = 10;

            Assert.AreEqual(defensaReal,Defensa);
        }

    }
}