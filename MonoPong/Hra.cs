using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoPong
{
    public class Hra : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Palka palka1, palka2;
        Micek micek;

        private int Velikostx = 25;
        private int Velikosty = 150;
        private float PoziceX = 50;
        private float PoziceY = (750/2)-75;
        private float PoziceX2 = 825;
        private int Rychlost = 5;

        private int Sirka = 900;
        private int Vyska = 750;

        public Hra()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

        }
        
        protected override void Initialize()
        {
            Window.Title = "MonoPong";
            graphics.PreferredBackBufferWidth = 900;
            graphics.PreferredBackBufferHeight = 750;
            graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            palka1 = new Palka(Velikostx, Velikosty, PoziceX, PoziceY, Color.Red, graphics.GraphicsDevice);
            palka2 = new Palka(Velikostx, Velikosty, PoziceX2, PoziceY, Color.Black, graphics.GraphicsDevice);
            micek = new Micek(Velikostx, Velikostx, Sirka/2 - Velikostx, Vyska/2, Color.Khaki, graphics.GraphicsDevice);
        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            palka1.pohyb(Keys.W, Keys.S, Rychlost);
            palka2.pohyb(Keys.Up, Keys.Down, Rychlost);

            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            if(micek.KolizeSPalkou(palka1) || micek.KolizeSPalkou(palka2))
                micek.Odraz();
            micek.Letim();
            micek.OsetreniStran(Vyska);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);
            spriteBatch.Begin();
            palka1.Vykreslit(spriteBatch);
            palka2.Vykreslit(spriteBatch);
            micek.Vykreslit(spriteBatch);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
