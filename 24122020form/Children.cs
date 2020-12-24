using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24122020form
{
    public partial class Children : Form
    {
        public String TextMy {
            get => textBox1.Text;
            set => textBox1.Text = value;
        }

        public Student stud
        {
            get;
            set;
        }
        public Children()
        {
            InitializeComponent();
        }
        public Children(string text) : this()
        {
            textBox1.Text = text;
        }
        public DialogResult ShowDialog(string text)
        {
            textBox1.Text = text;
            return ShowDialog();
        }
        private void Children_Load(object sender, EventArgs e)
        {
            //if (Tag != null)
            //{
            //    textBox1.Text = "" + Tag;
            //}
            //  textBox1.Text = "" + Tag;
            textBox1.Text = "" + TextMy;
            if (stud != null) {
                textBox1.Text = stud.Name; 
                textBox2.Text = "" + stud.Avg;
                dateTimePicker1.Value = stud.Bday;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stud = new Student { 
                Name = textBox1.Text, 
                Avg = Double.Parse( textBox2.Text), 
                Bday = dateTimePicker1.Value
            };   
            DialogResult = DialogResult.Yes;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
