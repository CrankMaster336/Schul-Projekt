using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JA.netzwerkPlanBib
{
    public class netzwerkKomponente : Unique{
        
        
        public int Id { get; set; }
        public string Komponente { get; set; }
        public string Gebaude { get; set; }
        public string Raum { get; set; }
        public string Date { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ID: " + this.Id.ToString());
            sb.AppendLine("Komponente: " + this.Komponente);
            sb.AppendLine("Gebaude: " + this.Gebaude);
            sb.AppendLine("Raum: " + this.Raum.ToString());
            sb.AppendLine("Date: " + this.Date.ToString());
            return sb.ToString();
        }        
    }
}
