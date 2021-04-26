using Animus.Scene;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Diagnostics;

namespace Animus
{
    abstract public class MainGame : Game
    {
        public GraphicsDeviceManager graphics { get; protected set; }
        public SpriteBatch spriteBatch { get; set; }
        public GameState gameState { get; protected set; }

        public MainGame()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            //gameState = new GameState(this); A DECLARER DANS LE PROJET
            //graphics.PreferredBackBufferWidth = 570 * 2; A DECLARER DANS LE PROJET
            //graphics.PreferredBackBufferHeight = 640; A DECLARER DANS LE PROJET
        }

        protected override void Initialize()
        {
            //gameState.ChangeScene(GameState.SceneType.Menu); A DECLARER DANS LE PROJET
            IsMouseVisible = true;

            if (gameState.CurrentScene != null)
            {
                gameState.CurrentScene.Load();
                base.Initialize();
            }
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            if (gameState.CurrentScene != null)
            {
                gameState.CurrentScene.UnLoad();
            }
        }

        protected override void Update(GameTime gameTime)
        {
            if (gameState.CurrentScene != null)
            {
                gameState.CurrentScene.Update(gameTime);
            }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            spriteBatch.Begin(); 
            if (gameState.CurrentScene != null)
            {
                gameState.CurrentScene.Draw(gameTime);
            }
            spriteBatch.End(); 
            base.Draw(gameTime);
        }
    }
}
