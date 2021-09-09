using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolWinForm
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();
        private List<Grade> grades = new List<Grade>();


        public Form1()
        {
            InitializeComponent();
            // 1) Inizializzare lista grades
            // 2) Inizializzare lista students

            // 3) Popolare la combo cmb_grades
        }

        private void cmb_grades_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Popolare la Listbox con gli studenti della classe scelta
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            //Usare linq per ordinare la lista in base al campo StudentName
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            // Leggere il campo text di txt_search (StudentName)
            // Usare linq per trovare (oppure no) lo StudentName
            // Visualizzarlo nella label lbl_resultSearch 
        }
    }
}
