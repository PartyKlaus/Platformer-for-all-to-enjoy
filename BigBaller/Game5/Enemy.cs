using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game5
{

    public class Enemy : Character
    {

        BigBaller bigBaller;
        Texture2D enemyTexture;
        Vector2 origin;
        float rotation = 0f;

        bool right;
        float distance;
        float oldDistance;

        public Enemy(ContentManager content, Vector2 _position, float newDistance) : base(new Vector2(), content, "Characters/Slime", 3, 10, 10)
        {
            this.content = content;
            distance = newDistance;
            oldDistance = distance;
        }

        float mouseDistance;
        public override void Update(GameTime gameTime)
        {
            position += velocity;
            origin = new Vector2(sprite.Width / 2, sprite.Height);

            if (distance <= 0)
            {
                right = true;
                velocity.X = 1f;

            }
            else if (distance >= oldDistance)
            {
                right = false;
                velocity.X = -1;
            }

            if (right) distance += 1; else distance -= 1;

            MouseState mouse = Mouse.GetState();
            mouseDistance = mouse.X - position.X;

            if (mouseDistance <= -200 && mouseDistance <= 200)
            {
                if (mouseDistance < -1)
                    velocity.X = -1f;
                else if (mouseDistance > 1)
                    velocity.X = 1f;
                else if (mouseDistance == 0)
                    velocity.X = 0f;
            }

            base.Update(gameTime);

        }

        public void draw(SpriteBatch spriteBatch)
        {
            if (velocity.X > 0)
                spriteBatch.Draw(sprite, position, null, Color.White, rotation, origin, 1f, SpriteEffects.FlipHorizontally, 0f);
            else
                spriteBatch.Draw(sprite, position, null, Color.White, rotation, origin, 1f, SpriteEffects.None, 0f);
            base.Draw(spriteBatch);
        }




    }

}