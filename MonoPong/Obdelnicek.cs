using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoPong
{
    abstract class Obdelnicek
    {
        protected Texture2D Textura { get; }
        public int VelikostX { get; }
        public int VelikostY { get; }

        public Vektor2 Pozice { get; protected set; }
        public Color Barva { get; private set; }

        public Obdelnicek(int velikostx, int velikosty, float x, float y, Color barva, GraphicsDevice zobrazovaciZarizeni)
        {
            Textura = new Texture2D(zobrazovaciZarizeni, velikostx, velikosty);

            Color[] data = new Color[velikostx * velikosty];
            for (int i = 0; i < data.Length; i++)
                data[i] = Color.White;

            Textura.SetData(data);

            Pozice = new Vektor2( x, y );
            VelikostX = velikostx;
            VelikostY = velikosty;
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
