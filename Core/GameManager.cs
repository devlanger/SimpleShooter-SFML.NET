using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFMLGame.Core
{
    public class GameManager
    {
        public static List<GameObject> GameObjects = new List<GameObject>();
        public static RenderWindow Window { get; private set; }
        private static uint lastGameObjectId { get; set; } = 1;

        public GameManager(RenderWindow w)
        {
            Window = w;
        }

        public static void AddGameObject(GameObject g)
        {
            g.Id = lastGameObjectId++;
            GameObjects.Add(g);
        }

        public static void Remove(GameObject go)
        {
            GameObjects.Remove(go);
        }
    }
}
