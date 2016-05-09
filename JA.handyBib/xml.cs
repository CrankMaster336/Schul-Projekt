using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace JA.netzwerkPlanBib
{
    public class xml : serialisierungsserver
    {
        public void seriealize(netzwerkKomponenteList h, string pname)
        {
            FileStream stream = new FileStream(@pname, FileMode.Create, FileAccess.ReadWrite);
            XmlSerializer formatter = new XmlSerializer(typeof(netzwerkKomponenteList));
            if (stream.Length != 0)
            {
                //textBlockOutput.Text = "Datei existiert und wurde \nüberschreiben";
            }
            else
            {
                formatter.Serialize(stream, h);
                //textBlockOutput.Text = "Datei Gespeichert.";
            }
            stream.Close();
        }
        public netzwerkKomponenteList deseriealize(string pname)
        {
            FileStream stream = new FileStream(@pname, FileMode.OpenOrCreate, FileAccess.Read);
            XmlSerializer formatter = new XmlSerializer(typeof(netzwerkKomponenteList));
            netzwerkKomponenteList l = new netzwerkKomponenteList();
            if (stream.Length != 0)
            {
                l = (netzwerkKomponenteList)formatter.Deserialize(stream);
            }
            stream.Close();
            return l;
        }
    }
}
