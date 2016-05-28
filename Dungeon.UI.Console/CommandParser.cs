using System;

namespace Dungeon.UI.Console
{
    public class CommandParser
    {

        public delegate void AttackDelegate(int targetIndex);

        #region Events

        public event AttackDelegate Attack;
        public event Action East;
        public event Action Help;
        public event Action North;
        public event Action Run;
        public event Action South;
        public event Action Unknown;
        public event Action West;

        #endregion

        public void Parse(string command)
        {
            var commands = command.Split(' ');

            switch (commands[0].ToLower())
            {
                case "attack":
                case "a":
                    var target = 0;
                    if (commands.Length > 0)
                    {
                        if (!int.TryParse(commands[1], out target))
                        {
                            Unknown?.Invoke();
                            return;
                        }
                    }
                    Attack?.Invoke(target);
                    break;
                case "east":
                case "e":
                    East?.Invoke();
                    break;
                case "help":
                    Help?.Invoke();
                    break;
                case "north":
                case "n":
                    North?.Invoke();
                    break;
                case "run":
                    Run?.Invoke();
                    break;
                case "south":
                case "s":
                    South?.Invoke();
                    break;
                case "west":
                case "w":
                    West?.Invoke();
                    break;
                default:
                    Unknown?.Invoke();
                    break;

            }
        }
    }
}
