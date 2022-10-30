using System;
using System.Collections.Generic;
namespace RoleplayGame
{
    public class LaBruja : Enemigo
    {

        public LaBruja(string nombre) : base(nombre)
        {
            this.VP = 20;
        }

    }
}