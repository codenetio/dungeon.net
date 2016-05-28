using Dungeon.Core.Models;

namespace Dungeon.Core.Entities
{
    public interface IAttackable
    {
        AttackResult Attack(AttackAttempt attackAttempt);
    }

    public class AttackAttempt
    {
        public int HitRoll { get; set; }
        public int AttackModifier { get; set; }
        
    }
}
