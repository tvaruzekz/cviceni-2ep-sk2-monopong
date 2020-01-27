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

        public Micek(int velikostx, int velikosty, float x, float y, Color barva, GraphicsDevice zobrazovaciZarizeni) :base (velikostx, velikosty, x, y, barva, zobrazovaciZarizeni)
        {
            LetiTimtoSmerem = NahodnySmerMickuKamPoleti.Next(0, 4);
        }

        public void Letim(int Rychlost)
        {
            if (LetiTimtoSmerem == 0)
            {
                Pozice += new Vector2(Rychlost, Rychlost);
            }
            else if (LetiTimtoSmerem == 1)
            {
                Pozice += new Vector2(Rychlost, -Rychlost);
            }
            else if (LetiTimtoSmerem == 2)
            {
                Pozice += new Vector2(-Rychlost, Rychlost);
            }
            else if (LetiTimtoSmerem == 3)
            {
                Pozice += new Vector2(-Rychlost, -Rychlost);
            }

            if (LetiTimtoSmerem == 4)
            {
                Debug.WriteLine("Tato akce se stala, i když neměla.");
                Debug.WriteLine("Spusťte program znovu.");
                Debug.WriteLine("Pokud se stato chyba stane znovu, udělejte stejnou akci.");
            }
        }
    }
}
