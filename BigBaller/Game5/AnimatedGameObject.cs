using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Game5
{
    public class AnimatedGameObject : GameObject
    {
        Rectangle[] animationRectangles;

        float animatedFPS = 20000;
        int currentAnimationIndex = 0;
        double timeElapsed = 0;


        AnimatedGameObject(int framecount, float animationFPS, ContentManager content, string spriteName)
        {

        }


        public virtual void Update(GameTime gameTime)
        {

        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {

        }
    }
}