using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace пианино//фмнальное окно с поздравлениями
{
    public partial class Final : Form
    {
        public Final()
        {
            InitializeComponent();
        }

       

        private void Final_Load(object sender, EventArgs e)
        {
            if (Data.Lang == "rus")
                label1.Text = "Поздравляю с успешным прохождением игры";
            else
                label1.Text = "Congratulations on the successful completion of the game";
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 final = new Form2(); final.Show(); Hide();
            Data.starone = false; Data.startwo = false; Data.startri = false;
        }
    }
}
