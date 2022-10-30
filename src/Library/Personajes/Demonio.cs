using System;
using System.Collections.Generic;
namespace RoleplayGame
{
    public class ElDemonio : Enemigo
    {

        public ElDemonio(string nombre) : base(nombre)
        {
            this.VP = 5;
        }

    }
}