using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3_Lab8
{
    public partial class Form1 : Form
    {
        int score=0;
        int totalheight = 0;
        int random_points=0 ,random_points2= 0;
        Random obj = new Random();
        public Form1()
        {
            InitializeComponent();
            

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
            totalheight = pbTrex.Top - 60;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            pbObstacle1.Left -= 5;
            pbObstacle2.Left -= 5;
            if(pbTrex.Bounds.IntersectsWith(pbObstacle1.Bounds) || pbTrex.Bounds.IntersectsWith(pbObstacle2.Bounds))
            {

                timer1.Stop();
                pbTrex.ImageLocation = "C:\\Users\\PC-I\\Desktop\\Labs_Visual_Programming\\Lab_question\\8-lab\\trexImages\\dead.png";
                timer2.Stop();
                timer3.Stop();
                timer4.Stop();
               pbObstacle1.Location = new Point(random_points, 380);
              pbObstacle2.Location = new Point(random_points2, 380);

            }
            

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)

        {
            

            if (e.KeyCode == Keys.Space)
            {
                 if (pbTrex.Top>totalheight)
                {
                    pbTrex.Top -= 10;
                }
                
            }


            if (e.KeyCode == Keys.R)
            {

                pbTrex.ImageLocation = "C:\\Users\\PC-I\\Desktop\\Labs_Visual_Programming\\Lab_question\\8-lab\\trexImages\\running.gif";
                timer1.Start();
                timer2.Start();
                timer3.Start();
                timer4.Start();
                score = 0;
                
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                pbTrex.Top = totalheight + 60;
            }

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            random_points2 = obj.Next(350, 750);
            if (random_points == random_points2)
            {
                random_points2 = obj.Next(350, 750);
            }
            pbObstacle2.Location = new Point(random_points2, 380);
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            score++;
            lblScore.Text = "Score: "+ score.ToString();
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            random_points = obj.Next(350, 750);
            pbObstacle1.Location= new Point(random_points,380);
            
        }
    }
}
