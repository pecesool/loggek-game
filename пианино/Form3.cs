using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace пианино// окно настроек, здесь пользовательможет настроить громкость музыки и язык пользования
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (Data.Lang == "rus") { radioButton2.Checked = true; label1.Text = "Настройки:"; label2.Text = "Язык:"; label3.Text = "Вернуться"; label5.Text = "Применить"; radioButton1.Text = "Английский"; radioButton2.Text = "Русский"; checkBox1.Text = "Музыка"; }
            else { radioButton1.Checked = true; }
            if (Data.Volume == 0)
                Data.Music = true;
            else
                Data.Music = false;
            if (Data.Music == false) { checkBox1.Checked = true; } else { checkBox1.Checked = false; }
            label5.BackColor = Color.AliceBlue;

        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (Data.Location == "lobby")
            {
                Form2 s = new Form2(); s.Show(); Hide();
            }
            else { Game1 game = new Game1(); game.Show(); Hide(); }
        }
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Data.Lang == "rus")
            { label1.Text = "Настройки:"; label2.Text = "Язык:"; label3.Text = "Вернуться"; label5.Text = "Применить"; radioButton1.Text = "Английский"; radioButton2.Text = "Русский"; checkBox1.Text = "Музыка"; }
            else { label1.Text = "Settings:"; label2.Text = "Language:"; label3.Text = "Back"; label5.Text = "Apply"; radioButton1.Text = "English"; radioButton2.Text = "Russian"; checkBox1.Text = "Music"; }
            timer1.Enabled = false;
        }
       

        private void label5_Click(object sender, EventArgs e)
        {
            label5.BackColor = Color.AliceBlue;
            if (radioButton1.Checked)
                Data.Lang = "eng";
            else
                Data.Lang = "rus";
            timer1.Enabled = true;
            if (checkBox1.Checked == true) { Data.Music = false; } else { Data.Music = true; trackBar1.Value = 0; }
            if (trackBar1.Value == 0)
            { checkBox1.Checked = false; Data.Music = true; }
            else { checkBox1.Checked = true; Data.Music = false; }
            Data.Volume = trackBar1.Value;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label5.BackColor = Color.Blue;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label5.BackColor = Color.Blue;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    static class Data
    {
        public static string Lang { get; set; }
        public static bool Music { get; set; }
        public static int Volume { get; set; }
        public static string Location { get; set; }
        public static bool starone { get; set; }
        public static bool startwo { get; set; }
        public static bool startri { get; set; }
    }
}


