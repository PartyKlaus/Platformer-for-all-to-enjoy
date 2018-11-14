using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Game5
{
    
    public abstract class AnimatedGameObject : GameObject
    {
        private Rectangle[] animationRectangles;


        private int currentAnimationIndex;
        private double timeElapsed;
        private float animatedFPS;

        private string currentAnimation;

        public float FramesPerSecond
        {
            set { animatedFPS = (1f / value); }
        }

        public override Rectangle CollisionBox
        {
            get
            {
                return new Rectangle((int)position.X, (int)position.Y, sAnimations[currentAnimation][currentAnimationIndex].Width, sAnimations[currentAnimation][currentAnimationIndex].Height);
            }

        }

        private Dictionary<string, Rectangle[]> sAnimations = new Dictionary<string, Rectangle[]>();

        /// <summary>
        /// AnimatedGameObject constructor
        /// </summary>
        /// <param name="frames">Number of frames in spritesheet</param>
        /// <param name="_animatedFPS">Animation Speed</param>
        /// <param name="_position">Sprite's position in gameworld</param>
        /// <param name="content"></param>
        /// <param name="spriteName">Name of sprite file</param>
        public AnimatedGameObject(Vector2 _position, ContentManager content, string spriteName) : base(_position, content, spriteName)
        {

        }

        public void AddAnimation(int frames, float _animatedFPS, int yPos, int xStartFrame, string name, int width, int height)
        {
            this.FramesPerSecond = _animatedFPS;

            Rectangle[] Rectangles = new Rectangle[frames];

            for (int i = 0; i < frames; i++)
            {
                Rectangles[i] = new Rectangle((i + xStartFrame) * width, yPos, width, height); // lav (yPos*width) til yPos, hvis det ikke virker
            }
            sAnimations.Add(name, Rectangles);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            timeElapsed += gameTime.ElapsedGameTime.TotalSeconds;


            if (timeElapsed > animatedFPS)
            {
                timeElapsed -= animatedFPS;

                if (currentAnimationIndex <sAnimations[currentAnimation].Length-1)
                {
                    currentAnimationIndex++;
                }
                else
                {
                    currentAnimationIndex = 0;
                }
            }

        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(sprite, position, sAnimations[currentAnimation][currentAnimationIndex], Color.White);
        }
        
        public void PlayAnimation(string name)
        {
            if (currentAnimation != name)
            {
                currentAnimation = name;
                currentAnimationIndex = 0;
            }
        }
    }
    
}