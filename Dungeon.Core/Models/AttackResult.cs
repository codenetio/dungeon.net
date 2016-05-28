using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.Core.Models
{
    public class AttackResult
    {
        public bool DidHit { get; set; }
        public int HitRoll { get; set; }
        public int TargetAC { get; set; }
        public int Damage { get; set; }
        public int RemainingHitPoints { get; set; }
        public bool Killed { get; set; }
        public string Message { get; set; }
        public bool ValidAttack { get; set; }
    }
}
