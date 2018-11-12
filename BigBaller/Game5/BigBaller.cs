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
    
    public class BigBaller : Character
    {

        public Vector2 velocity;
        public bool hasJumped;

        public BigBaller(ContentManager content) : base(new Vector2(50,100), content, "Characters/BigBaller", 10,40,2)
        {
            this.content = content;
        }

        


        public override void Update(GameTime gameTime)
        {
            rectangle = new Rectangle((int)position.X, (int)position.Y, sprite.Width, sprite.Height);

            position += velocity;

            if (Keyboard.GetState().IsKeyDown(Keys.Right)) velocity.X = speed;
            else if (Keyboard.GetState().IsKeyDown(Keys.Left)) velocity.X = -speed; else velocity.X = 0f;

            if (Keyboard.GetState().IsKeyDown(Keys.Up) && hasJumped == false)
            {
                position.Y -= 10f;
                velocity.Y = -5f;
                hasJumped = true;
            }

            if (hasJumped == true)
            {
                float i = 1;
                velocity.Y += 0.15f * i;
            }

            if (position.Y + sprite.Height >= 450)
                hasJumped = false;

            if (hasJumped == false)
                velocity.Y = 0f;

        }


        public void Draw(SpriteBatch SpriteBatch)
        {
            if(health > 0)
                SpriteBatch.Draw(sprite, position, Color.White);
        }
        

        
    }
    
}