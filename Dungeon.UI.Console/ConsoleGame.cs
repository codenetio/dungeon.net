using System.Collections.Generic;
using System.Text;
using Dungeon.Core;
using Dungeon.Core.Models;

namespace Dungeon.UI.Console
{
    public class ConsoleGame
    {
        private Game _game;
        private bool _playing;
        private GameLog _gameLog;
        private CommandParser _commandParser;

        public ConsoleGame()
        {
            _game = new Game();
            _gameLog = new GameLog(1,1,System.Console.WindowWidth - 2, System.Console.WindowHeight - 6);
            _commandParser = new CommandParser();

            _commandParser.Attack += Attack; ;
            _commandParser.Run += _game.Run;
        }

        private void Attack()
        {
            var player = _game.GetPlayer();
            var room = _game.GetRoom(player.Location);
            var result = _game.AttackEnemy(room.Enemies[0].Id);
            _gameLog.Write(result.Message);
            if (result.ValidAttack)
            {
                var rollInfo = $"ROLL: {result.HitRoll} AC: {result.TargetAC}";
                if (result.DidHit)
                {
                    rollInfo += $" | DMG: {result.Damage} | HP: {result.RemainingHitPoints}";
                }
                _gameLog.Write(rollInfo);
            }
        }

        public void Start()
        {
            _game = new Game();
            _game.NewGame();

            _playing = true;
            var player = _game.GetPlayer();
            var room = _game.GetRoom(player.Location);

            _gameLog.WriteToBuffer(room.Description());

            RenderBackground();
            _gameLog.Render();
            SetCursorForInput();

            while (_playing)
            {
                
                var input = System.Console.ReadLine();
                ClearInput();
                
                _commandParser.Parse(input);
                
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
