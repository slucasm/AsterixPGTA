namespace Asterix
{
    partial class CAT21_FOM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CAT21_FOM));
            this.label_title = new System.Windows.Forms.Label();
            this.label_AC = new System.Windows.Forms.Label();
            this.label_MN = new System.Windows.Forms.Label();
            this.label_DC = new System.Windows.Forms.Label();
            this.label_PA = new System.Windows.Forms.Label();
            this.pictureBox_close = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label_title.Location = new System.Drawing.Point(90, 10);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(116, 19);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Figure of Merit";
            // 
            // label_AC
            // 
            this.label_AC.AutoSize = true;
            this.label_AC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label_AC.ForeColor = System.Drawing.Color.White;
            this.label_AC.Location = new System.Drawing.Point(25, 35);
            this.label_AC.Name = "label_AC";
            this.label_AC.Size = new System.Drawing.Size(58, 19);
            this.label_AC.TabIndex = 1;
            this.label_AC.Text = "label1";
            // 
            // label_MN
            // 
            this.label_MN.AutoSize = true;
            this.label_MN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label_MN.ForeColor = System.Drawing.Color.White;
            this.label_MN.Location = new System.Drawing.Point(25, 60);
            this.label_MN.Name = "label_MN";
            this.label_MN.Size = new System.Drawing.Size(58, 19);
            this.label_MN.TabIndex = 2;
            this.label_MN.Text = "label2";
            // 
            // label_DC
            // 
            this.label_DC.AutoSize = true;
            this.label_DC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label_DC.ForeColor = System.Drawing.Color.White;
            this.label_DC.Location = new System.Drawing.Point(25, 85);
            this.label_DC.Name = "label_DC";
            this.label_DC.Size = new System.Drawing.Size(58, 19);
            this.label_DC.TabIndex = 3;
            this.label_DC.Text = "label3";
            // 
            // label_PA
            // 
            this.label_PA.AutoSize = true;
            this.label_PA.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label_PA.ForeColor = System.Drawing.Color.White;
            this.label_PA.Location = new System.Drawing.Point(25, 110);
            this.label_PA.Name = "label_PA";
            this.label_PA.Size = new System.Drawing.Size(58, 19);
            this.label_PA.TabIndex = 4;
            this.label_PA.Text = "label4";
            // 
            // pictureBox_close
            // 
            this.pictureBox_close.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_close.Image")));
            this.pictureBox_close.Location = new System.Drawing.Point(272, 4);
            this.pictureBox_close.Name = "pictureBox_close";
            this.pictureBox_close.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_close.TabIndex = 28;
            this.pictureBox_close.TabStop = false;
            this.pictureBox_close.Click += new System.EventHandler(this.pictureBox_close_Click);
            // 
            // CAT21_FOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.pictureBox_close);
            this.Controls.Add(this.label_PA);
            this.Controls.Add(this.label_DC);
            this.Controls.Add(this.label_MN);
            this.Controls.Add(this.label_AC);
            this.Controls.Add(this.label_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CAT21_FOM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAT21_FOM";
            this.Load += new System.EventHandler(this.CAT21_FOM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_AC;
        private System.Windows.Forms.Label label_MN;
        private System.Windows.Forms.Label label_DC;
        private System.Windows.Forms.Label label_PA;
        private System.Windows.Forms.PictureBox pictureBox_close;
    }
}