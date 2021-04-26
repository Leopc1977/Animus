using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Diagnostics;

namespace Animus.Graphic.Entity.Buttons
{
    public class StaticButton : Button
    {

        //CONSTRUCETURS
        public StaticButton(Texture2D pTexture, Vector2 pPosition) : base(pTexture, pPosition)
        {
        }
        public StaticButton(Texture2D pTexture, Vector2 pPosition, Vector2 pScale) : base(pTexture, pPosition, pScale)
        {
        }

        public override void Draw(SpriteBatch pSpriteBatch)
        {
            pSpriteBatch.Draw(tTexture, v2Position, Color.White);
        }
    }
}
