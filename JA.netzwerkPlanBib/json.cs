using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Json;

namespace JA.netzwerkPlanBib
{
    public class json : serialisierungsserver
    {
        public void seriealize(netzwerkKomponenteList h, string pname)
        {
            FileStream stream = new FileStream(@pname, FileMode.Create, FileAccess.ReadWrite);
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(netzwerkKomponenteList));
            if (stream.Length == 0)
            {
                ser.WriteObject(stream, h);
            }
            stream.Close();
        }
        public netzwerkKomponenteList deseriealize(string pname)
        {
            FileStream stream = new FileStream(@pname, FileMode.OpenOrCreate, FileAccess.Read);
            DataContractJsonSerializer deser = new DataContractJsonSerializer(typeof(netzwerkKomponenteList));
            netzwerkKomponenteList l = new netzwerkKomponenteList();
            if (stream.Length != 0)
            {
                l = (netzwerkKomponenteList)deser.ReadObject(stream);
            }
            stream.Close();
            return l;

        }
    }
}
