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
    public partial class BeginForm : Form
    {
        public BeginForm()
        {
            InitializeComponent();
        }
        private void PlayButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            GameForm gameForm = new GameForm();
            gameForm.Show();
        }

        private void Yt_Button1_Click(object sender, EventArgs e)
        {
        }

        private void Yt_Button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
        }
    }
}
