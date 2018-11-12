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
        private float moveSpeed = 100;
        private double shootRate = 0;
        private int health;

        public Character( Vector2 _position, ContentManager content, string spriteName, int _health, float _moveSpeed, double _shootRate) : base(0, 0, _position,content, spriteName)
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

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(sprite, position, null, Color.White);
        }

    }
    
}