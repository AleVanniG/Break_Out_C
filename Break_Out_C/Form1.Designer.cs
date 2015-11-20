namespace Break_Out_C
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PCB_GameOver = new System.Windows.Forms.PictureBox();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.Wall = new System.Windows.Forms.PictureBox();
            this.Wall_right = new System.Windows.Forms.PictureBox();
            this.Wall_Left = new System.Windows.Forms.PictureBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.lbl_punteggio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PCB_GameOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall_Left)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PCB_GameOver
            // 
            this.PCB_GameOver.Location = new System.Drawing.Point(0, 427);
            this.PCB_GameOver.Name = "PCB_GameOver";
            this.PCB_GameOver.Size = new System.Drawing.Size(895, 10);
            this.PCB_GameOver.TabIndex = 10;
            this.PCB_GameOver.TabStop = false;
            // 
            // Ball
            // 
            this.Ball.Image = global::Break_Out_C.Properties.Resources.Ball;
            this.Ball.Location = new System.Drawing.Point(356, 342);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(41, 40);
            this.Ball.TabIndex = 9;
            this.Ball.TabStop = false;
            // 
            // Player
            // 
            this.Player.Image = global::Break_Out_C.Properties.Resources.Immagine;
            this.Player.Location = new System.Drawing.Point(382, 405);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(151, 16);
            this.Player.TabIndex = 8;
            this.Player.TabStop = false;
            this.Player.Click += new System.EventHandler(this.Player_Click);
            this.Player.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Player_MouseMove);
            // 
            // Wall
            // 
            this.Wall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Wall.Location = new System.Drawing.Point(0, -1);
            this.Wall.Name = "Wall";
            this.Wall.Size = new System.Drawing.Size(895, 10);
            this.Wall.TabIndex = 7;
            this.Wall.TabStop = false;
            // 
            // Wall_right
            // 
            this.Wall_right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Wall_right.Location = new System.Drawing.Point(885, -1);
            this.Wall_right.Name = "Wall_right";
            this.Wall_right.Size = new System.Drawing.Size(10, 438);
            this.Wall_right.TabIndex = 6;
            this.Wall_right.TabStop = false;
            // 
            // Wall_Left
            // 
            this.Wall_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Wall_Left.Location = new System.Drawing.Point(0, -1);
            this.Wall_Left.Name = "Wall_Left";
            this.Wall_Left.Size = new System.Drawing.Size(10, 438);
            this.Wall_Left.TabIndex = 5;
            this.Wall_Left.TabStop = false;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(911, 12);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 11;
            this.btn_start.Text = "start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // lbl_punteggio
            // 
            this.lbl_punteggio.AutoSize = true;
            this.lbl_punteggio.Location = new System.Drawing.Point(911, 42);
            this.lbl_punteggio.Name = "lbl_punteggio";
            this.lbl_punteggio.Size = new System.Drawing.Size(54, 13);
            this.lbl_punteggio.TabIndex = 12;
            this.lbl_punteggio.Text = "punteggio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(901, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "tenere premuto sulla barra e muovere il mouse per farla scorrere";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 438);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_punteggio);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.PCB_GameOver);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.Wall);
            this.Controls.Add(this.Wall_right);
            this.Controls.Add(this.Wall_Left);
            this.Name = "Form1";
            this.Text = "vanni.alessandro.Arkanoid?????";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PCB_GameOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall_Left)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Wall_Left;
        private System.Windows.Forms.PictureBox Wall_right;
        private System.Windows.Forms.PictureBox Wall;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.PictureBox PCB_GameOver;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lbl_punteggio;
        private System.Windows.Forms.Label label1;
        
    }
}

