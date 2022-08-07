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

namespace пианино//ркно первой мини игры
{
    public partial class labirint : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = loggek.mdb";
        private OleDbConnection myConnection;
        public labirint()
        {
            InitializeComponent();
           
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }
        private int color = -1;
        
        
        private void labirint_Load(object sender, EventArgs e)
        {
            ga.labirint = 0;
            label8.Text = "Deaths: " + ga.labirint;
            if (Data.Lang == "rus") { label8.Text = "Смертей: " + ga.labirint; }
            Cursor.Position = PointToScreen(starts.Location);
            label1.BringToFront(); label2.BringToFront(); label3.BringToFront(); label4.BringToFront(); label5.BringToFront(); label6.BringToFront(); label7.BringToFront(); label8.BringToFront(); label9.BringToFront(); label10.BringToFront(); label11.BringToFront(); label12.BringToFront(); label13.BringToFront(); label14.BringToFront(); label15.BringToFront(); label16.BringToFront(); label17.BringToFront();
            if (Data.Lang == "rus") { label3.Text = "Попробуй пройти головоломку"; float new_size = 19.0f; label7.Font = new Font(label7.Font.FontFamily, new_size, label7.Font.Style); label7.Text = "Дважды кликните на желтую зону, чтобы сдаться"; }
            
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Position = PointToScreen(starts.Location);
            ga.labirint++;
            label8.Text = "Deaths: " + ga.labirint; if (Data.Lang == "rus") { label8.Text = "Смертей: " + ga.labirint; }
        }

        private void label20_MouseEnter(object sender, EventArgs e)
        {
            if (color == -1) { color = 1; }
            else { Cursor.Position = PointToScreen(starts.Location); color = -1; ga.labirint++;
                label8.Text = "Deaths: " + ga.labirint; if (Data.Lang == "rus") { label8.Text = "Смертей: " + ga.labirint; }
            }
            
        }

        private void label29_MouseEnter(object sender, EventArgs e)
        {
            if (color == 1) { color = -1; }
            else { Cursor.Position = PointToScreen(starts.Location); color = -1; ga.labirint++;
                 if (Data.Lang == "rus") { label8.Text = "Смертей: " + ga.labirint; } else { label8.Text = "Deaths: " + ga.labirint; }
            }
            
        }


        

        private void label18_MouseEnter(object sender, EventArgs e)
        {

            Data.starone = true; Game1 game = new Game1(); game.Show(); Hide();
            string query = "INSERT INTO labirint ([login], [labirint]) VALUES ('" + login.Login + "', " + ga.labirint + ")";
            OleDbCommand command2 = new OleDbCommand(query, myConnection);
            command2.ExecuteNonQuery();


        }
        private void label19_Click(object sender, EventArgs e)
        {
            Game1 game = new Game1(); game.Show(); Hide();
        }
    }
}
