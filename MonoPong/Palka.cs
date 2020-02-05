using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoPong
{
    class Palka : Obdelnicek
    {
        public Palka(int velikostx, int velikosty, float x, float y, Color barva, GraphicsDevice zobrazovaciZarizeni) : base(velikostx, velikosty, x,  y,  barva,  zobrazovaciZarizeni)
        {

        }

        public void pohyb(Keys smerNahoru, Keys smerDolu, int Rychlost)
        {
            Vector2 smerPohybu = Vector2.Zero;

            if (Pozice.Y - Velikost.Y/2 <= 0)
            {
                smerNahoru = 0;
            }

            if (Pozice.Y + Velikost.Y/2 >= 750)
            {
                smerDolu = 0;
            }

            if (Keyboard.GetState().IsKeyDown(smerNahoru))
            {
                smerPohybu -= Vector2.UnitY * Rychlost;
            }
            else if(Keyboard.GetState().IsKeyDown(smerDolu))
            {
                smerPohybu += Vector2.UnitY * Rychlost;
            }

            if (smerPohybu != Vector2.Zero)
                Pozice += Vector2.Normalize(smerPohybu) * Rychlost;

        }
        public bool NarazilDoMicku(Vector2 PoziceMicku, Vector2 VelikostMicku)
        {
            return (Pozice.X - Velikost.X / 2 < PoziceMicku.X + Velikost.X / 2 && Pozice.X + Velikost.X / 2 > PoziceMicku.X - Velikost.X / 2 && Pozice.Y - Velikost.Y / 2 < PoziceMicku.Y + Velikost.Y / 2 && Pozice.Y + Velikost.Y / 2 > PoziceMicku.Y - Velikost.Y / 2);
                        
        }
     
    }
}
