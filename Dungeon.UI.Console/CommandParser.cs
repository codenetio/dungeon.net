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
                    Attack?.Invoke();
                    break;
                case "east":
                    East?.Invoke();
                    break;
                case "help":
                    Help?.Invoke();
                    break;
                case "north":
                    North?.Invoke();
                    break;
                case "run":
                    Run?.Invoke();
                    break;
                case "south":
                    South?.Invoke();
                    break;
                case "west":
                    West?.Invoke();
                    break;
                default:
                    Unknown?.Invoke();
                    break;

            }
        }
    }
}
