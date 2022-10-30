using System;
using System.Collections.Generic;
namespace RoleplayGame
{
    public class ElHombreLobo : Enemigo
    {

        public ElHombreLobo(string nombre) : base(nombre)
        {
            this.VP = 10;
        }

    }
}