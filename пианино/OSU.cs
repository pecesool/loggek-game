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
using System.Data.OleDb;

namespace пианино// окно второй мини игры
{
    public partial class OSU : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = loggek.mdb";
        private OleDbConnection myConnection;
        public OSU()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true); UpdateStyles();
        }
        public Bitmap whitetex = Properties.Resources.white; public Bitmap blacktex = Properties.Resources.black;
        private Point whitePos = Point.Empty; int directionX = 450; int directionY = 250;
        private int score = 0; private int hundread = 1;
        public WMPLib.WindowsMediaPlayer wmp = new WindowsMediaPlayer();

        private void OSU_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            var localPos = this.PointToClient(Cursor.Position);
            whitePos.X = directionX; whitePos.Y = directionY;
            Point smth = new Point(localPos.X - whitePos.X, localPos.Y - whitePos.Y);
            float distance = (float)Math.Sqrt((smth.X * smth.X) + (smth.Y * smth.Y));
            if (distance < 30) { Addpoint(30 - (int)distance); }
            var blackRec = new Rectangle(localPos.X - 50, localPos.Y - 50, 100, 100);
            var whiteRec = new Rectangle(whitePos.X - 50, whitePos.Y - 50, 100, 100);
            g.DrawImage(whitetex, whiteRec); g.DrawImage(blacktex, blackRec);
        }

        private void Addpoint(int point)
        {
            score += point; label3.Text = Convert.ToString(score);
            while (score > (100 * hundread)) { wmp.URL = @"mario.mp3"; wmp.controls.play(); hundread += 1; }
            if (score >= 1500) { wmp.URL = @"lot.mp3"; wmp.controls.play(); Data.startwo = true; Game1 game = new Game1(); game.Show(); Hide();
                string query2 = "INSERT INTO OSU ([login], [OSU]) VALUES ('" + login.Login + "', " + ga.OSU + ")";
                OleDbCommand command2 = new OleDbCommand(query2, myConnection);
                command2.ExecuteNonQuery();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Random r = new Random(); timer3.Interval = r.Next(500, 1000); directionX = r.Next(0, this.Width - 100); directionY = r.Next(0, this.Height - 100);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Game1 game = new Game1(); game.Show(); Hide();
            timer1.Enabled = false;
        }

        private void OSU_Load(object sender, EventArgs e)
        {
            wmp.settings.volume = Data.Volume; if (Data.Lang == "rus") { label1.Text = "Назад"; }
            ga.OSU = 0;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ga.OSU++;
           if (Data.Lang == "rus") { label2.Text = "Время: " + ga.OSU; } else { label2.Text = "Time: " + ga.OSU; }
        }
    }
    }

