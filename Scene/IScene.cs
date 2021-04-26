using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animus.Scene
{
    public interface IScene
    {
        public virtual void Load() {}
        public virtual void UnLoad() {}
        public abstract void Update(GameTime gameTime);
        public abstract void Draw(GameTime gameTime);
    }
}
