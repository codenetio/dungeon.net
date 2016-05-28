using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dungeon.Core.Models;
using Dungeon.Core.Utilities;

namespace Dungeon.Core
{
    public class Game
    {
        private Player _player;
        private Room _room;

        public void NewGame()
        {
            _room = RoomGenerator.CreateRoom(1);
            _player = new Player
            {
                Id = Guid.NewGuid(),
                HitPoints = 5,
                Location = _room.Location,
                Name = "Player",
                ArmorClass = 14
            };
        }

        public Player GetPlayer()
        {
            return _player;
        }

        public Room GetRoom(Location location)
        {
            return _room;
        }

        public AttackResult AttackEnemy(Guid id)
        {
            var result = new AttackResult();

            var enemy = _room.Enemies.FirstOrDefault(e => e.Id == id);
            if (enemy != null)
            {
                if (enemy.HitPoints == 0)
                {
                    result.Message = $"The {enemy.Type} is already dead.";
                    return result;
                }

                result.ValidAttack = true;

                var hitRoll = DiceRoller.Roll(20);
                if (hitRoll >= enemy.ArmorClass)
                {
                    result.DidHit = true;
                    var damage = DiceRoller.Roll(4);
                    result.Damage = damage;
                    enemy.HitPoints = Math.Max(enemy.HitPoints - damage, 0);
                    if (enemy.HitPoints == 0)
                    {
                        result.Killed = true;
                        result.Message = $"The {enemy.Type} was hit for {damage} and was killed.";
                    }
                    else
                    {
                        result.Message = $"The {enemy.Type} was hit for {damage} but was not killed.";
                    }
                }
                else
                {
                    result.Message = $"The attack missed the {enemy.Type}!";
                }
                result.HitRoll = hitRoll;
                result.RemainingHitPoints = enemy.HitPoints;
                result.TargetAC = enemy.ArmorClass;
            }

            
            return result;
        }

        public void Run()
        {
            
        }

        private void AttackPlayer()
        {
            
        }

        private void NewEnemy()
        {
            
        }
    }
}
