using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace пианино//окно справки программы, где пользователь может разузнать информацию о программе или же оставить отзыв создателю
{
    public partial class reference : Form
    {
        public reference()
        {
            InitializeComponent();
        }

        private void webBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            web_browser s1 = new web_browser();
            s1.Show();
            this.Hide();
        }

        private void reference_Activated(object sender, EventArgs e)
        {
            if (Data.Lang == "rus") { aboutTheProgramToolStripMenuItem.Text = "О программе"; webBrowserToolStripMenuItem.Text = "Веб браузер"; exitToolStripMenuItem.Text = "Выйти"; giveFeedbackToolStripMenuItem.Text = "Оставить отзыв"; usersManualToolStripMenuItem.Text = "Руководство пользователя"; }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 s = new Form2();
            s.Show();
            Hide();
        }

        private void giveFeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            give_feedback s1 = new give_feedback();
            s1.Show();
            this.Hide();
        }

        private void usersManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user_s_manual s1 = new user_s_manual();
            s1.Show();
            this.Hide();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void reference_Load(object sender, EventArgs e)
        {

        }
    }
}
