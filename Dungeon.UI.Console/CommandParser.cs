using System;

namespace Dungeon.UI.Console
{
    public class CommandParser
    {

        #region Events

        public event Action Attack;
        public event Action East;
        public event Action Help;
        public event Action North;
        public event Action Run;
        public event Action South;
        public event Action Unknown;
        public event Action West;

        #endregion

        public void Parse(string text)
        {
            switch (text.ToLower())
            {
                case "attack":
                case "a":
                    Attack?.Invoke();
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
