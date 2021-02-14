using SFML.System;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFMLGame.Core
{
    public class PlayerController
    {
        public Player player;

        public PlayerController()
        {
            InitializePlayer();
        }

        private void InitializePlayer()
        {
            Player go = Player.Instantiate<Player>("Assets/player.png", new SFML.System.Vector2f(100, 100));
            this.player = go;

            player.Speed = 0.5f;
        }

        public void Update()
        {
            Vector2f dir = new Vector2f();

            if(Keyboard.IsKeyPressed(Keyboard.Key.W))
            {
                dir.Y = -1;
            }

            if (Keyboard.IsKeyPressed(Keyboard.Key.S))
            {
                dir.Y = 1;
            }

            if (Keyboard.IsKeyPressed(Keyboard.Key.A))
            {
                dir.X = -1;
            }

            if (Keyboard.IsKeyPressed(Keyboard.Key.D))
            {
                dir.X = 1;
            }

            if (Keyboard.IsKeyPressed(Keyboard.Key.Space) && player.CanShoot())
            {
                player.Shoot();
            }

            player.Move(dir * player.Speed * Time.DeltaTime);
        }
    }
}
