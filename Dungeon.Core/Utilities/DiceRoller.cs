using System;

namespace Dungeon.Core.Utilities
{
    public static class DiceRoller
    {
        public static int Roll(int quantity, DiceType type)
        {
            return new Random().Next(1,(int)type);
        }
    }
}
