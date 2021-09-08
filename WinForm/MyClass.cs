using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public class MyClass
    {
        private Button btn;

        public MyClass(Button button)
        {
            this.btn = button;
            System.EventHandler mcDelegate = new System.EventHandler(this.mc_eventhandler_click);
            btn.Click += mcDelegate;
        }

        private void mc_eventhandler_click(object sender, EventArgs e)
        {
            MessageBox.Show("Event clickc handled by MyClass");
        }
    }
}
