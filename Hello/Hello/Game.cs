using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Astrid.Framework;
using Astrid.Core;
using Astrid.Framework.Graphics;
using Astrid.Framework.Assets;
namespace Hello
{
    public class Game : GameBase
    {
        private SpriteBatch spriteBatch;
        private Texture texture;
        private Vector2 position;

        public Game(ApplicationBase application)
            : base(application)
        {
        }

        public override void Create()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            texture = AssetManager.Load<Texture>("Man.png");

            var x = GraphicsDevice.Width / 2 - texture.Width / 2;
            var y = GraphicsDevice.Height / 2 - texture.Height / 2;
            position = new Vector2(x, y);
        }

        public override void Destroy()
        {
        }

        public override void Pause()
        {
        }

        public override void Resume()
        {
        }

        public override void Resize(int width, int height)
        {
        }

        public override void Update(float deltaTime)
        {
        }

        public override void Render(float deltaTime)
        {
            GraphicsDevice.Clear(Color.SkyBlue);

            spriteBatch.Begin();
            spriteBatch.Draw(texture, position);
            spriteBatch.End();
        }
    }
}
