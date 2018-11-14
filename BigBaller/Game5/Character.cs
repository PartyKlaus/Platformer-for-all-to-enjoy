using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game5
{
    
    public class Character : AnimatedGameObject
    {

        
        private string name;
        protected float moveSpeed = 1;
        private double shootRate = 0;
        protected int health;

        /// <summary>
        /// Character constructor
        /// </summary>
        /// <param name="_position">sprite's position in gameworld</param>
        /// <param name="content">content</param>
        /// <param name="spriteName">Name of sprite file/filepath</param>
        /// <param name="frames">Number of frames in spritesheet</param>
        /// <param name="_animatedFPS">Animation speed</param>
        /// <param name="_health">Sprite's health</param>
        /// <param name="_moveSpeed">Sprite's speed</param>
        /// <param name="_shootRate">Sprite's shootrate</param>
        public Character(Vector2 _position, ContentManager content, string spriteName, int _health, float _moveSpeed, double _shootRate) : base(_position,content, spriteName)
        {
            health = _health;
            moveSpeed = _moveSpeed;
            shootRate = _shootRate;
        }

        public int TotalHealth
        {
            get => default(int);
            set
            {
            }
        }

        public void shoot()
        {
            throw new System.NotImplementedException();
        }

        public void move()
        {
            throw new System.NotImplementedException();
        }
        /*
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(sprite, position, null, Color.White);
        }
        */

    }
    
}