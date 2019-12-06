namespace WindowsForm
{
    partial class Guns
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gun3 = new System.Windows.Forms.Button();
            this.gun2 = new System.Windows.Forms.Button();
            this.gun1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cashsum = new System.Windows.Forms.Label();
            this.cash = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.gun3);
            this.panel1.Controls.Add(this.gun2);
            this.panel1.Controls.Add(this.gun1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cashsum);
            this.panel1.Controls.Add(this.cash);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 763);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // gun3
            // 
            this.gun3.BackgroundImage = global::WindowsForm.Properties.Resources.iconfinder_gun_military_weapon_military_2969374;
            this.gun3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gun3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(225)))));
            this.gun3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gun3.Location = new System.Drawing.Point(153, 415);
            this.gun3.Name = "gun3";
            this.gun3.Size = new System.Drawing.Size(156, 156);
            this.gun3.TabIndex = 0;
            this.gun3.Click += new System.EventHandler(this.gun3_Click_1);
            // 
            // gun2
            // 
            this.gun2.BackgroundImage = global::WindowsForm.Properties.Resources.iconfinder_army_military_war_weapon_navy_aviation_gun__rifle__2995943;
            this.gun2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gun2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(225)))));
            this.gun2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gun2.Location = new System.Drawing.Point(364, 361);
            this.gun2.Name = "gun2";
            this.gun2.Size = new System.Drawing.Size(323, 256);
            this.gun2.TabIndex = 1;
            this.gun2.Click += new System.EventHandler(this.gun2_Click_1);
            // 
            // gun1
            // 
            this.gun1.BackgroundImage = global::WindowsForm.Properties.Resources.iconfinder_army_military_war_weapon_navy_aviation_gun_machine__2995939;
            this.gun1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gun1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(225)))));
            this.gun1.FlatAppearance.BorderSize = 0;
            this.gun1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gun1.Location = new System.Drawing.Point(680, 379);
            this.gun1.Name = "gun1";
            this.gun1.Size = new System.Drawing.Size(303, 221);
            this.gun1.TabIndex = 2;
            this.gun1.Click += new System.EventHandler(this.gun1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(766, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 67);
            this.label5.TabIndex = 11;
            this.label5.Text = "20$";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(472, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 67);
            this.label4.TabIndex = 10;
            this.label4.Text = "15$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(196, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 67);
            this.label3.TabIndex = 9;
            this.label3.Text = "10$";
            // 
            // cashsum
            // 
            this.cashsum.AutoSize = true;
            this.cashsum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(225)))));
            this.cashsum.Font = new System.Drawing.Font("Comic Sans MS", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cashsum.Location = new System.Drawing.Point(12, 255);
            this.cashsum.Name = "cashsum";
            this.cashsum.Size = new System.Drawing.Size(147, 60);
            this.cashsum.TabIndex = 5;
            this.cashsum.Text = "label3";
            this.cashsum.Click += new System.EventHandler(this.cashsum_Click);
            // 
            // cash
            // 
            this.cash.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cash.Location = new System.Drawing.Point(3, 188);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(150, 78);
            this.cash.TabIndex = 4;
            this.cash.Text = "cash:\r\n";
            this.cash.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(165)))), ((int)(((byte)(15)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(225)))));
            this.label2.Location = new System.Drawing.Point(238, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(604, 92);
            this.label2.TabIndex = 0;
            this.label2.Text = "  Сhoose arsenal";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(165)))), ((int)(((byte)(15)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(225)))));
            this.button1.Location = new System.Drawing.Point(344, 623);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(399, 112);
            this.button1.TabIndex = 3;
            this.button1.Text = "Go ahead!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(83)))), ((int)(((byte)(23)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1043, 171);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(165)))), ((int)(((byte)(15)))));
            this.pictureBox2.Image = global::WindowsForm.Properties.Resources.iconfinder_JD_27_2624867;
            this.pictureBox2.Location = new System.Drawing.Point(802, -7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(181, 178);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(165)))), ((int)(((byte)(15)))));
            this.pictureBox1.Image = global::WindowsForm.Properties.Resources.iconfinder_Famous_Character___Add_On_1_27_25250371;
            this.pictureBox1.Location = new System.Drawing.Point(63, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(165)))), ((int)(((byte)(15)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 34.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(225)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1043, 171);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guns to kill";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Guns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 763);
            this.Controls.Add(this.panel1);
            this.Name = "Guns";
            this.Text = "Guns";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cash;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label cashsum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button gun1;
        private System.Windows.Forms.Button gun3;
        private System.Windows.Forms.Button gun2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}