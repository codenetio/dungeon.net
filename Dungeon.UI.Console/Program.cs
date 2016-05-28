using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Dungeon.Core;

namespace Dungeon.UI.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var consoleGame = new ConsoleGame();
            consoleGame.Start();
            System.Console.SetWindowSize(100,50);
        }
    }
}
