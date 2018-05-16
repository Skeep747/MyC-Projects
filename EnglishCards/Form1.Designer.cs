namespace EnglishCards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelRussian = new System.Windows.Forms.Label();
            this.pictureCard = new System.Windows.Forms.PictureBox();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.labelEnglish = new System.Windows.Forms.Label();
            this.labelVideo = new System.Windows.Forms.Label();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRussian
            // 
            this.labelRussian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRussian.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelRussian.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRussian.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelRussian.Location = new System.Drawing.Point(77, 7);
            this.labelRussian.Name = "labelRussian";
            this.labelRussian.Size = new System.Drawing.Size(150, 50);
            this.labelRussian.TabIndex = 0;
            this.labelRussian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelRussian.Click += new System.EventHandler(this.labelRussian_Click);
            // 
            // pictureCard
            // 
            this.pictureCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureCard.Location = new System.Drawing.Point(77, 57);
            this.pictureCard.Name = "pictureCard";
            this.pictureCard.Size = new System.Drawing.Size(150, 150);
            this.pictureCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureCard.TabIndex = 1;
            this.pictureCard.TabStop = false;
            this.pictureCard.Click += new System.EventHandler(this.labelVideo_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeft.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLeft.Location = new System.Drawing.Point(6, 110);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(65, 65);
            this.buttonLeft.TabIndex = 2;
            this.buttonLeft.Text = "«";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRight.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRight.Location = new System.Drawing.Point(233, 110);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(65, 65);
            this.buttonRight.TabIndex = 3;
            this.buttonRight.Text = "»";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // labelEnglish
            // 
            this.labelEnglish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEnglish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelEnglish.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnglish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelEnglish.Location = new System.Drawing.Point(77, 207);
            this.labelEnglish.Name = "labelEnglish";
            this.labelEnglish.Size = new System.Drawing.Size(150, 50);
            this.labelEnglish.TabIndex = 4;
            this.labelEnglish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelEnglish.Click += new System.EventHandler(this.labelEnglish_Click);
            // 
            // labelVideo
            // 
            this.labelVideo.AutoSize = true;
            this.labelVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelVideo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVideo.Location = new System.Drawing.Point(234, 57);
            this.labelVideo.Name = "labelVideo";
            this.labelVideo.Size = new System.Drawing.Size(63, 16);
            this.labelVideo.TabIndex = 5;
            this.labelVideo.Text = "+ video";
            this.labelVideo.Visible = false;
            this.labelVideo.Click += new System.EventHandler(this.labelVideo_Click);
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(77, 57);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(150, 150);
            this.player.TabIndex = 6;
            this.player.Visible = false;
            this.player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.player_PlayStateChange);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 263);
            this.Controls.Add(this.labelVideo);
            this.Controls.Add(this.labelEnglish);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.labelRussian);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pictureCard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "English Cards";
            ((System.ComponentModel.ISupportInitialize)(this.pictureCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRussian;
        private System.Windows.Forms.PictureBox pictureCard;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Label labelEnglish;
        private System.Windows.Forms.Label labelVideo;
        private AxWMPLib.AxWindowsMediaPlayer player;
    }
}

