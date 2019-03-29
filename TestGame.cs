//(C) 2019 Daniel Luther
//Racer Engine Test Game

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacerEngine
{
    public class TestGame : Game
    {
        public TestGame(int width, int height, string title) : base(width, height, title)
        {

        }

        protected override void Start()
        {
            
        }

        protected override void Update()
        {
            if (Input.GetKeyDown(OpenTK.Input.Key.G))
            {
                RenderingSystem.SetClearColor(0, 1, 0);
            }
            if (Input.GetKeyDown(OpenTK.Input.Key.R))
            {
                RenderingSystem.SetClearColor(1, 0, 0);
            }
            if (Input.GetKeyDown(OpenTK.Input.Key.B))
            {
                RenderingSystem.SetClearColor(0, 0, 1);
            }
        }

        protected override void Render()
        {

        }

        protected override void ShutDown()
        {

        }
    }
}
