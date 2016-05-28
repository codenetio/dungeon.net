using System;
using Dungeon.Core.Models;
using Dungeon.Core.Utilities;

namespace Dungeon.Core.Enemies
{
    public class Goblin : Enemy
    {
        public Goblin()
        {
            Id = Guid.NewGuid();
            // no name
            Type = EnemyType.Goblin;
            ArmorClass = 12;
            HitPoints = 5;
        }

        /// <summary>
        /// Attacks this instance.
        /// </summary>
        /// <returns>The result of the attack.</returns>
        public override AttackResult Attack()
        {
            var result = new AttackResult();


                if (HitPoints == 0)
                {
                    result.Message = $"The {Type} is already dead.";
                    return result;
                }

                result.ValidAttack = true;

                var hitRoll = DiceRoller.Roll(20);
                if (hitRoll >= ArmorClass)
                {
                    result.DidHit = true;
                    var damage = DiceRoller.Roll(4);
                    result.Damage = damage;
                    HitPoints = Math.Max(HitPoints - damage, 0);
                    if (HitPoints == 0)
                    {
                        result.Killed = true;
                        result.Message = $"The {Type} was hit for {damage} and was killed.";
                    }
                    else
                    {
                        result.Message = $"The {Type} was hit for {damage} but was not killed.";
                    }
                }
                else
                {
                    result.Message = $"The attack missed the {Type}!";
                }
                result.HitRoll = hitRoll;
                result.RemainingHitPoints = HitPoints;
                result.TargetAC = ArmorClass;

            return result;
        }
    }
}
