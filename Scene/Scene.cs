using Animus.Graphic;
using Animus.Graphic.Entity;
using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace Animus.Scene
{
    public abstract class Scene : IScene
    {
        protected MainGame Main;
        public static List<BaseGraphic> listActors;

        public Scene(MainGame pGame)
        {
            Main = pGame;
            listActors = new List<BaseGraphic>();
        }

        public virtual void Load(){}
        public virtual void UnLoad(){}

        public virtual void Update(GameTime gameTime)
        {
            foreach (BaseGraphic actor in listActors)
            {
                actor.Update(gameTime);
            }
        }
        public virtual void Draw(GameTime gameTime)
        {
            foreach (BaseGraphic actor in listActors)
            {
                actor.Draw(Main.spriteBatch);
            }
        }
    }
}
