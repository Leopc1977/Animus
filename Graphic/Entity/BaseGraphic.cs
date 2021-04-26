using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Animus.Graphic.Entity
{
    abstract public class BaseGraphic
    {
        public abstract Vector2 v2Position { get; set; }
        public virtual int iWidth { get; set; }
        public virtual int iHeight { get; set; }

        public abstract Rectangle rectBoundingBox { get; set; }
        public abstract string strName { get; set; }

        public abstract void Update(GameTime gameTime);
        public abstract void Draw(SpriteBatch pSpriteBatch);
        public abstract bool bToRemove { get; set; }
        public abstract  Texture2D tTexture { get; set; }

        public Vector2 v2Scale { get; set; }
        public int ScaleX { get; set; }
        public int ScaleY { get; set; }
    }
}
