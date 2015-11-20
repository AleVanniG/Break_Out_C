using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Break_Out_C
{
    public partial class Form1 : Form
    {
        Bersagli bersagli;
        Random r = new Random();
        int BallX = -2;
        int BallY = -2;
        int punteggio = 0;
        public Form1()
        {
            InitializeComponent();
        
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Restart()
        {
           foreach (PictureBox x in bersagli)
            {
                this.Controls.Remove(x);
            }
            bersagli.Clear();
            MessageBox.Show("GameOver");
            Ball.Location = new Point(Player.Location.X+30,Player.Location.Y-60);
            
            timer1.Stop();
            BallX = -2;
            BallY = -1;
           
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Ball.Bounds.IntersectsWith(Wall.Bounds))
            {
                BallY *= -1;
                BallX = 1;
            }

            if (Ball.Bounds.IntersectsWith(Wall_Left.Bounds))
            {
                
                BallX *= -1 ;
                BallY *= 1;
               
            }

            if (Ball.Bounds.IntersectsWith(Wall_right.Bounds))
            {
                BallY *= 1;
                BallX = -1 ;

            }

            if (Ball.Bounds.IntersectsWith(Player.Bounds))
            {
                BallX *= 1 ;
                BallY *= -1;

            }
            PictureBox x = bersagli.Collision(Ball);
            if (x != null)
            {
                BallX *= 1;
                BallY *= -1;
                punteggio++;
                this.Controls.Remove(x);

            }

            if (Ball.Bounds.IntersectsWith(PCB_GameOver.Bounds))
            {
                
                timer1.Stop();
                Form1_Restart();
                
            }

            lbl_punteggio.Text =("punteggio: "+punteggio) ;
          

            Ball.Location = new Point(Ball.Location.X + BallX, Ball.Location.Y + BallY);
        }

        private void Player_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
                Player.Location = new Point(Player.Location.X + (e.X), Player.Location.Y + (0));

        }

        private void Player_Click(object sender, EventArgs e)
        {

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            bersagli = new Bersagli(850);

            foreach (PictureBox x in bersagli)
            {
                this.Controls.Add(x);
            }
            timer1.Start();
            punteggio = 0;
        }
    }
}
