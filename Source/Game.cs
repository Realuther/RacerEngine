//(C) 2019 Daniel Luther
//Racer Engine 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics;


namespace RacerEngine
{
    public abstract class Game : GameWindow
    {
        private static Game instance;
        public static Game Instance
        {
            get { return instance; }
        }

        public Game(int width, int height, string title) : base(width, height, GraphicsMode.Default, title)
        {

            if(instance != null)
            {
                Console.WriteLine("Never run two instances at once");
            }
            instance = this;
            Run();
        }

        protected override void OnLoad(EventArgs e)
        {
            Start();
            RenderingSystem.Initialize(1, 0, 0);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            Input.Update();
            Update();
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            RenderingSystem.ClearScreen();
            Render();
            SwapBuffers();
        }

        protected override void OnClosed(EventArgs e)
        {
            ShutDown();
            Dispose();
        }

        protected override void OnFocusedChanged(EventArgs e)
        {
        }

        //Vert Methods
        protected virtual void Start()
        {

        }

        protected virtual void Update()
        {

        }

        protected virtual void Render()
        {

        }

        protected virtual void ShutDown()
        {

        }
    }
}
