using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game5
{
    public class Character : AnimatedGameObject
    {


        private string name;
        private const float moveSpeed = 100;
        private double shootRate = 0;
        private int Health;

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
    }
}