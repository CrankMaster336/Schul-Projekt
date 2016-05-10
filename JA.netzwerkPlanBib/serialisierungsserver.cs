using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JA.netzwerkPlanBib
{
    public interface serialisierungsserver
    {
        void seriealize(netzwerkKomponenteList h, string pname);
        netzwerkKomponenteList deseriealize(string pname);
    }
}
