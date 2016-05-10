using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JA.netzwerkPlanBib
{
    public class netzwerkKomponenteList : List<netzwerkKomponente>
    {
        public void ser(serialisierungsserver s, string pname, netzwerkKomponenteList h)
        {
            s.seriealize(h, pname);
        }
        public void deser(serialisierungsserver s, string pname)
        {
            netzwerkKomponenteList ergebniss = s.deseriealize(pname);
            this.Clear();
            this.AddRange(ergebniss);
        }
    }
}
