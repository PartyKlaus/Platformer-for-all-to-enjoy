﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game5
{
    public class Obstacle : GameObject
    {

        public void Spikes()
        {
            throw new System.NotImplementedException();
        }


        public Obstacle(Vector2 _position, ContentManager content, string spriteName) : base(_position, content, spriteName)
        {
            rectangle = new Rectangle((int)position.X, (int)position.Y,
                sprite.Width, sprite.Height);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(sprite, rectangle, Color.White);
        }

        public void BouncePad()
        {
            throw new System.NotImplementedException();
        }
    }
}