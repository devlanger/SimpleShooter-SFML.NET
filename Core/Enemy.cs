using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFMLGame.Core
{
    public class Enemy : GameObject
    {
        public int health = 100;

        public void DealDamage(int dmg)
        {
            health -= dmg;
            if(health <= 0)
            {
                GameObject.Destroy(this);
            }
        }
    }
}
