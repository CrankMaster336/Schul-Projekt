using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace JA.netzwerkPlanBib
{
    public class netzwerkKomponenteList : List<netzwerkKomponente>
    {
        public void ser(serialisierungsserver s, string pname, netzwerkKomponenteList h)
        {
            try
            {
                s.seriealize(h, pname);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void deser(serialisierungsserver s, string pname)
        {
            try
            {
                netzwerkKomponenteList ergebniss = s.deseriealize(pname);
                this.Clear();
                this.AddRange(ergebniss);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
