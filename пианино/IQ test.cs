using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace пианино//окно третьей мини-игры
{
    public partial class IQ_test : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = loggek.mdb";
        private OleDbConnection myConnection;
        public IQ_test()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();

        }
        Random rand = new Random();
        private void IQ_test_Load(object sender, EventArgs e)
        {
            // Перевод странички и Получение рандомного числа от 1 до 100
            if (Data.Lang == "rus") { label1.Text = "Угадай число за 7 попыток от 1 до 100"; label2.Text = "Осталось попыток:"; label4.Text = "Догадка:"; label5.Text = "Сдаться"; label6.Text = "Проверить"; }
            label7.Text = Convert.ToString(rand.Next(1, 101));
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Сдаться, не доиграв до конца вернуться в меню игр
            Game1 game = new Game1(); game.Show(); Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (maskedTextBox2.Text != "") // Проверка наличия текста в textBox'е
            {
                if (label3.Text == "1") // Последняя попытка
                {
                    if (maskedTextBox2.Text == label7.Text)
                    { label8.Text = "=";
                        ga.IQ = 7 - Convert.ToInt32(label3.Text);
                        string query2 = "INSERT INTO IQ ([login], [IQ]) VALUES ('" + login.Login + "', " + ga.IQ + ")";
                        OleDbCommand command2 = new OleDbCommand(query2, myConnection);
                        command2.ExecuteNonQuery();
                        if (Data.Lang == "rus")
                        {
                            label8.Text = "Победа";
                        }
                        else
                        { label8.Text = "You win"; }
                            timer1.Enabled = true; } //Пользователь угадал
                    else
                    {
                        label2.Visible = false; label3.Visible = false; label8.Visible = false; label6.Visible = false; maskedTextBox2.Text = label7.Text;
                        // Показ правильного ответа
                        if (Data.Lang == "rus")
                        { label4.Text = "Ответ:"; label8.Text = "Победа"; }
                        else { label4.Text = "My guess:"; label8.Text = "You win"; }
                    }
                }

                else // если еще остались попытки
                {
                    label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) - 1);
                   // уменьшение кол-во попыток
                   
                    if (maskedTextBox2.Text == label7.Text) // Угадал
                    {
                        label8.Text = "=";
                        ga.IQ = 7-Convert.ToInt32(label3.Text);
                        string query2 = "INSERT INTO IQ ([login], [IQ]) VALUES ('" + login.Login + "', " + ga.IQ + ")";
                        OleDbCommand command2 = new OleDbCommand(query2, myConnection);
                        command2.ExecuteNonQuery();
                        timer1.Enabled = true;
                        if (Data.Lang == "rus")
                        { label8.Text = "Победа"; }
                        else { label8.Text = "You win"; }
                    }
                    else // не угадал
                    {
                        int a = Convert.ToInt32(label7.Text);
                        int b = Convert.ToInt32(maskedTextBox2.Text);
                        if (a < b)
                        { label8.Text = "<"; }
                        else { label8.Text = ">"; }
                    }
                    maskedTextBox2.Text = "";
                }
            }
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false; Data.startri = true; Game1 game = new Game1(); game.Show(); Hide();
            
        }

       
    }
}
