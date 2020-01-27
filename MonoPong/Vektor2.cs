using Microsoft.Xna.Framework;

namespace MonoPong
{
    class Vektor2
    {
        public float X { get; set; }
        public float Y { get; set; }
        public Vector2 V2 => new Vector2(X, Y);

        public Vektor2(float x, float y)
        {
            X = x;
            Y = y;
        }
    }
}
