using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System.Threading;

namespace Game5
{
    public class ScreenManager
    {

        float bgWidth;
        float bgHeight;

        Texture2D background2;
        Vector2[] positions;

        int bgSpeed;

        public void Initialize(float screenWidth, float screenHeight, Texture2D background2, int bgSpeed)
        {
            this.background2 = background2;
            bgHeight = screenHeight;
            bgWidth = background2.Width * (screenHeight / background2.Height);

            this.bgSpeed = bgSpeed;

            positions = new Vector2[(int)screenWidth / (int)bgWidth + 2];

            for (int i = 0; i < positions.Length; i++)
                positions[i].X = i * bgWidth;

        }

        public void Update(GameTime gameTime)
        {
            for (int i = 0; i < positions.Length; i++)
            {
                positions[i].X -= bgSpeed;

                if (positions[i].X <= -bgWidth) positions[i].X = (positions.Length - 1) * bgWidth;

            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < positions.Length; i++)
            {
                Rectangle bgScreen = new Rectangle(int)positions[i].X,
            }


        }

    }
}