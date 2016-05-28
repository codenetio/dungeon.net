using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dungeon.Core.Models;

namespace Dungeon.Core
{
    public class Game
    {
        private Player _player;
        private Enemy _enemy;
        private IList<string> _outputBuffer; 

        public void NewGame()
        {
            GameOver = false;
            _outputBuffer = new List<string>();
            _outputBuffer = new List<string> {"You are in a dark room with an enemy facing you."};
        }

        public IList<string> Output
        {
            get
            {
                var result = _outputBuffer.ToList();

                _outputBuffer = new List<string>();
                return result;
            }
            
        }

        public bool GameOver { get; private set; }

        public void AttackEnemy()
        {
            var enemyAttack = new Random().Next(1, 10);
            if (enemyAttack < 8)
            {
                _outputBuffer.Add("The enemy was killed.");
                NewEnemy();
            }
            else
            {
                _outputBuffer.Add("The enemy narrowly evades the attack.");
                AttackPlayer();
            }
        }

        public void Run()
        {
            var run = new Random().Next(1,10);
            if (run < 4)
            {
                _outputBuffer.Add("You narrowly escaped the enemy.");
            }
            else
            {
                _outputBuffer.Add("You were unable to run away.");
                AttackPlayer();
            }
        }

        private void AttackPlayer()
        {
            var playerAttack = new Random().Next(1, 10);
            if (playerAttack < 5)
            {
                _outputBuffer.Add("You were killed by the enemy.");
                GameOver = true;

            }
            else
            {
                _outputBuffer.Add("The enemy attacks, but misses.");
            }
        }

        private void NewEnemy()
        {
            _outputBuffer.Add("Another enemy magically appears.");
        }
    }
}
