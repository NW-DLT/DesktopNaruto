namespace KidFormApp
{
    partial class GameForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.yt_Button4 = new KidFormApp.yt_Button();
            this.yt_Button3 = new KidFormApp.yt_Button();
            this.yt_Button2 = new KidFormApp.yt_Button();
            this.yt_Button1 = new KidFormApp.yt_Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.Purple;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(460, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 33);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Счастье: 10";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Purple;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(156, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "00:10";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.Timer3_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Purple;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(156, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "02:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Purple;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(156, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "01:20";
            // 
            // yt_Button4
            // 
            this.yt_Button4.BackColor = System.Drawing.Color.Purple;
            this.yt_Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yt_Button4.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yt_Button4.ForeColor = System.Drawing.Color.White;
            this.yt_Button4.Location = new System.Drawing.Point(12, 12);
            this.yt_Button4.Name = "yt_Button4";
            this.yt_Button4.Rounding = 100;
            this.yt_Button4.RoundingEnable = true;
            this.yt_Button4.Size = new System.Drawing.Size(115, 33);
            this.yt_Button4.TabIndex = 3;
            this.yt_Button4.Text = "меню";
            this.yt_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.yt_Button4.UseVisualStyleBackColor = true;
            this.yt_Button4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Yt_Button4_MouseClick);
            // 
            // yt_Button3
            // 
            this.yt_Button3.BackColor = System.Drawing.Color.Purple;
            this.yt_Button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yt_Button3.ForeColor = System.Drawing.Color.White;
            this.yt_Button3.Location = new System.Drawing.Point(12, 290);
            this.yt_Button3.Name = "yt_Button3";
            this.yt_Button3.Rounding = 100;
            this.yt_Button3.RoundingEnable = true;
            this.yt_Button3.Size = new System.Drawing.Size(138, 36);
            this.yt_Button3.TabIndex = 2;
            this.yt_Button3.Text = "спать";
            this.yt_Button3.UseVisualStyleBackColor = false;
            this.yt_Button3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Yt_Button3_MouseClick);
            // 
            // yt_Button2
            // 
            this.yt_Button2.BackColor = System.Drawing.Color.Purple;
            this.yt_Button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yt_Button2.ForeColor = System.Drawing.Color.White;
            this.yt_Button2.Location = new System.Drawing.Point(12, 248);
            this.yt_Button2.Name = "yt_Button2";
            this.yt_Button2.Rounding = 100;
            this.yt_Button2.RoundingEnable = true;
            this.yt_Button2.Size = new System.Drawing.Size(138, 36);
            this.yt_Button2.TabIndex = 1;
            this.yt_Button2.Text = "кормить";
            this.yt_Button2.UseVisualStyleBackColor = false;
            this.yt_Button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Yt_Button2_MouseClick);
            // 
            // yt_Button1
            // 
            this.yt_Button1.BackColor = System.Drawing.Color.Purple;
            this.yt_Button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yt_Button1.ForeColor = System.Drawing.Color.White;
            this.yt_Button1.Location = new System.Drawing.Point(12, 332);
            this.yt_Button1.Name = "yt_Button1";
            this.yt_Button1.Rounding = 100;
            this.yt_Button1.RoundingEnable = true;
            this.yt_Button1.Size = new System.Drawing.Size(138, 36);
            this.yt_Button1.TabIndex = 0;
            this.yt_Button1.Text = "играть";
            this.yt_Button1.UseVisualStyleBackColor = false;
            this.yt_Button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Yt_Button1_MouseClick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KidFormApp.Properties.Resources.Безымянный;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(586, 380);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.yt_Button4);
            this.Controls.Add(this.yt_Button3);
            this.Controls.Add(this.yt_Button2);
            this.Controls.Add(this.yt_Button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private yt_Button yt_Button1;
        private yt_Button yt_Button2;
        private yt_Button yt_Button3;
        private yt_Button yt_Button4;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label3;
    }
}