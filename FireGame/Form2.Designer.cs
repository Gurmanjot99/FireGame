namespace FireGame
{
    partial class Form2
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
            this.Photo = new System.Windows.Forms.PictureBox();
            this.Gun_Reload = new System.Windows.Forms.Button();
            this.Gun_Away = new System.Windows.Forms.Button();
            this.Gun_Shoot = new System.Windows.Forms.Button();
            this.Gun_Spin = new System.Windows.Forms.Button();
            this.Gun_Load = new System.Windows.Forms.Button();
            this.Game_Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // Photo
            // 
            this.Photo.Location = new System.Drawing.Point(132, 172);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(455, 285);
            this.Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Photo.TabIndex = 15;
            this.Photo.TabStop = false;
            // 
            // Gun_Reload
            // 
            this.Gun_Reload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Gun_Reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gun_Reload.Location = new System.Drawing.Point(724, 93);
            this.Gun_Reload.Name = "Gun_Reload";
            this.Gun_Reload.Size = new System.Drawing.Size(119, 46);
            this.Gun_Reload.TabIndex = 14;
            this.Gun_Reload.Text = "Relaod";
            this.Gun_Reload.UseVisualStyleBackColor = false;
            this.Gun_Reload.Click += new System.EventHandler(this.Gun_Reload_Click);
            // 
            // Gun_Away
            // 
            this.Gun_Away.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Gun_Away.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gun_Away.Location = new System.Drawing.Point(558, 93);
            this.Gun_Away.Name = "Gun_Away";
            this.Gun_Away.Size = new System.Drawing.Size(160, 46);
            this.Gun_Away.TabIndex = 13;
            this.Gun_Away.Text = "Shoot Away";
            this.Gun_Away.UseVisualStyleBackColor = false;
            this.Gun_Away.Click += new System.EventHandler(this.Gun_Away_Click);
            // 
            // Gun_Shoot
            // 
            this.Gun_Shoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Gun_Shoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gun_Shoot.Location = new System.Drawing.Point(419, 93);
            this.Gun_Shoot.Name = "Gun_Shoot";
            this.Gun_Shoot.Size = new System.Drawing.Size(133, 46);
            this.Gun_Shoot.TabIndex = 12;
            this.Gun_Shoot.Text = "Shoot";
            this.Gun_Shoot.UseVisualStyleBackColor = false;
            this.Gun_Shoot.Click += new System.EventHandler(this.Gun_Shoot_Click);
            // 
            // Gun_Spin
            // 
            this.Gun_Spin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Gun_Spin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gun_Spin.Location = new System.Drawing.Point(280, 93);
            this.Gun_Spin.Name = "Gun_Spin";
            this.Gun_Spin.Size = new System.Drawing.Size(133, 46);
            this.Gun_Spin.TabIndex = 11;
            this.Gun_Spin.Text = "Spin";
            this.Gun_Spin.UseVisualStyleBackColor = false;
            this.Gun_Spin.Click += new System.EventHandler(this.Gun_Spin_Click);
            // 
            // Gun_Load
            // 
            this.Gun_Load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Gun_Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gun_Load.Location = new System.Drawing.Point(141, 93);
            this.Gun_Load.Name = "Gun_Load";
            this.Gun_Load.Size = new System.Drawing.Size(133, 46);
            this.Gun_Load.TabIndex = 10;
            this.Gun_Load.Text = "Load";
            this.Gun_Load.UseVisualStyleBackColor = false;
            this.Gun_Load.Click += new System.EventHandler(this.Gun_Load_Click);
            // 
            // Game_Start
            // 
            this.Game_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Game_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Game_Start.Location = new System.Drawing.Point(2, 93);
            this.Game_Start.Name = "Game_Start";
            this.Game_Start.Size = new System.Drawing.Size(133, 46);
            this.Game_Start.TabIndex = 9;
            this.Game_Start.Text = "Start ";
            this.Game_Start.UseVisualStyleBackColor = false;
            this.Game_Start.Click += new System.EventHandler(this.Game_Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(158, -6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(583, 85);
            this.label1.TabIndex = 8;
            this.label1.Text = "Play Carefully....... ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 484);
            this.Controls.Add(this.Photo);
            this.Controls.Add(this.Gun_Reload);
            this.Controls.Add(this.Gun_Away);
            this.Controls.Add(this.Gun_Shoot);
            this.Controls.Add(this.Gun_Spin);
            this.Controls.Add(this.Gun_Load);
            this.Controls.Add(this.Game_Start);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Photo;
        private System.Windows.Forms.Button Gun_Reload;
        private System.Windows.Forms.Button Gun_Away;
        private System.Windows.Forms.Button Gun_Shoot;
        private System.Windows.Forms.Button Gun_Spin;
        private System.Windows.Forms.Button Gun_Load;
        private System.Windows.Forms.Button Game_Start;
        private System.Windows.Forms.Label label1;
    }
}