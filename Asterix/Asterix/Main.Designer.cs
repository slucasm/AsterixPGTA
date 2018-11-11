namespace Asterix
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.button_open = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.label_starttime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.trackBar_speedtime = new System.Windows.Forms.TrackBar();
            this.button_tablas = new System.Windows.Forms.Button();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.panel_vertical = new System.Windows.Forms.Panel();
            this.pictureBox_close = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_speedtime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.panel_vertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).BeginInit();
            this.SuspendLayout();
            // 
            // button_open
            // 
            this.button_open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(191)))));
            this.button_open.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(191)))));
            this.button_open.FlatAppearance.BorderSize = 0;
            this.button_open.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_open.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_open.ForeColor = System.Drawing.Color.White;
            this.button_open.Location = new System.Drawing.Point(0, 88);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(250, 45);
            this.button_open.TabIndex = 0;
            this.button_open.Text = "Open";
            this.button_open.UseVisualStyleBackColor = false;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(191)))));
            this.button_start.FlatAppearance.BorderSize = 0;
            this.button_start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_start.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button_start.ForeColor = System.Drawing.Color.White;
            this.button_start.Location = new System.Drawing.Point(0, 217);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(250, 45);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "Start simulation";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label_starttime
            // 
            this.label_starttime.AutoSize = true;
            this.label_starttime.Location = new System.Drawing.Point(505, 206);
            this.label_starttime.Name = "label_starttime";
            this.label_starttime.Size = new System.Drawing.Size(30, 13);
            this.label_starttime.TabIndex = 2;
            this.label_starttime.Text = "Hour";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // trackBar_speedtime
            // 
            this.trackBar_speedtime.Location = new System.Drawing.Point(591, 258);
            this.trackBar_speedtime.Maximum = 1000;
            this.trackBar_speedtime.Minimum = 1;
            this.trackBar_speedtime.Name = "trackBar_speedtime";
            this.trackBar_speedtime.Size = new System.Drawing.Size(104, 45);
            this.trackBar_speedtime.TabIndex = 3;
            this.trackBar_speedtime.Value = 1000;
            this.trackBar_speedtime.Scroll += new System.EventHandler(this.trackBar_speedtime_Scroll);
            // 
            // button_tablas
            // 
            this.button_tablas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(191)))));
            this.button_tablas.FlatAppearance.BorderSize = 0;
            this.button_tablas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button_tablas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_tablas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tablas.ForeColor = System.Drawing.Color.White;
            this.button_tablas.Location = new System.Drawing.Point(0, 147);
            this.button_tablas.Name = "button_tablas";
            this.button_tablas.Size = new System.Drawing.Size(250, 45);
            this.button_tablas.TabIndex = 4;
            this.button_tablas.Text = "View flights";
            this.button_tablas.UseVisualStyleBackColor = false;
            this.button_tablas.Click += new System.EventHandler(this.button_tablas_Click);
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo.Image")));
            this.pictureBox_logo.Location = new System.Drawing.Point(299, 12);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(132, 122);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_logo.TabIndex = 5;
            this.pictureBox_logo.TabStop = false;
            // 
            // panel_vertical
            // 
            this.panel_vertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(191)))));
            this.panel_vertical.Controls.Add(this.button_open);
            this.panel_vertical.Controls.Add(this.button_tablas);
            this.panel_vertical.Controls.Add(this.button_start);
            this.panel_vertical.Location = new System.Drawing.Point(0, 0);
            this.panel_vertical.Name = "panel_vertical";
            this.panel_vertical.Size = new System.Drawing.Size(250, 650);
            this.panel_vertical.TabIndex = 6;
            // 
            // pictureBox_close
            // 
            this.pictureBox_close.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_close.Image")));
            this.pictureBox_close.Location = new System.Drawing.Point(1261, 12);
            this.pictureBox_close.Name = "pictureBox_close";
            this.pictureBox_close.Size = new System.Drawing.Size(27, 23);
            this.pictureBox_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_close.TabIndex = 7;
            this.pictureBox_close.TabStop = false;
            this.pictureBox_close.Click += new System.EventHandler(this.pictureBox_close_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.pictureBox_close);
            this.Controls.Add(this.pictureBox_logo);
            this.Controls.Add(this.trackBar_speedtime);
            this.Controls.Add(this.label_starttime);
            this.Controls.Add(this.panel_vertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_speedtime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.panel_vertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label_starttime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TrackBar trackBar_speedtime;
        private System.Windows.Forms.Button button_tablas;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Panel panel_vertical;
        private System.Windows.Forms.PictureBox pictureBox_close;
    }
}

