using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace проект2
{
    public partial class PersonalAreaAdmin : Form
    {
        public PersonalAreaAdmin()
        {
            InitializeComponent();
         
           
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            PersonalArea newform = new PersonalArea();// переход на форму авторизации
            newform.Show();
            
            
        }

    }
}