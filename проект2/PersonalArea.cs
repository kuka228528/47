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
    public partial class PersonalArea : Form
    {
        public PersonalArea()
        {
            InitializeComponent();
           //ApplicationContext db = new ApplicationContext(); //обращение к классу
            //List<User> user = db.Users.ToList();
           // dataGridView1.DataSource = user; //подключение БД для отображения в dataGridView1
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CardGenerating newform = new CardGenerating();
            newform.Show();
            Close();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            CardGenerating newform = new CardGenerating();
            newform.Show();
            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Authorization newform = new Authorization();
            newform.Show();
            Close();

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form3 newform = new Form3();
            newform.Show(); Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
			Form3 newform = new Form3();
			newform.Show(); Close();

		}

        private void Button6_Click(object sender, EventArgs e)
        {
            PersonalAreaAdmin newform = new PersonalAreaAdmin();
            newform.Show();
            Close();


        }
        // private void Button2_Click(object sender, EventArgs e)
        //{
        //    // Authorization newform = new Authorization();// переход на форму авторизации
        // newform.Show();
        //  Close();
    }
       // private void Button1_Click(object sender, EventArgs e)
       // {
           // CardGenerating newform = new CardGenerating(); //переход в окно генерации карт
          //  newform.Show();
          //  Close();
        }
   
