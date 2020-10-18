namespace KidFormApp
{
    partial class BeginForm
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
            this.yt_Button1 = new KidFormApp.yt_Button();
            this.PlayButton = new KidFormApp.yt_Button();
            this.SuspendLayout();
            // 
            // yt_Button1
            // 
            this.yt_Button1.BackColor = System.Drawing.Color.Purple;
            this.yt_Button1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yt_Button1.ForeColor = System.Drawing.Color.White;
            this.yt_Button1.Location = new System.Drawing.Point(13, 13);
            this.yt_Button1.Name = "yt_Button1";
            this.yt_Button1.Rounding = 100;
            this.yt_Button1.RoundingEnable = true;
            this.yt_Button1.Size = new System.Drawing.Size(100, 30);
            this.yt_Button1.TabIndex = 1;
            this.yt_Button1.Text = "Exit";
            this.yt_Button1.UseVisualStyleBackColor = false;
            this.yt_Button1.Click += new System.EventHandler(this.Yt_Button1_Click);
            this.yt_Button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Yt_Button1_MouseClick);
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.Purple;
            this.PlayButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.ForeColor = System.Drawing.Color.White;
            this.PlayButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PlayButton.Location = new System.Drawing.Point(214, 325);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Rounding = 100;
            this.PlayButton.RoundingEnable = true;
            this.PlayButton.Size = new System.Drawing.Size(150, 48);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.Text = "Play!!!!";
            this.PlayButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlayButton_MouseClick);
            // 
            // BeginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::KidFormApp.Properties.Resources.maxresdefault__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(567, 399);
            this.ControlBox = false;
            this.Controls.Add(this.yt_Button1);
            this.Controls.Add(this.PlayButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BeginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BeginForm";
            this.ResumeLayout(false);

        }

        #endregion

        private yt_Button PlayButton;
        private yt_Button yt_Button1;
    }
}