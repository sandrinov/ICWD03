using BankLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // crere 3 istanze di Persona e metterle in una lista di Persona
            // assegnarvi i valori delle proprietà nome, cognome e indirizzo (contestualmente
            // alla creazione di ciascuna istanza)
            // inserire ciascuna persona nell'elenco Listbox

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
    }
}
