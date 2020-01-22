using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoPong
{
    abstract class Ctverecek
    {
        protected Texture2D Textura { get; }
        public int Velikost { get; }

        public Vector2 Pozice { get; private set; }
        public Color Barva { get; private set; }

        public Ctverecek(int velikost, float x, float y, Color barva, GraphicsDevice zobrazovaciZarizeni)
        {
            Textura = new Texture2D(zobrazovaciZarizeni, velikost, velikost);

            Color[] data = new Color[velikost * velikost];
            for (int i = 0; i < data.Length; i++)
                data[i] = Color.White;

            Textura.SetData(data);

            Pozice = new Vector2 { X = x, Y = y };
            Velikost = velikost;
            Barva = barva;
        }

        public void Aktualizovat()
        {

        }

        public void Vykreslit(SpriteBatch vykreslovaciDavka)
        {
            vykreslovaciDavka.Draw(Textura, Pozice, Barva);
        }
    }
}
