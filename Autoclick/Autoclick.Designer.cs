namespace Autoclick
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
            this.tlp = new System.Windows.Forms.TableLayoutPanel();
            this.label_info_click = new System.Windows.Forms.Label();
            this.label_info_time = new System.Windows.Forms.Label();
            this.label_show_count = new System.Windows.Forms.Label();
            this.label_show_time = new System.Windows.Forms.Label();
            this.track_count = new System.Windows.Forms.TrackBar();
            this.track_time = new System.Windows.Forms.TrackBar();
            this.b_start = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tlp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track_count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_time)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp
            // 
            this.tlp.ColumnCount = 3;
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp.Controls.Add(this.label_info_click, 0, 0);
            this.tlp.Controls.Add(this.label_info_time, 0, 1);
            this.tlp.Controls.Add(this.label_show_count, 2, 0);
            this.tlp.Controls.Add(this.label_show_time, 2, 1);
            this.tlp.Controls.Add(this.track_count, 1, 0);
            this.tlp.Controls.Add(this.track_time, 1, 1);
            this.tlp.Controls.Add(this.b_start, 1, 2);
            this.tlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp.Location = new System.Drawing.Point(0, 0);
            this.tlp.Name = "tlp";
            this.tlp.RowCount = 3;
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp.Size = new System.Drawing.Size(484, 111);
            this.tlp.TabIndex = 0;
            // 
            // label_info_click
            // 
            this.label_info_click.AutoSize = true;
            this.label_info_click.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_info_click.Location = new System.Drawing.Point(3, 0);
            this.label_info_click.Name = "label_info_click";
            this.label_info_click.Size = new System.Drawing.Size(155, 37);
            this.label_info_click.TabIndex = 0;
            this.label_info_click.Text = "Number of clicks";
            this.label_info_click.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_info_time
            // 
            this.label_info_time.AutoSize = true;
            this.label_info_time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_info_time.Location = new System.Drawing.Point(3, 37);
            this.label_info_time.Name = "label_info_time";
            this.label_info_time.Size = new System.Drawing.Size(155, 37);
            this.label_info_time.TabIndex = 1;
            this.label_info_time.Text = "Delay between clicks";
            this.label_info_time.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_show_count
            // 
            this.label_show_count.AutoSize = true;
            this.label_show_count.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_show_count.Location = new System.Drawing.Point(325, 0);
            this.label_show_count.Name = "label_show_count";
            this.label_show_count.Size = new System.Drawing.Size(156, 37);
            this.label_show_count.TabIndex = 2;
            this.label_show_count.Text = "10 click\'s";
            this.label_show_count.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_show_time
            // 
            this.label_show_time.AutoSize = true;
            this.label_show_time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_show_time.Location = new System.Drawing.Point(325, 37);
            this.label_show_time.Name = "label_show_time";
            this.label_show_time.Size = new System.Drawing.Size(156, 37);
            this.label_show_time.TabIndex = 3;
            this.label_show_time.Text = "1 ms";
            this.label_show_time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // track_count
            // 
            this.track_count.Dock = System.Windows.Forms.DockStyle.Fill;
            this.track_count.Location = new System.Drawing.Point(164, 3);
            this.track_count.Maximum = 100;
            this.track_count.Minimum = 10;
            this.track_count.Name = "track_count";
            this.track_count.Size = new System.Drawing.Size(155, 31);
            this.track_count.TabIndex = 4;
            this.track_count.TickFrequency = 10;
            this.track_count.Value = 10;
            this.track_count.Scroll += new System.EventHandler(this.track_count_Scroll);
            // 
            // track_time
            // 
            this.track_time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.track_time.Location = new System.Drawing.Point(164, 40);
            this.track_time.Maximum = 1000;
            this.track_time.Minimum = 1;
            this.track_time.Name = "track_time";
            this.track_time.Size = new System.Drawing.Size(155, 31);
            this.track_time.TabIndex = 5;
            this.track_time.TickFrequency = 100;
            this.track_time.Value = 1;
            this.track_time.Scroll += new System.EventHandler(this.track_time_Scroll);
            // 
            // b_start
            // 
            this.b_start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_start.Location = new System.Drawing.Point(164, 77);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(155, 31);
            this.b_start.TabIndex = 6;
            this.b_start.Text = "Start Clicking";
            this.b_start.UseVisualStyleBackColor = true;
            this.b_start.Click += new System.EventHandler(this.b_start_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // f1
            // 
            this.AcceptButton = this.b_start;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 111);
            this.Controls.Add(this.tlp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "f1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autoclicker";
            this.tlp.ResumeLayout(false);
            this.tlp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track_count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_time)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp;
        private System.Windows.Forms.Label label_info_click;
        private System.Windows.Forms.Label label_info_time;
        private System.Windows.Forms.Label label_show_count;
        private System.Windows.Forms.Label label_show_time;
        private System.Windows.Forms.TrackBar track_count;
        private System.Windows.Forms.TrackBar track_time;
        private System.Windows.Forms.Button b_start;
        private System.Windows.Forms.Timer timer;
    }
}

