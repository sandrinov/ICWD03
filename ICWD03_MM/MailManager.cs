using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICWD03_MM
{

    public delegate void MailArrivedEventHandler(EMail mail);

    public class MailManager
    {
        public event MailArrivedEventHandler MailArrived;

        public void SimulateMailArrived(string from, string to, string obj, string text)
        {
            EMail mail = new EMail() { From=from, Text=text, To=to, Obj=obj };

            if (MailArrived != null)
                MailArrived(mail);
        }
    }
}
