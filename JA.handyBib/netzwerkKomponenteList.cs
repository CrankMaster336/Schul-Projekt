using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JA.netzwerkPlanBib
{
    [Serializable()]
    public class netzwerkKomponenteList : List<netzwerkKomponente>
    {

        //private serialisierungsserver s = null;
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





















        /*public double getKapital()
        {
            double kapital = 0.0;

            foreach (Handy prime in this)
            {
                kapital = kapital + prime.Preis;
            }
            return kapital;
        }

        public HandyList getBrand(String brand)
        {
            HandyList List2 = new HandyList();
            foreach (Handy prime in this)
            {
                if (prime.Hersteller == brand)
                {
                    List2.Add(prime);
                }
            }
            if (!List2.Any())
            {
                return null;
            }

            return List2;
        }

        public HandyList getCheapest()
        {
            HandyList List3 = new HandyList();

            double lowestPrice = 100000000000000000;

            foreach (Handy prime in this)
            {
                if (prime.Preis < lowestPrice)
                {
                    lowestPrice = prime.Preis;
                }
            }
            foreach (Handy prime in this)
            {
                if (prime.Preis == lowestPrice)
                {
                    List3.Add(prime);
                }
            }

            return List3;
        }*/
    }
}
