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
    public class ScreenManager : BigBaller
    {
        public Matrix transform;
        Viewport view;
        Vector2 centre;
        BigBaller bigBaller;

        public ScreenManager(Viewport newView, ContentManager content) : base(content)
        {
            view = newView;
        }



        public void Update(GameTime gameTime, GameWorld bigBaller)
        {
            centre = new Vector2(base.position.X + (base.rectangle.Width / 2) - 400, 0);
            transform = Matrix.CreateScale(new Vector3(1, 1, 0)) *
                Matrix.CreateTranslation(new Vector3(-centre.X, -centre.Y, 0));
        }
    }
}
