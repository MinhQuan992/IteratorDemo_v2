using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_v2
{
    abstract class Iterator
    {
        public abstract Student First();
        public abstract Student Next();
        public abstract bool IsDone();
        public abstract Student CurrentItem();
    }
}
