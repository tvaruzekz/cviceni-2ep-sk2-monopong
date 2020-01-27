using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoPong
{
    abstract class Ctverecek
    {
        private Texture2D Textura { get; }
        public int Velikost { get; }

        public Vektor2 Pozice { get; protected set; }
        public Color Barva { get; protected set; }

        public Ctverecek(int velikost, float x, float y, Color barva, GraphicsDevice zobrazovaciZarizeni)
        {
            Textura = new Texture2D(zobrazovaciZarizeni, velikost, velikost);

            Color[] data = new Color[velikost * velikost];
            for (int i = 0; i < data.Length; i++)
                data[i] = Color.White;

            Textura.SetData(data);

            Pozice = new Vektor2(x, y);
            Velikost = velikost;
            Barva = barva;
        }

        public void Aktualizovat()
        {

        }

        public void Vykreslit(SpriteBatch vykreslovaciDavka)
        {
            vykreslovaciDavka.Draw(Textura, Pozice.V2, Barva);
        }
    }
}
