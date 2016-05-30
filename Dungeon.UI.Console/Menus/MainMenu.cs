using System;
using System.Collections.Generic;

namespace Dungeon.UI.Console.Menus
{
    public class MainMenu
    {

        private readonly int _consoleWidth;
        private readonly int _consoleHeight;

        public enum Option
        {
            NewGame = 1,
            LoadGame = 2,
            Quit = 3
        }

        private List<string> _mainMenuText = new List<string>
        {
            @"╔════════════════════════════════════════════════════════════════════════════════════════════════╗",
            @"║ ______                                      _   _      _                                       ║",
            @"║ ▓█████▄  █    ██  ███▄    █   ▄████ ▓█████  ▒█████   ███▄    █       ███▄    █ ▓█████▄▄▄█████▓ ║",
            @"║ ▒██▀ ██▌ ██  ▓██▒ ██ ▀█   █  ██▒ ▀█▒▓█   ▀ ▒██▒  ██▒ ██ ▀█   █       ██ ▀█   █ ▓█   ▀▓  ██▒ ▓▒ ║",
            @"║ ░██   █▌▓██  ▒██░▓██  ▀█ ██▒▒██░▄▄▄░▒███   ▒██░  ██▒▓██  ▀█ ██▒     ▓██  ▀█ ██▒▒███  ▒ ▓██░ ▒░ ║",
            @"║ ░▓█▄   ▌▓▓█  ░██░▓██▒  ▐▌██▒░▓█  ██▓▒▓█  ▄ ▒██   ██░▓██▒  ▐▌██▒     ▓██▒  ▐▌██▒▒▓█  ▄░ ▓██▓ ░  ║",
            @"║ ░▒████▓ ▒▒█████▓ ▒██░   ▓██░░▒▓███▀▒░▒████▒░ ████▓▒░▒██░   ▓██░ ██▓ ▒██░   ▓██░░▒████▒ ▒██▒ ░  ║",
            @"║  ▒▒▓  ▒ ░▒▓▒ ▒ ▒ ░ ▒░   ▒ ▒  ░▒   ▒ ░░ ▒░ ░░ ▒░▒░▒░ ░ ▒░   ▒ ▒  ▒▓▒ ░ ▒░   ▒ ▒ ░░ ▒░ ░ ▒ ░░    ║",
            @"║  ░ ▒  ▒ ░░▒░ ░ ░ ░ ░░   ░ ▒░  ░   ░  ░ ░  ░  ░ ▒ ▒░ ░ ░░   ░ ▒░ ░▒  ░ ░░   ░ ▒░ ░ ░  ░   ░     ║",
            @"║  ░ ░  ░  ░░░ ░ ░    ░   ░ ░ ░ ░   ░    ░   ░ ░ ░ ▒     ░   ░ ░  ░      ░   ░ ░    ░    ░       ║",
            @"║    ░       ░              ░       ░    ░  ░    ░ ░           ░   ░           ░    ░  ░         ║",
            @"║  ░                                                               ░                             ║",
            @"║                                                                                                ║",
            @"╚════════════════════════════════════════════════════════════════════════════════════════════════╝",
            @"                                                                                                  ",
            @"                                     ╔══════════════════╗                                         ",
            @"                                     ║ 1. New Game      ║                                         ",
            @"                                     ║ 2. Load Game     ║                                         ",
            @"                                     ║ 3. Quit          ║                                         ",
            @"                                     ╚══════════════════╝                                         ",
            @"                                                                                                  ",
            @"                                       Selection:                                                 "
        };

        public Option Selection { get; set; }


        public MainMenu(int consoleWidth, int consoleHeight)
        {
            _consoleWidth = consoleWidth;
            _consoleHeight = consoleHeight;
        }


        public void Render()
        {
            var selecting = true;
            while (selecting)
            {
                var menuWidth = _mainMenuText[0].Length;
                var menuHeight = _mainMenuText.Count;
                var padLeftAmount = (_consoleWidth - menuWidth)/2 + menuWidth;
                var padTop = (_consoleHeight - menuHeight)/2;

                System.Console.SetCursorPosition(0, padTop);

                foreach (var line in _mainMenuText)
                {
                    System.Console.WriteLine(line.PadLeft(padLeftAmount, ' ').PadRight(_consoleWidth - 1, ' '));
                }

                var inputX = menuWidth/2 + (_consoleWidth - menuWidth)/2 + 1;
                var inputY = menuHeight - 1 + padTop;

                System.Console.SetCursorPosition(inputX, inputY);

                var selection = System.Console.ReadLine();
                switch (selection)
                {
                    case "1":
                    case "2":
                    case "3":
                        Selection = (Option) Enum.Parse(typeof(Option), selection);
                        break;
                    default:
                        continue;
                }

                selecting = false;
            }
        }
    }

    
}
