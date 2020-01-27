﻿using Microsoft.Xna.Framework;
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
        public Micek(int velikostx, int velikosty, float x, float y, Color barva, GraphicsDevice zobrazovaciZarizeni) :base (velikostx, velikosty, x, y, barva, zobrazovaciZarizeni)
        {
            LetiTimtoSmerem = NahodnySmerMickuKamPoleti.Next(0, 2);
        }

        public void Letim(int Rychlost)
        {
            if (LetiTimtoSmerem == 2)
            {
                Environment.Exit(1);
            }
            if (LetiTimtoSmerem == 1)
            {
                Pozice += new Vector2(Rychlost, 0);
            }
            else
            {
                Pozice += new Vector2(-Rychlost, 0);
            }
        }
    }
}
