using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dungeon.Core.Entities;
using Dungeon.Core.Models;
using Dungeon.Core.Utilities;

namespace Dungeon.Core
{
    public class Game
    {
        private Player.Player _player;
        private Room _room;

        public void NewGame()
        {
            _room = RoomGenerator.CreateRoom(1);
            _player = new Player.Player
            {
                Id = Guid.NewGuid(),
                HitPoints = 5,
                Location = _room.Location,
                Name = "Player",
                ArmorClass = 14
            };
        }

        public Player.Player GetPlayer()
        {
            return _player;
        }

        public Room GetRoom(Location location)
        {
            return _room;
        }

        public AttackResult AttackEnemy(Guid id)
        {
            var enemy = _room.Enemies.FirstOrDefault(e => e.Id == id);
            var attackableEnemy = enemy as IAttackable;
            if (attackableEnemy == null)
            {
                return new AttackResult
                {
                    ValidAttack = false,
                    Message = "The enemy targeted is not attackable."
                };
            }

            var attackAttempt = new AttackAttempt
            {
                HitRoll = DiceRoller.Roll(1,DiceType.d20)
            };
            return attackableEnemy.Attack(attackAttempt);
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
