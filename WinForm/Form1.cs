using BankLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MyClass mycl = new MyClass(this.button1);
        }

        private void myeventhandler_click(object sender, EventArgs e)
        {
            // crere 3 istanze di Persona e metterle in una lista di Persona
            // assegnarvi i valori delle proprietà nome, cognome e indirizzo (contestualmente
            // alla creazione di ciascuna istanza)
            // inserire ciascuna persona nell'elenco Listbox

            Thread.Sleep(5000);


            List<Person> persons = new List<Person>();

            Person p1 = new Person() { FirstName = "Mario", LastName = "Rossi", Address ="Via di qui 1" };
            Person p2 = new Person() { FirstName = "Maria", LastName = "Verdi", Address = "Via di qui 2" };
            Person p3 = new Person() { FirstName = "Mariotto", LastName = "Gialli", Address = "Via di qui 3" };

            persons.Add(p1);
            persons.Add(p2);
            persons.Add(p3);

            foreach (Person p in persons)
            {
                listBox1.Items.Add(p.FirstName + " " + p.LastName);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.label1.Text = "";
            this.label1.Text = this.listBox1.SelectedItem.ToString();
        }

        private async void StartButton_Click(object sender, EventArgs e)
        {
            var task = AccessTheWebAsync();
            //.......
            int length = await task;
            //label2.Text += "Url Content Length: " + length;

            //int length = await AccessTheWebAsync();
            resultTextBox.Text += "Url Content Length: " + length;
        }
        private async Task<int> AccessTheWebAsync()
        {
            
            HttpClient client = new HttpClient();

            Task<String> getStringTask = client.GetStringAsync("http://neverssl.com/");
            DoIndipendentWork();

            string urlContent = await getStringTask;
            return urlContent.Length;
        }
        private void DoIndipendentWork()
        {
            //resultTextBox.Text += "Working ....\r\n";

            for (int i = 0; i < 10; i++)
            {
                resultTextBox.Text += "Working ...." + "i" + "\r\n";
            }
        }
    }
}
