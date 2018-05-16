namespace Arkanoid
{
    partial class FormGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.labelTop = new System.Windows.Forms.Label();
            this.labelLeft = new System.Windows.Forms.Label();
            this.labelRight = new System.Windows.Forms.Label();
            this.racket = new System.Windows.Forms.Button();
            this.brick1 = new System.Windows.Forms.Label();
            this.brick2 = new System.Windows.Forms.Label();
            this.brick3 = new System.Windows.Forms.Label();
            this.brick4 = new System.Windows.Forms.Label();
            this.brick5 = new System.Windows.Forms.Label();
            this.brick6 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.ball = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTop
            // 
            this.labelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelTop.Location = new System.Drawing.Point(0, 0);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(800, 15);
            this.labelTop.TabIndex = 0;
            // 
            // labelLeft
            // 
            this.labelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelLeft.Location = new System.Drawing.Point(0, 0);
            this.labelLeft.Name = "labelLeft";
            this.labelLeft.Size = new System.Drawing.Size(15, 400);
            this.labelLeft.TabIndex = 1;
            // 
            // labelRight
            // 
            this.labelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelRight.Location = new System.Drawing.Point(785, 0);
            this.labelRight.Name = "labelRight";
            this.labelRight.Size = new System.Drawing.Size(15, 400);
            this.labelRight.TabIndex = 2;
            // 
            // racket
            // 
            this.racket.Enabled = false;
            this.racket.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.racket.Location = new System.Drawing.Point(339, 370);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(83, 30);
            this.racket.TabIndex = 3;
            this.racket.Text = "------";
            this.racket.UseVisualStyleBackColor = true;
            // 
            // brick1
            // 
            this.brick1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.brick1.Location = new System.Drawing.Point(117, 84);
            this.brick1.Name = "brick1";
            this.brick1.Size = new System.Drawing.Size(49, 23);
            this.brick1.TabIndex = 5;
            // 
            // brick2
            // 
            this.brick2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.brick2.Location = new System.Drawing.Point(164, 206);
            this.brick2.Name = "brick2";
            this.brick2.Size = new System.Drawing.Size(49, 23);
            this.brick2.TabIndex = 6;
            // 
            // brick3
            // 
            this.brick3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.brick3.Location = new System.Drawing.Point(350, 137);
            this.brick3.Name = "brick3";
            this.brick3.Size = new System.Drawing.Size(49, 23);
            this.brick3.TabIndex = 7;
            // 
            // brick4
            // 
            this.brick4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.brick4.Location = new System.Drawing.Point(568, 93);
            this.brick4.Name = "brick4";
            this.brick4.Size = new System.Drawing.Size(49, 23);
            this.brick4.TabIndex = 8;
            // 
            // brick5
            // 
            this.brick5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.brick5.Location = new System.Drawing.Point(587, 189);
            this.brick5.Name = "brick5";
            this.brick5.Size = new System.Drawing.Size(49, 23);
            this.brick5.TabIndex = 9;
            // 
            // brick6
            // 
            this.brick6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.brick6.Location = new System.Drawing.Point(486, 247);
            this.brick6.Name = "brick6";
            this.brick6.Size = new System.Drawing.Size(49, 23);
            this.brick6.TabIndex = 10;
            // 
            // timer
            // 
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Transparent;
            this.ball.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ball.BackgroundImage")));
            this.ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ball.Location = new System.Drawing.Point(374, 348);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(16, 16);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ball.TabIndex = 12;
            this.ball.TabStop = false;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.brick6);
            this.Controls.Add(this.brick5);
            this.Controls.Add(this.brick4);
            this.Controls.Add(this.brick3);
            this.Controls.Add(this.brick2);
            this.Controls.Add(this.brick1);
            this.Controls.Add(this.racket);
            this.Controls.Add(this.labelRight);
            this.Controls.Add(this.labelLeft);
            this.Controls.Add(this.labelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormGame";
            this.Shown += new System.EventHandler(this.FormGame_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTop;
        private System.Windows.Forms.Label labelLeft;
        private System.Windows.Forms.Label labelRight;
        private System.Windows.Forms.Button racket;
        private System.Windows.Forms.Label brick1;
        private System.Windows.Forms.Label brick2;
        private System.Windows.Forms.Label brick3;
        private System.Windows.Forms.Label brick4;
        private System.Windows.Forms.Label brick5;
        private System.Windows.Forms.Label brick6;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox ball;
    }
}