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

        float animatedFPS = 60;
        int currentAnimationIndex = 0;
        double timeElapsed = 0;


        public AnimatedGameObject(int framecount, float animationFPS, Vector2 _position, ContentManager content, string spriteName) : base(_position, content, spriteName)
        {

        }


       /* public virtual void Update(GameTime gameTime)
        {

        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(sprite, position, null, Color.White);
        }
        */
        
    }
    
}