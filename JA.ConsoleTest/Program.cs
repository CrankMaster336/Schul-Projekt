using JA.netzwerkPlanBib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JA.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            netzwerkKomponente komp = new netzwerkKomponente();
            komp.Date = DateTime.Today;
            komp.Gebaude = "Bauhaus";
            komp.Id = 20148;
            komp.Komponente = "Der Gerät";
            komp.Raum = "Iserlohn";
            Console.WriteLine(komp.ToString());
            netzwerkKomponenteList lk = new netzwerkKomponenteList();
            lk.Add(komp);
            netzwerkKomponenteList n = new netzwerkKomponenteList();

            serialisierungsserver s = new xml();
            n.ser(s, )
        }
    }
}
