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
            //Inizializzare lista grades
            //Inizializzare lista students
        }
    }
}
