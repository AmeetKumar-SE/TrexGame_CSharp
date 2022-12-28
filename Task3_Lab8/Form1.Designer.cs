namespace Task3_Lab8
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblScore = new System.Windows.Forms.Label();
            this.pbObstacle2 = new System.Windows.Forms.PictureBox();
            this.pbObstacle1 = new System.Windows.Forms.PictureBox();
            this.pbTrex = new System.Windows.Forms.PictureBox();
            this.pbGround = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbObstacle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbObstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.Location = new System.Drawing.Point(48, 41);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(133, 28);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score: ";
            // 
            // pbObstacle2
            // 
            this.pbObstacle2.Image = global::Task3_Lab8.Properties.Resources.obstacle_2;
            this.pbObstacle2.Location = new System.Drawing.Point(781, 493);
            this.pbObstacle2.Margin = new System.Windows.Forms.Padding(4);
            this.pbObstacle2.Name = "pbObstacle2";
            this.pbObstacle2.Size = new System.Drawing.Size(32, 33);
            this.pbObstacle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbObstacle2.TabIndex = 4;
            this.pbObstacle2.TabStop = false;
            // 
            // pbObstacle1
            // 
            this.pbObstacle1.Image = global::Task3_Lab8.Properties.Resources.obstacle_1;
            this.pbObstacle1.Location = new System.Drawing.Point(499, 480);
            this.pbObstacle1.Margin = new System.Windows.Forms.Padding(4);
            this.pbObstacle1.Name = "pbObstacle1";
            this.pbObstacle1.Size = new System.Drawing.Size(23, 46);
            this.pbObstacle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbObstacle1.TabIndex = 3;
            this.pbObstacle1.TabStop = false;
            // 
            // pbTrex
            // 
            this.pbTrex.Image = global::Task3_Lab8.Properties.Resources.running;
            this.pbTrex.Location = new System.Drawing.Point(113, 437);
            this.pbTrex.Margin = new System.Windows.Forms.Padding(4);
            this.pbTrex.Name = "pbTrex";
            this.pbTrex.Size = new System.Drawing.Size(68, 89);
            this.pbTrex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTrex.TabIndex = 2;
            this.pbTrex.TabStop = false;
            // 
            // pbGround
            // 
            this.pbGround.Image = global::Task3_Lab8.Properties.Resources.pb_ground;
            this.pbGround.Location = new System.Drawing.Point(-4, 527);
            this.pbGround.Margin = new System.Windows.Forms.Padding(4);
            this.pbGround.Name = "pbGround";
            this.pbGround.Size = new System.Drawing.Size(1072, 26);
            this.pbGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGround.TabIndex = 1;
            this.pbGround.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 8000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 7000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 300;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pbObstacle2);
            this.Controls.Add(this.pbObstacle1);
            this.Controls.Add(this.pbTrex);
            this.Controls.Add(this.pbGround);
            this.Controls.Add(this.lblScore);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbObstacle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbObstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox pbGround;
        private System.Windows.Forms.PictureBox pbTrex;
        private System.Windows.Forms.PictureBox pbObstacle1;
        private System.Windows.Forms.PictureBox pbObstacle2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
    }
}

