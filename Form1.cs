using System;
using System.Drawing;
using System.Windows.Forms;
namespace Biliardo_Play_Store
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
            progressBar1.BackColor = Color.Orange;
        }

        private void Progress_Timer_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 100)
            {
                progressBar1.Value++;

            }
            else
            {
                Form PlayForm = new Play_BiliardoGame();
                Progress_Timer.Enabled = false;
                this.Hide();
                PlayForm.ShowDialog();
                this.Close();
            }
        }
    }
}
