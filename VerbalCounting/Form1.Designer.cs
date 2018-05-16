namespace Verbal_counting
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
            this.textAnswer = new System.Windows.Forms.TextBox();
            this.labelThink = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonMult = new System.Windows.Forms.Button();
            this.buttonDev = new System.Windows.Forms.Button();
            this.textBoxLevel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textAnswer
            // 
            this.textAnswer.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textAnswer.Location = new System.Drawing.Point(22, 130);
            this.textAnswer.Name = "textAnswer";
            this.textAnswer.Size = new System.Drawing.Size(331, 85);
            this.textAnswer.TabIndex = 0;
            this.textAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textAnswer_KeyDown);
            // 
            // labelThink
            // 
            this.labelThink.BackColor = System.Drawing.Color.White;
            this.labelThink.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelThink.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelThink.Location = new System.Drawing.Point(22, 19);
            this.labelThink.Name = "labelThink";
            this.labelThink.Size = new System.Drawing.Size(331, 94);
            this.labelThink.TabIndex = 1;
            this.labelThink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(22, 245);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(63, 49);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Tag = "add";
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(22, 245);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(331, 49);
            this.progress.TabIndex = 3;
            this.progress.Visible = false;
            // 
            // buttonSub
            // 
            this.buttonSub.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSub.Location = new System.Drawing.Point(91, 245);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(63, 49);
            this.buttonSub.TabIndex = 4;
            this.buttonSub.Tag = "sub";
            this.buttonSub.Text = "Sub";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonMult
            // 
            this.buttonMult.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMult.Location = new System.Drawing.Point(160, 245);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Size = new System.Drawing.Size(63, 49);
            this.buttonMult.TabIndex = 5;
            this.buttonMult.Tag = "mult";
            this.buttonMult.Text = "Mult";
            this.buttonMult.UseVisualStyleBackColor = true;
            this.buttonMult.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDev
            // 
            this.buttonDev.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDev.Location = new System.Drawing.Point(229, 245);
            this.buttonDev.Name = "buttonDev";
            this.buttonDev.Size = new System.Drawing.Size(63, 49);
            this.buttonDev.TabIndex = 6;
            this.buttonDev.Tag = "dev";
            this.buttonDev.Text = "Dev";
            this.buttonDev.UseVisualStyleBackColor = true;
            this.buttonDev.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxLevel
            // 
            this.textBoxLevel.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLevel.Location = new System.Drawing.Point(298, 246);
            this.textBoxLevel.MaxLength = 2;
            this.textBoxLevel.Name = "textBoxLevel";
            this.textBoxLevel.Size = new System.Drawing.Size(55, 46);
            this.textBoxLevel.TabIndex = 7;
            this.textBoxLevel.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 306);
            this.Controls.Add(this.textBoxLevel);
            this.Controls.Add(this.buttonDev);
            this.Controls.Add(this.buttonMult);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelThink);
            this.Controls.Add(this.textAnswer);
            this.Controls.Add(this.progress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verbal counting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textAnswer;
        private System.Windows.Forms.Label labelThink;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonMult;
        private System.Windows.Forms.Button buttonDev;
        private System.Windows.Forms.TextBox textBoxLevel;
    }
}

