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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            listBox1.Items.Add(new Student { Name = "Ivan", Avg = 10.5, Bday = new DateTime(2001, 12, 10) });
            listBox1.Items.Add(new Student { Name = "Petro", Avg = 6.5, Bday = new DateTime(2005, 05, 20) });
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Children children = new Children();
            children.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Children children = new Children();
            children.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ////V1
            //Children children = new Children();
            //children.textBox1.Text = textBox1.Text;
            //children.ShowDialog();

            ////V2
            //Children children = new Children(textBox1.Text);
            //children.ShowDialog();

            ////V3
            //Children children = new Children();
            //children.ShowDialog(textBox1.Text);

            ////V4
            //Children children = new Children();
            //children.Tag=textBox1.Text;
            //children.ShowDialog();

            //V5
            Children children = new Children();
            children.TextMy = textBox1.Text;
            var ttt = children.ShowDialog();
            if (ttt == DialogResult.Yes)
                textBox1.Text = children.TextMy;
            Text = "" + ttt;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (Children children = new Children())
            {
                children.Text = "Новий студент";
                if (children.ShowDialog() == DialogResult.Yes)
                    listBox1.Items.Add(children.stud);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (Children children = new Children())
            {
                children.Text = "Редагувати студентa";
                int pos = listBox1.SelectedIndex;
                children.stud = listBox1.SelectedItem as Student;
                if (children.ShowDialog() == DialogResult.Yes)
                {
                    listBox1.Items.RemoveAt(pos);
                    listBox1.Items.Insert(pos, children.stud);
                    listBox1.SelectedIndex = pos;
                }
            }
        }
    }
}
