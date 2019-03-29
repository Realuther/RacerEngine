//(C) 2019 Daniel Luther
//Racer Engine Program 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RacerEngine;
using OpenTK;

namespace RacerEnginePro
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Toolkit.Init())
            {
                new TestGame(800, 600, "Game");
            }
        }
    }
}
