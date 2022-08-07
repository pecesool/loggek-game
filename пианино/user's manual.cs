using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace пианино//окно руководства пользователя, где правила мини игр
{
    public partial class user_s_manual : Form
    {
        public user_s_manual()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reference s1 = new reference();
            s1.Show();
            this.Hide();
            
        }

        private void user_s_manual_Activated(object sender, EventArgs e)
        {
            if (Data.Lang == "rus") { button1.Text = "назад"; richTextBox1.Visible = false; richTextBox2.Visible = true; }
        }
    }
}
