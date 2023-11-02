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
    public partial class Authorization : Form
   {
        public Authorization()
        {
            InitializeComponent();
        }
       private void button1_Click(object sender, EventArgs e) //авторизация пользователя из БД
        {
           string pass = textBox2.Text;
            string login = textBox1.Text;
           if (pass == "" | login == "")
            {
                MessageBox.Show("Заполните поля"); //вывод сообщения при незаполненных полях логина и(или) пароля 
            }
            User authUser = null;
            using (ApplicationContext db = new ApplicationContext()) //использование класса для подключения БД
            {
                authUser = db.Users.Where(b => b.Login == login && b.Pass == pass).FirstOrDefault(); // проверка логина и пароля в БД
            }
            if (authUser != null)
            {
                MessageBox.Show("Успешно");
                PersonalArea newform = new PersonalArea(); // переход в личный кабиинет
                newform.Show();
                Hide();
            }
            Admin authAdmin = null;
            using (ApplicationContext2 db1 = new ApplicationContext2()) //использование клсаа для подключения БД
            {
                authAdmin = db1.Admins.Where(b => b.Login == login && b.Pass == pass).FirstOrDefault(); // проверка пароля и логина в БД
            }
            if (authAdmin != null) //если в БД есть пользователь с введенными данными, то выводится сообщение, что все успешно
            {
                MessageBox.Show("Успешно");
                Form4 newform = new Form4(); //переход в личный кабинет админа
                newform.Show();
                Hide();
            }
        } 
        private void button2_Click(object sender, EventArgs e)// переход в окно регистрации
        { 
           Registration newform = new Registration();
            newform.Show();
            Hide();
        }

        
    }
}