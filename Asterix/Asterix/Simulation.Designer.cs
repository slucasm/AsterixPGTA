namespace Asterix
{
    partial class Simulation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Simulation));
            this.button_open = new System.Windows.Forms.Button();
            this.label_starttime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.trackBar_speedtime = new System.Windows.Forms.TrackBar();
            this.button_tablas = new System.Windows.Forms.Button();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.panel_vertical = new System.Windows.Forms.Panel();
            this.pictureBox_simulator = new System.Windows.Forms.PictureBox();
            this.pictureBox_titulo = new System.Windows.Forms.PictureBox();
            this.button_introduction = new System.Windows.Forms.Button();
            this.button_simulation = new System.Windows.Forms.Button();
            this.pictureBox_close = new System.Windows.Forms.PictureBox();
            this.pictureBox_start = new System.Windows.Forms.PictureBox();
            this.pictureBox_pause = new System.Windows.Forms.PictureBox();
            this.pictureBox_restart = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_speedtime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.panel_vertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_simulator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_titulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_restart)).BeginInit();
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
            this.button_open.Image = ((System.Drawing.Image)(resources.GetObject("button_open.Image")));
            this.button_open.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_open.Location = new System.Drawing.Point(0, 200);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(250, 50);
            this.button_open.TabIndex = 0;
            this.button_open.Text = "Open";
            this.button_open.UseVisualStyleBackColor = false;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // label_starttime
            // 
            this.label_starttime.AutoSize = true;
            this.label_starttime.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_starttime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(191)))));
            this.label_starttime.Location = new System.Drawing.Point(515, 45);
            this.label_starttime.Name = "label_starttime";
            this.label_starttime.Size = new System.Drawing.Size(132, 56);
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
            this.button_tablas.Image = ((System.Drawing.Image)(resources.GetObject("button_tablas.Image")));
            this.button_tablas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_tablas.Location = new System.Drawing.Point(0, 300);
            this.button_tablas.Name = "button_tablas";
            this.button_tablas.Size = new System.Drawing.Size(250, 50);
            this.button_tablas.TabIndex = 4;
            this.button_tablas.Text = "View flights";
            this.button_tablas.UseVisualStyleBackColor = false;
            this.button_tablas.Click += new System.EventHandler(this.button_tablas_Click);
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo.Image")));
            this.pictureBox_logo.Location = new System.Drawing.Point(300, 0);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(132, 122);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_logo.TabIndex = 5;
            this.pictureBox_logo.TabStop = false;
            // 
            // panel_vertical
            // 
            this.panel_vertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(191)))));
            this.panel_vertical.Controls.Add(this.pictureBox_simulator);
            this.panel_vertical.Controls.Add(this.pictureBox_titulo);
            this.panel_vertical.Controls.Add(this.button_introduction);
            this.panel_vertical.Controls.Add(this.button_simulation);
            this.panel_vertical.Controls.Add(this.button_open);
            this.panel_vertical.Controls.Add(this.button_tablas);
            this.panel_vertical.Location = new System.Drawing.Point(0, 0);
            this.panel_vertical.Name = "panel_vertical";
            this.panel_vertical.Size = new System.Drawing.Size(250, 650);
            this.panel_vertical.TabIndex = 6;
            // 
            // pictureBox_simulator
            // 
            this.pictureBox_simulator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(191)))));
            this.pictureBox_simulator.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_simulator.Image")));
            this.pictureBox_simulator.Location = new System.Drawing.Point(35, 100);
            this.pictureBox_simulator.Name = "pictureBox_simulator";
            this.pictureBox_simulator.Size = new System.Drawing.Size(180, 25);
            this.pictureBox_simulator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_simulator.TabIndex = 10;
            this.pictureBox_simulator.TabStop = false;
            // 
            // pictureBox_titulo
            // 
            this.pictureBox_titulo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_titulo.Image")));
            this.pictureBox_titulo.Location = new System.Drawing.Point(10, 45);
            this.pictureBox_titulo.Name = "pictureBox_titulo";
            this.pictureBox_titulo.Size = new System.Drawing.Size(230, 60);
            this.pictureBox_titulo.TabIndex = 11;
            this.pictureBox_titulo.TabStop = false;
            // 
            // button_introduction
            // 
            this.button_introduction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(191)))));
            this.button_introduction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(191)))));
            this.button_introduction.FlatAppearance.BorderSize = 0;
            this.button_introduction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button_introduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_introduction.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_introduction.ForeColor = System.Drawing.Color.White;
            this.button_introduction.Image = ((System.Drawing.Image)(resources.GetObject("button_introduction.Image")));
            this.button_introduction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_introduction.Location = new System.Drawing.Point(0, 150);
            this.button_introduction.Name = "button_introduction";
            this.button_introduction.Size = new System.Drawing.Size(250, 50);
            this.button_introduction.TabIndex = 10;
            this.button_introduction.Text = "Introduction";
            this.button_introduction.UseVisualStyleBackColor = false;
            this.button_introduction.Click += new System.EventHandler(this.button_introduction_Click);
            // 
            // button_simulation
            // 
            this.button_simulation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button_simulation.Enabled = false;
            this.button_simulation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(191)))));
            this.button_simulation.FlatAppearance.BorderSize = 0;
            this.button_simulation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button_simulation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_simulation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_simulation.ForeColor = System.Drawing.Color.White;
            this.button_simulation.Image = ((System.Drawing.Image)(resources.GetObject("button_simulation.Image")));
            this.button_simulation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_simulation.Location = new System.Drawing.Point(0, 250);
            this.button_simulation.Name = "button_simulation";
            this.button_simulation.Size = new System.Drawing.Size(250, 50);
            this.button_simulation.TabIndex = 8;
            this.button_simulation.Text = "Simulation";
            this.button_simulation.UseVisualStyleBackColor = false;
            // 
            // pictureBox_close
            // 
            this.pictureBox_close.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_close.Image")));
            this.pictureBox_close.Location = new System.Drawing.Point(1260, 10);
            this.pictureBox_close.Name = "pictureBox_close";
            this.pictureBox_close.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_close.TabIndex = 7;
            this.pictureBox_close.TabStop = false;
            this.pictureBox_close.Click += new System.EventHandler(this.pictureBox_close_Click);
            // 
            // pictureBox_start
            // 
            this.pictureBox_start.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_start.Image")));
            this.pictureBox_start.Location = new System.Drawing.Point(854, 131);
            this.pictureBox_start.Name = "pictureBox_start";
            this.pictureBox_start.Size = new System.Drawing.Size(54, 50);
            this.pictureBox_start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_start.TabIndex = 8;
            this.pictureBox_start.TabStop = false;
            this.pictureBox_start.Click += new System.EventHandler(this.pictureBox_start_Click);
            // 
            // pictureBox_pause
            // 
            this.pictureBox_pause.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_pause.Image")));
            this.pictureBox_pause.Location = new System.Drawing.Point(985, 134);
            this.pictureBox_pause.Name = "pictureBox_pause";
            this.pictureBox_pause.Size = new System.Drawing.Size(65, 65);
            this.pictureBox_pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_pause.TabIndex = 9;
            this.pictureBox_pause.TabStop = false;
            this.pictureBox_pause.Click += new System.EventHandler(this.pictureBox_pause_Click);
            // 
            // pictureBox_restart
            // 
            this.pictureBox_restart.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_restart.Image")));
            this.pictureBox_restart.Location = new System.Drawing.Point(1110, 104);
            this.pictureBox_restart.Name = "pictureBox_restart";
            this.pictureBox_restart.Size = new System.Drawing.Size(50, 48);
            this.pictureBox_restart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_restart.TabIndex = 10;
            this.pictureBox_restart.TabStop = false;
            // 
            // Simulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.pictureBox_restart);
            this.Controls.Add(this.pictureBox_pause);
            this.Controls.Add(this.pictureBox_start);
            this.Controls.Add(this.pictureBox_close);
            this.Controls.Add(this.pictureBox_logo);
            this.Controls.Add(this.trackBar_speedtime);
            this.Controls.Add(this.label_starttime);
            this.Controls.Add(this.panel_vertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Simulation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_speedtime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.panel_vertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_simulator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_titulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_restart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.Label label_starttime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TrackBar trackBar_speedtime;
        private System.Windows.Forms.Button button_tablas;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Panel panel_vertical;
        private System.Windows.Forms.PictureBox pictureBox_close;
        private System.Windows.Forms.Button button_simulation;
        private System.Windows.Forms.Button button_introduction;
        private System.Windows.Forms.PictureBox pictureBox_titulo;
        private System.Windows.Forms.PictureBox pictureBox_simulator;
        private System.Windows.Forms.PictureBox pictureBox_start;
        private System.Windows.Forms.PictureBox pictureBox_pause;
        private System.Windows.Forms.PictureBox pictureBox_restart;
    }
}

