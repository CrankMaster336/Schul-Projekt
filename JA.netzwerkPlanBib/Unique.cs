using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JA.netzwerkPlanBib
{
    public abstract class Unique
    {
        public Guid guid { get; set; }

        public Unique()
        {
            guid = Guid.NewGuid();
        }
    }
}
