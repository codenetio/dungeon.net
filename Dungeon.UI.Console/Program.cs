using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Dungeon.Core;
using Dungeon.UI.Console.Views;

namespace Dungeon.UI.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var gameView = new GameView();
            System.Console.SetCursorPosition(0,0);
            System.Console.ReadKey();
            //var consoleGame = new ConsoleGame();
            //consoleGame.Start();
            
        }
    }
}
