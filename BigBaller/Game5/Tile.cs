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
    class Tile
    {
        protected Texture2D tileTexture;

        private Rectangle rectangle;
        public Rectangle Rectangle
        {
            get { return rectangle; }
            protected set { rectangle = value; }
        }

        private static ContentManager content;
        public static ContentManager Content
        {
            protected get { return content; }
            set { content = value; }
        }

        public void draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(tileTexture, rectangle, Color.White);
        }

        
        
    }

    class CollisionTiles : Tile
    {
        public CollisionTiles(int i, Rectangle newRectangle)
        {
            tileTexture = Content.Load<Texture2D>("Tiles/Tile" + i);
            this.Rectangle = newRectangle;
        }
    }
}
