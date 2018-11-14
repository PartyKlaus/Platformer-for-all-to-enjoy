
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

    class BigBaller : Character
    {



        

        private int spriteWidth = 125;
        private int spriteHeight = 120;
        private float fps = 20;



        


        public BigBaller(ContentManager content) : base(new Vector2(0, 100), content, "Characters/Animations/spritesheet", 3, 1, 10)
        {

            this.content = content;
            AddAnimation(4, fps, 0, 0, "Idle", spriteWidth, spriteHeight);
            PlayAnimation("Idle");
        }



        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            position += velocity;
            rectangle = CollisionBox;



            Input(gameTime);

            if (velocity.Y < 10)
                velocity.Y += 0.4f;

            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;

            position += (velocity * deltaTime);
            

        }

        private void Input(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.D))
                velocity.X = (float)gameTime.ElapsedGameTime.TotalMilliseconds / 3;
            else if (Keyboard.GetState().IsKeyDown(Keys.A))
                velocity.X = -(float)gameTime.ElapsedGameTime.TotalMilliseconds / 3;
            else velocity.X = 0f;

            if (Keyboard.GetState().IsKeyDown(Keys.W) && hasJumped == false)
            {
                position.Y -= 5f;
                velocity.Y = -10f;
                hasJumped = true;
            }

        }
        
        //Kunne flyttes over i GameObject så den gælder for alle objekter
        /*
        public void Collision(Rectangle newRectangle, int xOffset, int yOffset)
        {
            if ( rectangle.TouchTopOf(newRectangle))
            {
                rectangle.Y = newRectangle.Y - rectangle.Height;
                velocity.Y = 0f;
                hasJumped = false;
            }

            if (rectangle.TouchLeftOf(newRectangle))
            {
                position.X = newRectangle.X - rectangle.Width - 2;
            }

            if (rectangle.TouchRightOf(newRectangle))
            {
                position.X = newRectangle.X + newRectangle.Width + 2;
            }

            if (rectangle.TouchBottomOf(newRectangle))
                velocity.Y = 1f;

            if (position.X < 0) position.X = 0;
            if (position.X > xOffset - rectangle.Width) position.X = xOffset - rectangle.Width;
            if (position.Y < 0) velocity.Y = 1f;
            if (position.Y > yOffset - rectangle.Height) position.Y = yOffset - rectangle.Height;

        }
        */
        

        /*
        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(sprite, rectangle, Color.White);
        }
        */


    }

}