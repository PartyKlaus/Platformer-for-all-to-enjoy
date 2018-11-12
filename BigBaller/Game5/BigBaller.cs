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

        private float jump = 50;

       /* public BigBaller()
        {

        }
        */
        

        public BigBaller(ContentManager content) : base(new Vector2(50,100), content, "Characters/cat_idle", 10,40,2)
        {
            this.content = content;
        }

         public override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                position.X -= speed;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                position.X += speed;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.W))
            {
                position.Y -= speed;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                position.Y += speed;
            }

            base.Update(gameTime);
        }

        
    }
    
}