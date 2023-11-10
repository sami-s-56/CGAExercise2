using CGE2;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SharpDX.Direct2D1;
using Effect = Microsoft.Xna.Framework.Graphics.Effect;
using SpriteBatch = Microsoft.Xna.Framework.Graphics.SpriteBatch;

namespace CGE2
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Effect _CustomEffect;
        private Model _model;
        private Texture2D _texture;
        
        private Form1 _form1;

        //Used for debugging to toggle between custom shader and basic effect
        bool bUseBasicEffect = true;

        private BasicEffect _basicEffect;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();


        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            _model = Content.Load<Model>("Teapot"); 
            _texture = Content.Load<Texture2D>("Smiley2");
            _CustomEffect = Content.Load<Effect>("CustomEffect");

            _basicEffect = new BasicEffect(GraphicsDevice)
            {
                TextureEnabled = true,
                VertexColorEnabled = true,
            };

            _form1 = new Form1();

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            
            GraphicsDevice.Clear(Color.Black);

            _form1.Show();

            if(bUseBasicEffect)
            {
                foreach (ModelMesh mesh in _model.Meshes)
                {
                    foreach (BasicEffect effect in mesh.Effects)
                    {
                        effect.EnableDefaultLighting();
                        effect.Texture = _texture;
                        effect.TextureEnabled = true;
                        effect.World = Matrix.Identity; // Apply necessary transformations here
                        effect.View = Matrix.CreateLookAt(new Vector3(0, 0, 5), Vector3.Zero, Vector3.Up); // Adjust the camera view
                        effect.Projection = Matrix.CreatePerspectiveFieldOfView(MathHelper.ToRadians(45), GraphicsDevice.Viewport.AspectRatio, 1.0f, 100.0f); // Set the perspective projection
                    }
                    mesh.Draw();
                }
            }
            else
            {
                foreach (var mesh in _model.Meshes)
                {
                    foreach (var part in mesh.MeshParts)
                    {
                        //Using this breakes the code, it says to define vertex shader but the default one is used right?
                        //Teapot gets rendered with texture using Basic Effect
                        
                        part.Effect = _CustomEffect;

                        //_CustomEffect.Parameters["World"].SetValue(Matrix.CreateTranslation(0, 0, 0));
                        //_CustomEffect.Parameters["View"].SetValue(Matrix.CreateLookAt(new Vector3(0, 0, 5f), Vector3.Zero, Vector3.Up));
                        //_CustomEffect.Parameters["Projection"].SetValue(Matrix.CreatePerspectiveFieldOfView(MathHelper.ToRadians(45), GraphicsDevice.Viewport.AspectRatio, 0.1f, 100.0f));

                        _CustomEffect.Parameters["YValue"].SetValue(_form1.Y); // Example Y value
                        _CustomEffect.Parameters["UValue"].SetValue(_form1.U); // Example U value
                        _CustomEffect.Parameters["VValue"].SetValue(_form1.V); // Example V value
                        _CustomEffect.Parameters["inputTexture"].SetValue(_texture);
                        _CustomEffect.Parameters["bInvertColor"].SetValue(_form1.bInvert);

                        _CustomEffect.Techniques[0].Passes[0].Apply();
                    }
                    mesh.Draw();
                }
            
            }


            base.Draw(gameTime);
        }
    }
}