using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace проект2
{
    public partial class CardGenerating : Form
    {
		readonly ApplicationContext4 db;
		public CardGenerating()
		{
			InitializeComponent();
			db = new ApplicationContext4();
		}
		private void Button1_Click(object sender, EventArgs e) //генерация карты
		{

			if (textBox1.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
			{ MessageBox.Show("заполните поля"); }
			else
			{
                string passportn = textBox3.Text;
				string passports = textBox1.Text;				
                string data = textBox5.Text;
                string rabota = textBox6.Text;
                string name = textBox4.Text;
                Zayavka zayavka = new Zayavka(passportn, passports, data, rabota, name);
                db.Zayavkas.Add(zayavka); //добавление в БД
                db.SaveChanges();
                MessageBox.Show("заявка создана");
				PersonalArea newform = new PersonalArea();
				newform.Show();
				Close();

			}
		}


		private void Button4_Click(object sender, EventArgs e) //переход в личный кабинет
        {
            PersonalArea newarea = new PersonalArea();
            newarea.Show();
            Close();
        }
    }
}