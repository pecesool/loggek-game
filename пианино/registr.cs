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

namespace пианино
{
    public partial class registr : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = loggek.mdb";
        private OleDbConnection myConnection;
        public registr()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string pas = textBox4.Text;
            if (pas.Length < 7) { progressBar1.Value = 0; } else { progressBar1.Value = 25; }
            for (int i = 0; i < pas.Length; i++) { if (pas[i] >= 'A' && pas[i] <= 'z') { progressBar1.Value += 25; break; } }
            for (int i = 0; i < pas.Length; i++) { if (pas[i] >= '0' && pas[i] <= '9') { progressBar1.Value += 25; break; } }
            for (int i = 0; i < pas.Length; i++) { if (pas[i] >= '!' && pas[i] <= '/') { progressBar1.Value += 25; break; } }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string log = textBox1.Text;
            string pas = textBox4.Text;
            string query = "SELECT COUNT(*) FROM регистрация WHERE login='" + log + "'";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            int asd = Convert.ToInt32(command.ExecuteScalar());
            int smth = 0;
            if (asd == 1) { smth += 1; }
            string vozr = textBox5.Text;
            string name = textBox2.Text;
            string surn = textBox3.Text;

            if (name == "") { smth += 1; }
            if (surn == "") { smth += 1; }
            if (progressBar1.Value < 100) { smth += 1; }
            if (vozr == "") { smth += 1; }
            if (radioButton1.Checked == false && radioButton2.Checked == false) { smth += 1; }
            if (smth == 0)
            {
                for (int i = 0; i < log.Length; i++) { if (log[i] >= 'A' && log[i] <= 'z') { smth += 1; } }
                for (int i = 0; i < vozr.Length; i++) { if (vozr[i] >= '0' && vozr[i] <= '9') { smth += 1; } }
                for (int i = 0; i < name.Length; i++) { if ((name[i] >= 'A' && name[i] <= 'z') || (name[i] >= 'А' && name[i] <= 'я')) { smth += 1; } }
                for (int i = 0; i < surn.Length; i++) { if ((surn[i] >= 'A' && surn[i] <= 'z') || (surn[i] >= 'А' && surn[i] <= 'я')) { smth += 1; } }
                if (smth < vozr.Length + name.Length + surn.Length + log.Length) {textBox2.Text = ""; textBox3.Text = ""; textBox5.Text = ""; textBox1.Text = ""; }
                else
                {
                    string mf = "FALSE";
                    if (radioButton1.Checked == true)
                    { mf = "TRUE"; }
                    string query1 = "INSERT INTO регистрация ([login], [name1], [name2], [gender], [years], [password]) VALUES ('" + log + "', '" + name + "', '" + surn + "', " + mf + ", " + vozr + ", '" + pas + "')";
                    OleDbCommand command1 = new OleDbCommand(query1, myConnection);
                    command1.ExecuteNonQuery();
                    password = pas;
                    Form1.loh = log;

                    List<String> names = new List<String>();
                    OleDbCommand cmd = new OleDbCommand("SELECT login FROM регистрация", myConnection);
                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read()) { if (names.Contains(reader.GetString(0))) { continue; } names.Add(reader.GetString(0)); }

                    
                   this.Close();
                }
            }
        }
        static public string password;

        private void registr_Load(object sender, EventArgs e)
        {
            if (Data.Lang == "eng") { label1.Text = "name"; label2.Text = "surname"; label3.Text = "age"; label4.Text = "login"; label5.Text = "password"; radioButton1.Text = "man"; radioButton2.Text = "woman"; button1.Text = "register"; button2.Text = "promt"; }
            if (Data.Lang == "rus") { label1.Text = "имя"; label2.Text = "фамилия"; label3.Text = "возраст"; label4.Text = "логин"; label5.Text = "пароль"; radioButton1.Text = "мужчина"; radioButton2.Text = "женщина"; button1.Text = "зарегистрировать"; button2.Text = "подсказка"; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Data.Lang == "rus") { MessageBox.Show("Логин должен быть уникальным и содержать только латинские буквы.\nПароль должен содержать 8 символов, 1 букву, 1 цифру и 1 знак.", "Подсказка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else { MessageBox.Show("The login must be unique and contain only Latin letters. \nPassword must contain 8 characters, 1 letter, 1 number and 1 character.", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
