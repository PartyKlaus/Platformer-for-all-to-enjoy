using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game5
{
    class Platform : GameObject
    {
        public Rectangle rectangle;

        public Platform(Vector2 _position, ContentManager content, string spriteName) : base(_position, content, spriteName)
        {
            rectangle = new Rectangle((int)position.X, (int)position.Y,
                sprite.Width, sprite.Height);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(sprite, rectangle, Color.White);
        }
    }
}
