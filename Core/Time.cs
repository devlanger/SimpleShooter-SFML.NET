using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFMLGame.Core
{
    public class Time
    {
        public static float time
        {
            get
            {
                return (float)Environment.TickCount / 1000f;
            }
        }

        public static float DeltaTime
        {
            get
            {
                return 1000f / 30f;
            }
        }
    }
}
