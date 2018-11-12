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
        public float speed = 3f;
        protected Vector2 position;
        public Vector2 Position { get => position; }

        protected ContentManager content;


        public virtual Rectangle CollisionBox
        {
            get
            {
                return new Rectangle((int)position.X, (int)position.Y, sprite.Width, sprite.Height);
            }
        }

        /*

        public bool IsColliding(GameObject otherObject)
        { 
            
        }

        public virtual void DoCollision(GameObject otherObject)
        {

        }

    */



        public GameObject(Vector2 _position, ContentManager content, string spriteName)
        {
            this.content = content;
            position = _position;
            sprite = content.Load<Texture2D>(spriteName);
        }

        public virtual void Update(GameTime gameTime)
        {

        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(sprite, position, null, Color.White);
        }
        

    }
}