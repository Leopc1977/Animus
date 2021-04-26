using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Animus.Graphic.Entity
{
    abstract public class Sprite : BaseGraphic
    {
        //CONSTRUCTEURS
        public Sprite(Texture2D pTexture, Vector2 pPosition)
        {
            tTexture = pTexture;
            bToRemove = false;
            v2Position = pPosition;
            rectBoundingBox = new Rectangle((int)pPosition.X, (int)pPosition.Y, tTexture.Width, tTexture.Height);
        }

        public Sprite(Texture2D pTexture, Vector2 pPosition, Vector2 pScale)
        {
            tTexture = pTexture;
            rectBoundingBox = new Rectangle((int)pPosition.X,(int)pPosition.Y, tTexture.Width, tTexture.Height);
            bToRemove = false;
            v2Scale = pScale;
            iScaleX = (int)pScale.X;
            iScaleY = (int)pScale.Y;
            v2Position = pPosition;
        }

        //MEMBRES
        public Vector2 v2Origin { get; set; } = new Vector2(0, 0);
        public override Vector2 v2Position { get; set; }
        public override Texture2D tTexture { get; set; }
        public virtual Vector2 v2Scale { get; set; } = new Vector2(1, 1);
        public virtual int iScaleX { get; set; } = 1;
        public virtual int iScaleY { get; set; } = 1;
        public override Rectangle rectBoundingBox { get; set; }

        public Point pMousePos;
        private MouseState oldMouseState;
        public delegate void onMaintained();
        public delegate void onRelease();
        public bool bIsHover { get; protected set; }
        public bool bIsMaintained { get; protected set; }
        public bool bIsRelease { get; private set; }

        public override string strName { get; set; } = "";
        public override bool bToRemove { get; set; }

        //METHODES
        //public abstract void Update(GameTime gametime);
        //public abstract void Draw(SpriteBatch pSpriteBatch) { }
    }
}
