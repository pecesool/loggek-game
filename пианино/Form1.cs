using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using WMPLib;
using System.Data.OleDb;

namespace пианино//окно авторизации, пользователь должен ввести логин и пароль
{
    
    public partial class Form1 : Form
    {
       
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=loggek.mdb";
        private OleDbConnection myConnection;
        
        

        public Form1()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            textBox2.PasswordChar = '*';
            this.ShowInTaskbar = false;
            

        }
        public WMPLib.WindowsMediaPlayer wmp = new WindowsMediaPlayer();
        static public string loh;
        private void OnFrameChanged(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke((Action)(() => OnFrameChanged(sender, e)));
                return;
            }
            ImageAnimator.UpdateFrames();
            Invalidate(false);
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
           string log = textBox1.Text;
            string pas = textBox2.Text;
            string query = "SELECT COUNT(*) FROM регистрация WHERE login='" + log + "' AND password='" + pas + "'";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            int asd = Convert.ToInt32(command.ExecuteScalar());
            if (asd == 1)
            {

                Form2 s = new Form2();
                s.Show();
                Hide();
                login.Login= textBox1.Text;
                
             
            }
            else
            {
                if (Data.Lang == "rus") { MessageBox.Show("Неправильный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else { MessageBox.Show("Incorrect login or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                textBox1.Text = "";
                textBox2.Text = "";
            }

            one.Enabled = true;
            wmp.URL = @"last.mp3";
            wmp.controls.play();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "rus";
            ToolTip toolTip1 = new ToolTip();
            
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            
            toolTip1.ShowAlways = true;

            
            toolTip1.SetToolTip(this.textBox1, "Введите логин");
            toolTip1.SetToolTip(this.textBox2, "Введите пароль");
            toolTip1.SetToolTip(this.button1, "Нажмите для входа");
            toolTip1.SetToolTip(this.button2, "Нажмите для выхода");
        }

        private void one_Tick(object sender, EventArgs e)
        {
            one.Enabled = false;
            two.Enabled = true;
            wmp.URL = @"ralling.mp3";
            wmp.controls.play();
        }

        private void two_Tick(object sender, EventArgs e)
        {
            two.Enabled = false;
            one.Enabled = true;
            wmp.URL = @"last.mp3";
            wmp.controls.play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {     if (Data.Music == false) { wmp.settings.volume = Data.Volume; } else { wmp.settings.volume = 0; }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "eng") { Data.Lang = "eng"; } else { Data.Lang = "rus"; }
            if (Data.Lang == "eng") { label1.Text = "login"; label2.Text = "password"; label3.Text = "Enter login and password"; button1.Text = "enter"; button2.Text = "exit"; button3.Text = "register oneself"; }
            if (Data.Lang == "rus") { label1.Text = "логин"; label2.Text = "пароль"; label3.Text = " Введите логин и пароль"; button1.Text = "вход"; button2.Text = "выход"; button3.Text = "зарегистрироваться"; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            registr registr = new registr();
            registr.ShowDialog();
        }
    }
    static class login
    {
        public static string Login { get; set; }
    }
    static class id
    {
        public static string ide { get; set; }
    }
}
