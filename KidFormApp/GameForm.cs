using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KidFormApp
{
    public partial class GameForm : Form
    {
        Child potato = new Child(false, false, false);
        public GameForm()
        {
            InitializeComponent();
            KeyPreview = true;
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.D3) Yt_Button1_MouseClick(yt_Button1, null); };
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.D1) Yt_Button2_MouseClick(yt_Button2, null); };
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.D2) Yt_Button3_MouseClick(yt_Button3, null); };
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.Escape) Yt_Button4_MouseClick(yt_Button4, null); };
        }
        private void Yt_Button4_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            BeginForm beginForm = new BeginForm();
            beginForm.Show();
        }
        private void Yt_Button1_MouseClick(object sender, MouseEventArgs e)
        {
            potato.ChildPlay();

            if (play_time == 0)
            {
                play_time = 10;
                timer1.Enabled = true;
                this.BackgroundImage = Properties.Resources._2;
            }
            else
            {
                this.BackgroundImage = Properties.Resources._0;
            }

            textBox1.AppendText(" ");//ваще хз как это работает
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = String.Format("Счастье: {0}", potato.happiness);
        }

        int play_time = 10;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            play_time--;
            if (play_time == 0)
            {
                potato.WantToPlay = true;
                timer1.Enabled = false;
                label1.ForeColor = Color.Green;
            }
            else
            {
                label1.ForeColor = Color.Red;
            }
            label1.Text = String.Format("00:{0}", play_time.ToString("00"));
        }
        int sleep_time = 120;
        private void Timer2_Tick(object sender, EventArgs e)
        {
            sleep_time--;
            int sleep_timeM = sleep_time % 60;
            int sleep_timeH = sleep_time / 60;
            if (sleep_time == 0)
            {
                potato.WantToSleep = true;
                timer2.Enabled = false;
                label2.ForeColor = Color.Green;
            }
            else
            {
                label2.ForeColor = Color.Red;
            }
            label2.Text = String.Format("{0}:{1}",sleep_timeH.ToString("00"), sleep_timeM.ToString("00"));
        }
        private void Yt_Button3_MouseClick(object sender, MouseEventArgs e)
        {
            potato.ChildSleep();

            if (sleep_time == 0)
            {
                sleep_time = 120;
                timer2.Enabled = true;
                this.BackgroundImage = Properties.Resources._2;
            }
            else
            {
                this.BackgroundImage = Properties.Resources._0;
            }
            textBox1.AppendText(" ");
        }

        int feed_time = 80;
        private void Timer3_Tick(object sender, EventArgs e)
        {
            feed_time--;
            int feed_timeM = feed_time % 60;
            int feed_timeH = feed_time / 60;
            if (feed_time == 0)
            {
                potato.hungry = true;
                timer3.Enabled = false;
                label3.ForeColor = Color.Green;
            }
            else
            {
                label3.ForeColor = Color.Red;
            }
            label3.Text = String.Format("{0}:{1}", feed_timeH.ToString("00"), feed_timeM.ToString("00"));
        }

        private void Yt_Button2_MouseClick(object sender, MouseEventArgs e)
        {
            potato.getFood();

            if (feed_time == 0)
            {
                feed_time = 80;
                timer3.Enabled = true;
                this.BackgroundImage = Properties.Resources._2;
            }
            else
            {
                this.BackgroundImage = Properties.Resources._0;
            }
            textBox1.AppendText(" ");
        }
    }
}
