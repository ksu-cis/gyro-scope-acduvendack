using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyroScope.Data.Entrees
{
    public abstract class Entree
    {
        public abstract decimal Price { get; }

        public abstract uint Calories { get; }

        public abstract IEnumerable<string> SpecialInstructions { get; }
    }
}
