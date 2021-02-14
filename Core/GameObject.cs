using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SFMLGame.Core
{
    public class GameObject : Drawable
    {
        public uint Id { get; set; }
        public float Speed { get; set; } = 1;
        public Sprite Sprite { get; private set; }
        public Vector2f Position
        {
            get
            {
                return Sprite.Position;
            }
            set
            {
                Sprite.Position = value;
            }
        }

        public static void Destroy(GameObject go)
        {
            GameManager.Remove(go);
        }

        public void SetTexture(Texture t)
        {
            Sprite = new Sprite(t);
        }

        public void Draw(RenderTarget target, RenderStates states)
        {
            Sprite.Draw(target, states);
        }

        public virtual void Update()
        {

        }

        public virtual void Move(Vector2f velocity)
        {
            Position += velocity;
        }

        public static T Instantiate<T>(string texturePath, Vector2f pos) where T : GameObject, new()
        {
            T g = new T();
            g.SetTexture(new Texture(texturePath));
            g.Position = pos;
            g.Sprite.Position = pos;

            GameManager.AddGameObject(g);
            return g;
        }

        public static T Instantiate<T>(Texture texture, Vector2f pos) where T : GameObject, new()
        {
            T g = new T();
            g.SetTexture(texture);
            g.Position = pos;
            g.Sprite.Position = pos;

            GameManager.AddGameObject(g);
            return g;
        }
    }
}
