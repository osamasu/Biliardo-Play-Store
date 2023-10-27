using System;
using System.Windows.Forms;

namespace Biliardo_Play_Store
{
    public partial class Biliardo_Table : UserControl
    {
        public Biliardo_Table()
        {
            InitializeComponent();
            BTN_PAUSE.Enabled = false;
        }


        public class clsSettings
        {
            public class clsTimePlay
            {
                public byte Seconds = 0;
                public byte Minutes = 0;
                public byte Hours = 0;

                public void _AddSecond()
                {
                    if (this.Seconds < 60)
                        Seconds++;

                    else if (this.Minutes < 60)
                    {
                        this.Seconds = 0;
                        this.Minutes++;
                    }
                    else
                    {
                        this.Hours++;
                        this.Seconds = 0;
                        this.Minutes = 0;
                    }
                }
            }

            public Double PriceForEverySecond = 0.25;
            public Double TotalPrice = 0;
            public clsTimePlay PlayingTime = new clsTimePlay();

        }

        clsSettings GameSettings = new clsSettings();

        private void iconButton3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            BTN_PAUSE.Enabled = true;

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            GameSettings.TotalPrice += GameSettings.PriceForEverySecond;
            Time_String.Text = $"{GameSettings.PlayingTime.Hours.ToString("00")}:{GameSettings.PlayingTime.Minutes.ToString("00")}:{GameSettings.PlayingTime.Seconds.ToString("00")}";


            GameSettings.PlayingTime._AddSecond();

            LB_PRICE.Text = GameSettings.TotalPrice.ToString() + '$';
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            BTN_PAUSE.Enabled = false;

            timer1.Stop();

            Time_String.Text = "00:00:00";

            GameSettings = new clsSettings();


        }

        private void BTN_PAUSE_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
