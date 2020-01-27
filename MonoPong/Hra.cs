using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoPong
{
    public class Hra : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Palka palka1;
        private int Velikostx = 25;
        private int Velikosty = 150;
        private float PoziceX = 50;
        private float PoziceY = 50;
        private int Rychlost = 5; 

        public Hra()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }
        
        protected override void Initialize()
        {
            Window.Title = "MonoPong";

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            palka1 = new Palka(Velikostx, Velikosty, PoziceX, PoziceY, Color.Red, graphics.GraphicsDevice);
        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            palka1.pohyb(Keys.W, Keys.S, Rychlost);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);
            spriteBatch.Begin();
            palka1.Vykreslit(spriteBatch);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
