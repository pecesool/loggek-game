using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace пианино//окно веб браузера, где пользователь может воспользоваться всеми функциями гугл браузера
{
    public partial class web_browser : Form
    {
        public web_browser()
        {
            InitializeComponent();
        }

        private void web_browser_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.ru");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(toolStripTextBox1.Text);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            reference s1 = new reference();
            s1.Show();
            this.Hide();
        }


        private void web_browser_Activated(object sender, EventArgs e)
        {
            if (Data.Lang == "rus") { toolStripButton1.Text = "Поиск"; toolStripButton2.Text = "Назад"; toolStripButton3.Text = "Обновить"; toolStripButton4.Text = "Выйти"; }
        }

        private void toolStripTextBox1_Click(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(toolStripTextBox1.Text);
            }
        }
    }
}
