using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFMLGame.Core
{
    public class Player : GameObject
    {
        private float shootInterval = 0.15f;
        private float lastShootTime;

        public bool CanShoot()
        {
            return Time.time > lastShootTime + shootInterval;
        }

        public void Shoot()
        {
            var bullet = Bullet.Instantiate<Bullet>("Assets/bullet.png", Position);
            bullet.Speed = 2;
            bullet.Velocity = new SFML.System.Vector2f(1, 0);

            lastShootTime = Time.time;
        }

        public override void Move(SFML.System.Vector2f velocity)
        {
            Vector2f vel = velocity;

            if(velocity.X > 0 && Position.X >= Program.WINDOW_WIDTH - 150)
            {
                vel.X = 0;
            }

            if (velocity.X < 0 && Position.X < 50)
            {
                vel.X = 0;
            }

            if (velocity.Y > 0 && Position.Y >= Program.WINDOW_HEIGHT - 150)
            {
                vel.Y = 0;
            }

            if (velocity.Y < 0 && Position.Y < 50)
            {
                vel.Y = 0;
            }

            base.Move(vel);
        }
    }
}
