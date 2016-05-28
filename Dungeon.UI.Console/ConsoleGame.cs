using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dungeon.Core;

namespace Dungeon.UI.Console
{
    public class ConsoleGame
    {
        private Game _game;
        private bool _playing;
        private IList<string> _gameText;  

        public ConsoleGame()
        {
            _game = new Game();
            _gameText = new List<string>();
        }

        public void Start()
        {
            _game = new Game();
            _game.NewGame();

            _playing = true;
            foreach (var line in _game.Output)
            {
                _gameText.Add(line);
            }

            RenderBackground();
            RenderText();
            SetCursorForInput();

            while (_playing)
            {
                
                var input = System.Console.ReadLine();
                ClearInput();
                switch (input?.ToLower())
                {
                    case "attack":
                        _game.AttackEnemy();
                        _playing = !_game.GameOver;
                        break;
                    case "run":
                        _game.Run();
                        _playing = !_game.GameOver;
                        break;
                    case "q":
                        _gameText.Add("Goodbye!");
                        _playing = false;
                        break;
                    default:
                        _gameText.Add("I don't understand.");
                        break;
                }

                foreach (var line in _game.Output)
                {
                    _gameText.Add(line);
                }

                RenderText();
                SetCursorForInput();
            }
            
            System.Console.ReadKey();
        }

        private void SetCursorForInput()
        {

            System.Console.SetCursorPosition(0, 0); // reset the screen
            System.Console.SetCursorPosition(1, System.Console.WindowHeight - 2); // set the cursor for user input
        }

        private void RenderBackground()
        {
            var height = System.Console.WindowHeight;
            var width = System.Console.WindowWidth;
            System.Console.SetCursorPosition(0,0);
            var background = new StringBuilder();
            for (var i = 0; i < height; i++)
            {
                if (i == 0)
                {
                    background.Append('╔');
                    background.Append('═', width - 2);
                    background.Append('╗');
                }
                else if (i == height - 3)
                {
                    background.Append('╟');
                    background.Append('─', width - 2);
                    background.Append('╢');
                }
                else if (i == height - 1)
                {
                    background.Append('╚');
                    background.Append('═', width - 2);
                    background.Append('╝');
                }
                else
                {
                    background.Append('║');
                    background.Append(' ', width - 2);
                    background.Append('║');
                }

            }
            System.Console.Write(background);
        }

        private void RenderText()
        {
            var height = System.Console.WindowHeight;
            var width = System.Console.WindowWidth;

            var numberOfLines = height - 5;
            var lineWidth = width - 2;
            System.Console.SetCursorPosition(1, 1);

            var index = 0;
            if (_gameText?.Count > numberOfLines)
            {
                index = (_gameText.Count - 1) - numberOfLines;
            }

            var textArea = new StringBuilder();

            for (var i = 1; i < height - 3; i++)
            {
                System.Console.SetCursorPosition(1,i);

                if (index < _gameText?.Count)
                {
                    var text = _gameText[index].PadRight(lineWidth, ' ');
                    System.Console.Write(text);
                }
                else
                {
                    var text = string.Empty;
                    for (var j = 0; j < lineWidth; j ++)
                    {
                        text += " ";
                    }
                    System.Console.Write(text);
                }
                index++;
            }
            System.Console.Write(textArea);
        }

        private void ClearInput()
        {
            System.Console.SetCursorPosition(1,System.Console.WindowHeight - 2);
            var text = string.Empty;
            for (var i = 0; i < System.Console.WindowWidth - 2; i++)
            {
                text += " ";
            }
            System.Console.Write(text);
            SetCursorForInput();
        }
    }
}
