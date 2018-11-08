using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game5
{
    
    public class GameObject
    {
        
        protected Texture2D sprite;
        protected Vector2 position;
        public float speed = 3f;
        public Vector2 Position;

        protected ContentManager content;

        /*
        public virtual Rectangle CollisionBox
        {
            
            get
            {
                
            }
        }

        public bool IsColliding(GameObject otherObject)
        { 
            
        }

        public virtual void DoCollision(GameObject otherObject)
        {

        }

    */



        public GameObject(Vector2 _position, ContentManager content, string spriteName)
        {
            Position = _position;
            sprite = content.Load<Texture2D>(spriteName);
        }

        public virtual void Update()
        {
            if(Keyboard.GetState().IsKeyDown(Keys.A))
            {
                position.X -= speed;
            }

            if(Keyboard.GetState().IsKeyDown(Keys.D))
            {
                position.X += speed;
            }

            if(Keyboard.GetState().IsKeyDown(Keys.W))
            {
                position.Y -= speed;
            }

            if(Keyboard.GetState().IsKeyDown(Keys.S))
            {
                position.Y += speed;
            }
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(sprite, position, Color.White);
        }
        

    }
}