using System.ComponentModel;

namespace Dungeon.Core.Models
{
    public class RoomExit
    {
        public Direction Direction { get; set; }
        public ExitType Type { get; set; }
        public bool Visible { get; set; }
    }

    public enum ExitType
    {
        Door
    }

    public enum Direction
    {
        North,
        East,
        South,
        West
    }
}