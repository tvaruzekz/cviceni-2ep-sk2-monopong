using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoPong
{
    public class Hra : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Ctverecek c;

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

            int velikost = 50;

            float stredX = graphics.PreferredBackBufferWidth / 2;
            float stredY = graphics.PreferredBackBufferHeight / 2;

            c = new Ctverecek(velikost, stredX - velikost / 2, stredY - velikost / 2, Color.Black, graphics.GraphicsDevice);
        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            c.Aktualizovat();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            spriteBatch.Begin();
            c.Vykreslit(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
