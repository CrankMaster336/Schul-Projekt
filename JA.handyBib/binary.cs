using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace JA.netzwerkPlanBib
{
    public class binary : serialisierungsserver
    {
        public void seriealize(netzwerkKomponenteList h, string pname)
        {
            FileStream stream = new FileStream(@pname, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter formatter = new BinaryFormatter();
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
            BinaryFormatter formatter = new BinaryFormatter();
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
