using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.Core.Utilities
{
    public class Dice
    {
        public Dice(int quantity, DiceType type)
        {
            Quantity = quantity;
            Type = type;
        }
        public int Quantity { get; set; }
        public DiceType Type { get; set; }

        public RollResult Roll()
        {
            var result = new RollResult();
            for (var i = 0; i < Quantity; i++)
            {
                var roll = new DieRoll
                {
                    Type = Type,
                    Roll = new Random().Next(1, (int) Type)
                };
                result.Rolls.Add(roll);
            }
            result.Roll = result.Rolls.Sum(e=>e.Roll);
            return result;
        }
    }
}
