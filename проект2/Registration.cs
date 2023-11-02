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
	public partial class Registration : Form
	{
		readonly ApplicationContext db;
		public Registration()
		{
			 InitializeComponent();
			 db = new ApplicationContext();
		}


		private void Button2_Click(object sender, EventArgs e) // Регистрация пользователя 
		{
			if (textBox1.Text == "" || textBox2.Text == "")
			{
				MessageBox.Show("заполните поля");
			}
			else
			{
				string login = textBox1.Text;
				string pass = textBox2.Text;
				User user = new User(login, pass);
				db.Users.Add(user); //добавление в БД
				db.SaveChanges();	
				PersonalArea newform = new PersonalArea(); //переход в личный кабинет
				newform.Show();
			}
			
		}
	}
}
    
