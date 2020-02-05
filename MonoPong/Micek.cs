using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoPong
{
    class Micek : Obdelnicek
    {
        Random NahodnySmerMickuKamPoleti = new Random();
        private int LetiTimtoSmerem;
        Vector2 Rychlost;
        public Micek(int velikostx, int velikosty, float x, float y, Color barva, GraphicsDevice zobrazovaciZarizeni) :base (velikostx, velikosty, x, y, barva, zobrazovaciZarizeni)
        {
            LetiTimtoSmerem = NahodnySmerMickuKamPoleti.Next(0, 4);
            Rychlost = new Vector2(-3, -1);
        }

        public void Letim()
        {
            Pozice += Rychlost;
        }
        public bool KolizeSPalkou(Palka palka)
        {
            return palka.NarazilDoMicku(Pozice, Velikost);
        }
        public void Odraz()
        {
                Rychlost.X *= -1;
        }
        public void OsetreniStran(int VyskaOkna)
        {
            if (Pozice.Y < 0 + Velikost.Y/2)
            {
                Rychlost.Y = Math.Abs(Rychlost.Y);                
            }
            if (Pozice.Y > VyskaOkna - Velikost.Y/2)
            {
                Rychlost.Y = -Math.Abs(Rychlost.Y);
            }
        }

    }
}
