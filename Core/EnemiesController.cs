using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFMLGame.Core
{
    public class EnemiesController
    {
        public List<Enemy> enemies = new List<Enemy>();

        public EnemiesController()
        {
            InitializeEnemies();
        }

        private void InitializeEnemies()
        {
            Enemy e1 = GameObject.Instantiate<Enemy>("Assets/enemy.png", new SFML.System.Vector2f(1400, 100));
            Enemy e2 = GameObject.Instantiate<Enemy>("Assets/enemy.png", new SFML.System.Vector2f(1400, 360));
            Enemy e3 = GameObject.Instantiate<Enemy>("Assets/enemy.png", new SFML.System.Vector2f(1400, 600));
        }
    }
}
