using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
using SFMLGame.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SFMLGame
{
    class Program
    {
        public const int WINDOW_WIDTH = 1600;
        public const int WINDOW_HEIGHT = 900;

        static void Main(string[] args)
        {
            RenderWindow window = new RenderWindow(new VideoMode(WINDOW_WIDTH, WINDOW_HEIGHT), "SFML Space Shooter");

            GameManager manager = new GameManager(window);

            PlayerController playerController = new PlayerController();
            EnemiesController enemiesController = new EnemiesController();

            while (window.IsOpen)
            {
                window.Clear();
                playerController.Update();

                foreach (var item in GameManager.GameObjects.ToList())
                {
                    item.Update();
                    UpdatePhysics(item);

                    item.Sprite.Position = item.Position;
                    item.Draw(window, RenderStates.Default);
                }

                window.Display();
                Thread.Sleep(30);
            }
        }

        private static void UpdatePhysics(GameObject item)
        {
            if (item is ICollisionSignal2D)
            {
                foreach (var col in GameManager.GameObjects.ToList())
                {
                    if (Vector2.Distance(new Vector2(item.Position.X, item.Position.Y), new Vector2(col.Position.X, col.Position.Y)) < 50)
                    {
                        if (item != null && col != null)
                        {
                            ((ICollisionSignal2D)item).OnCollision2D(col);
                        }
                    }
                }
            }
        }
    }
}
