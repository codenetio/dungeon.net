using System;

namespace Dungeon.Core.Utilities
{
    public static class DiceRoller
    {
        public static int Roll(int numberOfSides)
        {
            return new Random().Next(1,numberOfSides);
        }
    }
}
