using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICWD03_MM
{
    public class Fax
    {
        private MailManager mm;
        public Fax(MailManager mailManager)
        {
            mm = mailManager;
            MailArrivedEventHandler md = new MailArrivedEventHandler(Mm_MailArrived);
            mm.MailArrived += md;
        }

        private void Mm_MailArrived(EMail mail)
        {
            Console.WriteLine(mail.From + " " + mail.To);
        }
    }
}
