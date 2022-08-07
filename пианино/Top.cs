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
    public partial class Top : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = loggek.mdb";
        private OleDbConnection myConnection;
        public Top()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 s = new Form2();
            s.Show();
            Hide();
            
        }

        private void Top_Load(object sender, EventArgs e)
        {
            dataGridView3.Visible = false;

            dataGridView2.Visible = false;
            dataGridView1.Visible = false;
            // TODO: This line of code loads data into the 'loggekDataSet2.IQ' table. You can move, or remove it, as needed.
            this.iQTableAdapter.Fill(this.loggekDataSet2.IQ);
            // TODO: This line of code loads data into the 'loggekDataSet11.OSU' table. You can move, or remove it, as needed.
            this.oSUTableAdapter.Fill(this.loggekDataSet11.OSU);
            // TODO: This line of code loads data into the 'loggekDataSet.labirint' table. You can move, or remove it, as needed.
            this.labirintTableAdapter.Fill(this.loggekDataSet.labirint);
            if (Data.Lang == "rus") { exitToolStripMenuItem.Text = "Выйти"; labirintToolStripMenuItem.Text = "Лабиринт";  iToolStripMenuItem.Text = "IQ тест";
                loginDataGridViewTextBoxColumn.HeaderText = "логин"; labirintDataGridViewTextBoxColumn.HeaderText = "смертей"; loginDataGridViewTextBoxColumn1.HeaderText = "логин"; oSUDataGridViewTextBoxColumn.HeaderText = "время"; loginDataGridViewTextBoxColumn2.HeaderText = "логин"; iQDataGridViewTextBoxColumn.HeaderText = "попыток";
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.labirintTableAdapter.FillBy(this.loggekDataSet.labirint);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void labirintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView3.Visible = false;
            dataGridView2.Visible = false;
            dataGridView1.Visible = true;
            labirintBindingSource.Sort = "labirint ASC "; 
        }

        private void oSUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView3.Visible = false;
            dataGridView2.Visible = true;
            dataGridView1.Visible = false;
            oSUBindingSource.Sort = "OSU ASC ";
        }

        private void iToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView3.Visible = true;
            dataGridView2.Visible = false;
            dataGridView1.Visible = false;
            iQBindingSource.Sort = "IQ ASC ";
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
