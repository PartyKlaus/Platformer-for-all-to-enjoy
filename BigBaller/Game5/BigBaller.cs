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
        private Texture2D bigBallertexture;
        private Vector2 position = new Vector2(0, 384);
        public Vector2 velocity;
        private Rectangle rectangle;

        private bool hasJumped = false;

        public Vector2 Position
        {
            get { return position; }
        }

        public BigBaller(ContentManager content) : base(new Vector2(0, 200), content, "Characters/BigBaller", 3, 10, 10)
        {
            this.content = content;
        }

        public void Load(ContentManager Content)
        {
            bigBallertexture = Content.Load<Texture2D>("Characters/BigBaller");
        }



        public void Update(GameTime gameTime)
        {
            position += velocity;
            rectangle = new Rectangle((int)position.X, (int)position.Y, bigBallertexture.Width, bigBallertexture.Height);

            Input(gameTime);

            if (velocity.Y < 10)
                velocity.Y += 0.4f;

        }

        private void Input(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.D))
                velocity.X = (float)gameTime.ElapsedGameTime.TotalMilliseconds / 3;
            else if (Keyboard.GetState().IsKeyDown(Keys.A))
                velocity.X = -(float)gameTime.ElapsedGameTime.TotalMilliseconds / 3;
            else velocity.X = 0f;

            if (Keyboard.GetState().IsKeyDown(Keys.W) && hasJumped==false)
            {
                position.Y -= 5f;
                velocity.Y = -10f;
                hasJumped = true;
            }

        }

        public void Collision(Rectangle newRectangle, int xOffset, int yOffset)
        {
            if (rectangle.TouchTopOf(newRectangle))
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

        public void Draw(SpriteBatch spriteBatch)
        { 
                spriteBatch.Draw(bigBallertexture, rectangle, Color.White);
        }
        

        
    }
    
}