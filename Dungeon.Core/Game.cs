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
            var enemy = _room.Enemies.FirstOrDefault(e => e.Id == id);
            return enemy?.Attack();
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
