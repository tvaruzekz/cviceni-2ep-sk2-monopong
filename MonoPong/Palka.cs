using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoPong
{
    class Palka : Obdelnicek
    {
        public Palka()
        {

        }

        public void pohyb(KeyboardState stavKlavesnice, Keys smerNahoru, Keys smerDolu, int Rychlost)
        {
            Vector2 smerPohybu = Vector2.Zero;

            if(stavKlavesnice.IsKeyDown(smerNahoru))
            {
                smerPohybu -= Vector2.UnitY * Rychlost;
            }
            else if(stavKlavesnice.IsKeyDown(smerDolu))
            {
                smerPohybu += Vector2.UnitY * Rychlost;
            }
        }
    }
}
