using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Diagnostics;

namespace Animus.Graphic.Entity
{
    public delegate void OnClick();

    abstract public class Button : Sprite
    {
        //CONSTRUCTEURS
        public Button(Texture2D pTexture, Vector2 pPosition) : base(pTexture, pPosition)
        {
            tTexture = pTexture;
            v2Position = pPosition;
        }
        public Button(Texture2D pTexture, Vector2 pPosition,Vector2 pScale) : base(pTexture, pPosition, pScale)
        {
            tTexture = pTexture;
            v2Scale = pScale;
            v2Position = pPosition;
            ScaleX  = (int)pScale.X;
            ScaleY = (int)pScale.Y;
    }

        //MEMBRES
        public OnClick OnClick { get; set; }
        //public bool bIsHover { get; private set; }
        //public virtual Vector2 v2Position { get; set ; }
        //public virtual Texture2D tTexture { get; set; }
        //public abstract Rectangle rectBoundingBox { get; set; }
        //public int ScaleX { get; set; } = 1;
        //public int ScaleY { get; set; } = 1;

        private MouseState oldMouseState;

        //METHODES
        public override void Update(GameTime pGameTime)
        {
            MouseState newMouseState = Mouse.GetState();
            Point MousePos = newMouseState.Position;

            if (rectBoundingBox.Contains(MousePos))
            {
                if (!bIsHover)
                {
                    bIsHover = true;
                    Debug.WriteLine("The button is new hover");
                }
            }
            else
            {
                if (bIsHover)
                {
                    Debug.WriteLine("The button is no more hover");
                }
                bIsHover = false;
            }

            if (bIsHover)
            {
                if (newMouseState.LeftButton == ButtonState.Pressed && oldMouseState.LeftButton == ButtonState.Released)
                {
                    Debug.WriteLine("Button is clicked");
                    if (OnClick != null)
                        OnClick();
                }
            }

            oldMouseState = newMouseState;
        }

        public override void Draw(SpriteBatch pSpriteBatch)
        {
            
        }
    }
}
