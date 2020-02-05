using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoPong
{
    abstract class Obdelnicek
    {
        protected Texture2D Textura { get; }
        /*public int VelikostX { get; }

        public int VelikostY { get; }*/
        protected Vector2 Velikost { get; set; }

        public Vektor2 Pozice { get; protected set; }
        public Color Barva { get; private set; }

        public Obdelnicek(int velikostx, int velikosty, float x, float y, Color barva, GraphicsDevice zobrazovaciZarizeni)
        {
            Textura = new Texture2D(zobrazovaciZarizeni, velikostx, velikosty);

            Color[] data = new Color[velikostx * velikosty];
            for (int i = 0; i < data.Length; i++)
                data[i] = Color.White;

            Textura.SetData(data);

            Pozice = new Vector2 { X = x, Y = y };
            Velikost = new Vector2(velikostx, velikosty);
            Barva = barva;
        }

        public void Aktualizovat()
        {

        }

        public void Vykreslit(SpriteBatch vykreslovaciDavka)
        {
            vykreslovaciDavka.Draw(Textura, new Vector2(Pozice.X - Velikost.X/2, Pozice.Y - Velikost.Y / 2), Barva);
        }
    }
}
