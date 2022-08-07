using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Media;
using WMPLib;

namespace пианино// главное меню программы, отсюда пользаватель может перейти в главные вкладки программы
{
    public partial class Form2 : Form
    {
        

        public Form2()
        {
            InitializeComponent();
            sett = new Form3();
        }
        Form3 sett;
       
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.Visible = false; button1.Visible = true; button2.Visible = true; button3.Visible = true; button5.Visible = true; button4.Visible = true; timer1.Enabled = false; timer2.Enabled = false;
        }
        

        

        private void button1_Click(object sender, EventArgs e)
        {
            Game1 game = new Game1(); game.Show(); Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Data.Location = "lobby"; sett.Show(); Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0); System.Environment.FailFast("SMTH!");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Left > -label1.Width) { label1.Left -= 5; } else { label1.Left = this.Width; }
        }
        private void timer2_Tick(object sender, EventArgs e)
        { if (label1.Visible == false) { label1.Visible = true; } else { label1.Visible = false; } }
        

        private void button4_Click(object sender, EventArgs e)
        {
            reference s = new reference();
            s.Show();
            Hide();
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            if (Data.Lang == "rus")
            { label1.Text = "Кликните, чтобы начать"; button1.Text = "Играть"; button2.Text = "Настройки"; button3.Text = "Выход"; button5.Text = "Топ игроков"; button4.Text = "Справка";  }
            label1.Visible = true; button1.Visible = false; button2.Visible = false; button3.Visible = false; button5.Visible = false; button4.Visible = false; timer1.Enabled = true; timer2.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Top s = new Top();
            s.Show();
            Hide();
        }
    }
}
