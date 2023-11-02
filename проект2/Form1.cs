using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace проект2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text =="" || textBox2.Text=="" )
            { MessageBox.Show("поля заполнены неверно"); }
            if (textBox3.Text == textBox2.Text && textBox1.TextLength == 5)
            {
                PersonalArea newform = new PersonalArea();
                newform.Show();
                Close();
            }

        }
    }
}
