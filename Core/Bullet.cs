using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFMLGame.Core
{
    public class Bullet : GameObject, ICollisionSignal2D
    {
        public Vector2f Velocity { get; set; }

        public void OnCollision2D(GameObject other)
        {
            if(other is Enemy)
            {
                ((Enemy)other).DealDamage(25);
                GameObject.Destroy(this);
            }
        }

        public override void Update()
        {
            Position += Velocity * Speed * Time.DeltaTime;
        }
    }
}
