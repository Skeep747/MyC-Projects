namespace Rock_paper_scissors
{
    partial class f1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f1));
            this.panelRock = new System.Windows.Forms.Panel();
            this.userPictureBoxRock = new System.Windows.Forms.PictureBox();
            this.panelPaper = new System.Windows.Forms.Panel();
            this.userPictureBoxPaper = new System.Windows.Forms.PictureBox();
            this.panelScissors = new System.Windows.Forms.Panel();
            this.userPictureBoxScissors = new System.Windows.Forms.PictureBox();
            this.panelComputer = new System.Windows.Forms.Panel();
            this.computerPictureBoxScissors = new System.Windows.Forms.PictureBox();
            this.computerPictureBoxRock = new System.Windows.Forms.PictureBox();
            this.computerPictureBoxPaper = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lUser = new System.Windows.Forms.Label();
            this.lScore = new System.Windows.Forms.Label();
            this.lComputer = new System.Windows.Forms.Label();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.panelRock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBoxRock)).BeginInit();
            this.panelPaper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBoxPaper)).BeginInit();
            this.panelScissors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBoxScissors)).BeginInit();
            this.panelComputer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBoxScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBoxRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBoxPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRock
            // 
            this.panelRock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRock.Controls.Add(this.userPictureBoxRock);
            this.panelRock.Location = new System.Drawing.Point(12, 47);
            this.panelRock.Name = "panelRock";
            this.panelRock.Size = new System.Drawing.Size(147, 150);
            this.panelRock.TabIndex = 0;
            this.panelRock.MouseEnter += new System.EventHandler(this.panelRock_MouseEnter);
            // 
            // userPictureBoxRock
            // 
            this.userPictureBoxRock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userPictureBoxRock.Image = ((System.Drawing.Image)(resources.GetObject("userPictureBoxRock.Image")));
            this.userPictureBoxRock.Location = new System.Drawing.Point(0, 0);
            this.userPictureBoxRock.Name = "userPictureBoxRock";
            this.userPictureBoxRock.Size = new System.Drawing.Size(145, 148);
            this.userPictureBoxRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPictureBoxRock.TabIndex = 3;
            this.userPictureBoxRock.TabStop = false;
            this.userPictureBoxRock.Visible = false;
            this.userPictureBoxRock.MouseClick += new System.Windows.Forms.MouseEventHandler(this.userPictureBoxRock_MouseClick);
            // 
            // panelPaper
            // 
            this.panelPaper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPaper.Controls.Add(this.userPictureBoxPaper);
            this.panelPaper.Location = new System.Drawing.Point(165, 47);
            this.panelPaper.Name = "panelPaper";
            this.panelPaper.Size = new System.Drawing.Size(95, 150);
            this.panelPaper.TabIndex = 1;
            this.panelPaper.MouseEnter += new System.EventHandler(this.panelPaper_MouseEnter);
            // 
            // userPictureBoxPaper
            // 
            this.userPictureBoxPaper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userPictureBoxPaper.Image = ((System.Drawing.Image)(resources.GetObject("userPictureBoxPaper.Image")));
            this.userPictureBoxPaper.Location = new System.Drawing.Point(0, 0);
            this.userPictureBoxPaper.Name = "userPictureBoxPaper";
            this.userPictureBoxPaper.Size = new System.Drawing.Size(93, 148);
            this.userPictureBoxPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPictureBoxPaper.TabIndex = 4;
            this.userPictureBoxPaper.TabStop = false;
            this.userPictureBoxPaper.Visible = false;
            this.userPictureBoxPaper.MouseClick += new System.Windows.Forms.MouseEventHandler(this.userPictureBoxPaper_MouseClick);
            // 
            // panelScissors
            // 
            this.panelScissors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelScissors.Controls.Add(this.userPictureBoxScissors);
            this.panelScissors.Location = new System.Drawing.Point(266, 47);
            this.panelScissors.Name = "panelScissors";
            this.panelScissors.Size = new System.Drawing.Size(116, 150);
            this.panelScissors.TabIndex = 1;
            this.panelScissors.MouseEnter += new System.EventHandler(this.panelScissor_MouseEnter);
            // 
            // userPictureBoxScissors
            // 
            this.userPictureBoxScissors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userPictureBoxScissors.Image = ((System.Drawing.Image)(resources.GetObject("userPictureBoxScissors.Image")));
            this.userPictureBoxScissors.Location = new System.Drawing.Point(0, 0);
            this.userPictureBoxScissors.Name = "userPictureBoxScissors";
            this.userPictureBoxScissors.Size = new System.Drawing.Size(114, 148);
            this.userPictureBoxScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPictureBoxScissors.TabIndex = 5;
            this.userPictureBoxScissors.TabStop = false;
            this.userPictureBoxScissors.Visible = false;
            this.userPictureBoxScissors.MouseClick += new System.Windows.Forms.MouseEventHandler(this.userPictureBoxScissors_MouseClick);
            // 
            // panelComputer
            // 
            this.panelComputer.Controls.Add(this.computerPictureBoxScissors);
            this.panelComputer.Controls.Add(this.computerPictureBoxRock);
            this.panelComputer.Controls.Add(this.computerPictureBoxPaper);
            this.panelComputer.Location = new System.Drawing.Point(430, 47);
            this.panelComputer.Name = "panelComputer";
            this.panelComputer.Size = new System.Drawing.Size(109, 150);
            this.panelComputer.TabIndex = 2;
            // 
            // computerPictureBoxScissors
            // 
            this.computerPictureBoxScissors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.computerPictureBoxScissors.Image = ((System.Drawing.Image)(resources.GetObject("computerPictureBoxScissors.Image")));
            this.computerPictureBoxScissors.Location = new System.Drawing.Point(0, 0);
            this.computerPictureBoxScissors.Name = "computerPictureBoxScissors";
            this.computerPictureBoxScissors.Size = new System.Drawing.Size(109, 150);
            this.computerPictureBoxScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.computerPictureBoxScissors.TabIndex = 8;
            this.computerPictureBoxScissors.TabStop = false;
            this.computerPictureBoxScissors.Visible = false;
            // 
            // computerPictureBoxRock
            // 
            this.computerPictureBoxRock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.computerPictureBoxRock.Image = ((System.Drawing.Image)(resources.GetObject("computerPictureBoxRock.Image")));
            this.computerPictureBoxRock.Location = new System.Drawing.Point(0, 0);
            this.computerPictureBoxRock.Name = "computerPictureBoxRock";
            this.computerPictureBoxRock.Size = new System.Drawing.Size(109, 150);
            this.computerPictureBoxRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.computerPictureBoxRock.TabIndex = 7;
            this.computerPictureBoxRock.TabStop = false;
            this.computerPictureBoxRock.Visible = false;
            // 
            // computerPictureBoxPaper
            // 
            this.computerPictureBoxPaper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.computerPictureBoxPaper.Image = ((System.Drawing.Image)(resources.GetObject("computerPictureBoxPaper.Image")));
            this.computerPictureBoxPaper.Location = new System.Drawing.Point(0, 0);
            this.computerPictureBoxPaper.Name = "computerPictureBoxPaper";
            this.computerPictureBoxPaper.Size = new System.Drawing.Size(109, 150);
            this.computerPictureBoxPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.computerPictureBoxPaper.TabIndex = 6;
            this.computerPictureBoxPaper.TabStop = false;
            this.computerPictureBoxPaper.Visible = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 300;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lUser
            // 
            this.lUser.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lUser.Location = new System.Drawing.Point(9, 1);
            this.lUser.Name = "lUser";
            this.lUser.Size = new System.Drawing.Size(372, 38);
            this.lUser.TabIndex = 3;
            this.lUser.Text = "Choose you figure!";
            this.lUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lScore
            // 
            this.lScore.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lScore.Location = new System.Drawing.Point(9, 214);
            this.lScore.Name = "lScore";
            this.lScore.Size = new System.Drawing.Size(373, 23);
            this.lScore.TabIndex = 4;
            this.lScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lComputer
            // 
            this.lComputer.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lComputer.Location = new System.Drawing.Point(430, 9);
            this.lComputer.Name = "lComputer";
            this.lComputer.Size = new System.Drawing.Size(109, 30);
            this.lComputer.TabIndex = 5;
            this.lComputer.Text = "Computer figure";
            this.lComputer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.LargeChange = 1;
            this.trackBarSpeed.Location = new System.Drawing.Point(383, 47);
            this.trackBarSpeed.Maximum = 5;
            this.trackBarSpeed.Minimum = 1;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarSpeed.Size = new System.Drawing.Size(45, 150);
            this.trackBarSpeed.TabIndex = 6;
            this.trackBarSpeed.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarSpeed.Value = 3;
            this.trackBarSpeed.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // f1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 245);
            this.Controls.Add(this.lComputer);
            this.Controls.Add(this.lScore);
            this.Controls.Add(this.lUser);
            this.Controls.Add(this.panelComputer);
            this.Controls.Add(this.panelScissors);
            this.Controls.Add(this.panelPaper);
            this.Controls.Add(this.panelRock);
            this.Controls.Add(this.trackBarSpeed);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "f1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock–paper–scissors";
            this.panelRock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBoxRock)).EndInit();
            this.panelPaper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBoxPaper)).EndInit();
            this.panelScissors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBoxScissors)).EndInit();
            this.panelComputer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBoxScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBoxRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBoxPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelRock;
        private System.Windows.Forms.Panel panelPaper;
        private System.Windows.Forms.Panel panelScissors;
        private System.Windows.Forms.Panel panelComputer;
        private System.Windows.Forms.PictureBox userPictureBoxRock;
        private System.Windows.Forms.PictureBox userPictureBoxPaper;
        private System.Windows.Forms.PictureBox userPictureBoxScissors;
        private System.Windows.Forms.PictureBox computerPictureBoxScissors;
        private System.Windows.Forms.PictureBox computerPictureBoxRock;
        private System.Windows.Forms.PictureBox computerPictureBoxPaper;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lUser;
        private System.Windows.Forms.Label lScore;
        private System.Windows.Forms.Label lComputer;
        private System.Windows.Forms.TrackBar trackBarSpeed;
    }
}

