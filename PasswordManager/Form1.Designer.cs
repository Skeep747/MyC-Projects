namespace PasswordManager
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.linkLabelSite1 = new System.Windows.Forms.LinkLabel();
            this.textBoxPassword1 = new System.Windows.Forms.TextBox();
            this.buttonPass1 = new System.Windows.Forms.Button();
            this.linkLabelSite2 = new System.Windows.Forms.LinkLabel();
            this.textBoxPassword2 = new System.Windows.Forms.TextBox();
            this.buttonPass2 = new System.Windows.Forms.Button();
            this.linkLabelSite3 = new System.Windows.Forms.LinkLabel();
            this.textBoxPassword3 = new System.Windows.Forms.TextBox();
            this.buttonPass3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.buttonPass3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPassword3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.linkLabelSite3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonPass2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPassword2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.linkLabelSite2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.linkLabelSite1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPassword1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonPass1, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(562, 101);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // linkLabelSite1
            // 
            this.linkLabelSite1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabelSite1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelSite1.Location = new System.Drawing.Point(3, 0);
            this.linkLabelSite1.Name = "linkLabelSite1";
            this.linkLabelSite1.Size = new System.Drawing.Size(181, 33);
            this.linkLabelSite1.TabIndex = 0;
            this.linkLabelSite1.TabStop = true;
            this.linkLabelSite1.Tag = "https://www.videosharp.info";
            this.linkLabelSite1.Text = "videosharp.info";
            this.linkLabelSite1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelSite1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSite1_LinkClicked);
            // 
            // textBoxPassword1
            // 
            this.textBoxPassword1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPassword1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword1.Location = new System.Drawing.Point(190, 3);
            this.textBoxPassword1.Name = "textBoxPassword1";
            this.textBoxPassword1.ReadOnly = true;
            this.textBoxPassword1.Size = new System.Drawing.Size(181, 26);
            this.textBoxPassword1.TabIndex = 1;
            this.textBoxPassword1.Text = "test@gmail.com";
            this.textBoxPassword1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPassword1.Click += new System.EventHandler(this.textBoxPassword1_Click);
            // 
            // buttonPass1
            // 
            this.buttonPass1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPass1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPass1.Location = new System.Drawing.Point(377, 3);
            this.buttonPass1.Name = "buttonPass1";
            this.buttonPass1.Size = new System.Drawing.Size(182, 27);
            this.buttonPass1.TabIndex = 2;
            this.buttonPass1.Text = "Password";
            this.buttonPass1.UseVisualStyleBackColor = true;
            // 
            // linkLabelSite2
            // 
            this.linkLabelSite2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabelSite2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelSite2.Location = new System.Drawing.Point(3, 33);
            this.linkLabelSite2.Name = "linkLabelSite2";
            this.linkLabelSite2.Size = new System.Drawing.Size(181, 33);
            this.linkLabelSite2.TabIndex = 3;
            this.linkLabelSite2.TabStop = true;
            this.linkLabelSite2.Text = "Google.com";
            this.linkLabelSite2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPassword2
            // 
            this.textBoxPassword2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPassword2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword2.Location = new System.Drawing.Point(190, 36);
            this.textBoxPassword2.Name = "textBoxPassword2";
            this.textBoxPassword2.ReadOnly = true;
            this.textBoxPassword2.Size = new System.Drawing.Size(181, 26);
            this.textBoxPassword2.TabIndex = 4;
            this.textBoxPassword2.Text = "test@gmail.com";
            this.textBoxPassword2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonPass2
            // 
            this.buttonPass2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPass2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPass2.Location = new System.Drawing.Point(377, 36);
            this.buttonPass2.Name = "buttonPass2";
            this.buttonPass2.Size = new System.Drawing.Size(182, 27);
            this.buttonPass2.TabIndex = 5;
            this.buttonPass2.Text = "Password";
            this.buttonPass2.UseVisualStyleBackColor = true;
            // 
            // linkLabelSite3
            // 
            this.linkLabelSite3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabelSite3.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelSite3.Location = new System.Drawing.Point(3, 66);
            this.linkLabelSite3.Name = "linkLabelSite3";
            this.linkLabelSite3.Size = new System.Drawing.Size(181, 35);
            this.linkLabelSite3.TabIndex = 6;
            this.linkLabelSite3.TabStop = true;
            this.linkLabelSite3.Text = "Facebook.com";
            this.linkLabelSite3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPassword3
            // 
            this.textBoxPassword3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPassword3.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword3.Location = new System.Drawing.Point(190, 69);
            this.textBoxPassword3.Name = "textBoxPassword3";
            this.textBoxPassword3.ReadOnly = true;
            this.textBoxPassword3.Size = new System.Drawing.Size(181, 26);
            this.textBoxPassword3.TabIndex = 7;
            this.textBoxPassword3.Text = "test@gmail.com";
            this.textBoxPassword3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonPass3
            // 
            this.buttonPass3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPass3.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPass3.Location = new System.Drawing.Point(377, 69);
            this.buttonPass3.Name = "buttonPass3";
            this.buttonPass3.Size = new System.Drawing.Size(182, 29);
            this.buttonPass3.TabIndex = 8;
            this.buttonPass3.Text = "Password";
            this.buttonPass3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 101);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Password Manager";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonPass3;
        private System.Windows.Forms.TextBox textBoxPassword3;
        private System.Windows.Forms.LinkLabel linkLabelSite3;
        private System.Windows.Forms.Button buttonPass2;
        private System.Windows.Forms.TextBox textBoxPassword2;
        private System.Windows.Forms.LinkLabel linkLabelSite2;
        private System.Windows.Forms.LinkLabel linkLabelSite1;
        private System.Windows.Forms.TextBox textBoxPassword1;
        private System.Windows.Forms.Button buttonPass1;
    }
}

