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

namespace пианино//игровое меню, где пользователь может выбрать и начать играть в мини иргу
{
    public partial class Game1 : Form
    {
        public Game1()
        {
            InitializeComponent();
            settings = new Form3();
            puzzle = new labirint();
            osu = new OSU();

        }
        Form3 settings; labirint puzzle; OSU osu;
        public WMPLib.WindowsMediaPlayer wmp = new WindowsMediaPlayer();

        private void Game1_Load(object sender, EventArgs e)
        {
            if (Data.Lang == "rus") { label1.Text = "Головоломка"; label3.Text = "IQ тест"; label4.Text = "Настройки"; label5.Text = "Меню"; label7.Text = "кликните"; }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form form2 = Application.OpenForms[1]; Hide(); form2.Show();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

            settings.Show(); Hide(); Data.Location = "game";

        }

        private void label3_Click(object sender, EventArgs e)
        {
            IQ_test s = new IQ_test();
            s.Show();
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            labirint s = new labirint();
            s.Show();
            Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            OSU s = new OSU();
            s.Show();
            Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Data.starone == true)
                pictureBox1.Visible = true;
            if (Data.startwo == true)
                pictureBox2.Visible = true;
            if (Data.startri == true)
                pictureBox3.Visible = true;
            if (Data.starone == true && Data.startwo == true && Data.startri == true)
            {
                timer1.Enabled = false; label7.Visible = true; label1.Visible = false; label2.Visible = false; label3.Visible = false; label4.Visible = false; label5.Visible = false;

            }


        }

        private void label7_Click(object sender, EventArgs e)
        {
            Final final = new Final(); final.Show(); Hide();
        }
    }
    static class ga
    {
        public static int labirint { get; set; }
        public static int OSU { get; set; }
        public static int IQ { get; set; }
    }
}        
    

