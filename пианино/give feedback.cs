using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace пианино//это окно представляет из себя мини текстовый редактор, где пользователь может оставить отзыв
{
    public partial class give_feedback : Form
    {
        public give_feedback()
        {
            InitializeComponent();
        }

        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Clear();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                }
                catch (System.ArgumentException ex)
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                }
                this.Text = openFileDialog1.FileName;
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
                this.Text = saveFileDialog1.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reference s1 = new reference();
            s1.Show();
            this.Hide();
        }

        private void изменитьШрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void изменитьЦветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void поЛевомуКраюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void поПравомуКраюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void поЦентруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog p1 = new PrintDialog();
            PrintDocument p2 = new PrintDocument();
            p2.DocumentName = "Печать документа";
            p1.Document = p2;
            p1.AllowSelection = true;
            p1.AllowSomePages = true;
            if (p1.ShowDialog() == DialogResult.OK)
            p2.Print();
        }

        private void выделитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        

        private void give_feedback_Activated(object sender, EventArgs e)
        {
            if (Data.Lang == "rus") { файлToolStripMenuItem.Text = "Файл"; вставитьToolStripMenuItem.Text = "Вставить"; копироватьToolStripMenuItem.Text = "Копировать";
                вырезатьToolStripMenuItem.Text = "Вырезать"; выделитьВсеToolStripMenuItem.Text = "Выделить все"; печатьToolStripMenuItem.Text = "Печать"; button1.Text = "назад";
                поЦентруToolStripMenuItem.Text = "По центру"; поПравомуКраюToolStripMenuItem.Text = "По правому краю"; поЛевомуКраюToolStripMenuItem.Text = "По левому краю";
                изменитьЦветToolStripMenuItem.Text = "Изменить цвет"; изменитьШрифтToolStripMenuItem.Text = "Изменить шрифт"; сохранитьToolStripMenuItem.Text = "Сохранить как";
                открытьToolStripMenuItem.Text = "Открыть файл"; новыйToolStripMenuItem.Text = "Новый документ"; форматироватьToolStripMenuItem.Text = "Форматировать"; новыйToolStripMenuItem.Text = "Новый документ";
                редактироватьToolStripMenuItem.Text = "Редактировать"; выравниваниеToolStripMenuItem.Text = "Выравнивание";
            }
        }
    }
}
