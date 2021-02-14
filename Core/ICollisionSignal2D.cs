using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFMLGame.Core
{
    public interface ICollisionSignal2D
    {
        void OnCollision2D(GameObject other);
    }
}
