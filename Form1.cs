using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taraftar_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int saniye = 0;
        private void radiots_CheckedChanged(object sender, EventArgs e)
        {
            timer4.Enabled = true;
            axWindowsMediaPlayer1.URL = "C:\\Users\\bekoo\\Desktop\\DERS\\C# Uygulama\\Taraftar Timer\\müzik\\ts.mp3";
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            foreach (Control control in Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    button.Text = "Tranzonspor";
                    button.ForeColor = Color.ForestGreen;
                }
            }
        }
    
        private void timer4_Tick(object sender, EventArgs e)
        {
            saniye = Convert.ToInt32(label1.Text);
            saniye++;
            label1.Text=saniye.ToString();
            if (saniye % 10 == 0)
            {
                button1.BackColor = Color.DarkRed;
                button2.BackColor = Color.LightBlue;
                button3.BackColor = Color.DarkRed;
                button4.BackColor = Color.LightBlue;
                button5.BackColor = Color.DarkRed;
                button6.BackColor = Color.LightBlue;
                button7.BackColor = Color.DarkRed;
                button8.BackColor = Color.LightBlue;
                button9.BackColor = Color.DarkRed;
                button10.BackColor = Color.LightBlue;
                button11.BackColor = Color.DarkRed;
                button12.BackColor = Color.LightBlue;
                button13.BackColor = Color.DarkRed;
                button14.BackColor = Color.LightBlue;
                button15.BackColor = Color.DarkRed;
                button16.BackColor = Color.LightBlue;
                button17.BackColor = Color.DarkRed;
                button18.BackColor = Color.LightBlue;
                button19.BackColor = Color.DarkRed;
                button20.BackColor = Color.LightBlue;
            }
            else if (saniye % 10 == 5)
            {
                button1.BackColor = Color.LightBlue; 
                button2.BackColor = Color.DarkRed;
                button3.BackColor = Color.LightBlue;
                button4.BackColor = Color.DarkRed;
                button5.BackColor = Color.LightBlue;
                button6.BackColor = Color.DarkRed;
                button7.BackColor = Color.LightBlue;
                button8.BackColor = Color.DarkRed;
                button9.BackColor = Color.LightBlue;
                button10.BackColor = Color.DarkRed;
                button11.BackColor = Color.LightBlue;
                button12.BackColor = Color.DarkRed;
                button13.BackColor = Color.LightBlue;
                button14.BackColor = Color.DarkRed;
                button15.BackColor = Color.LightBlue;
                button16.BackColor = Color.DarkRed;
                button17.BackColor = Color.LightBlue;
                button18.BackColor = Color.DarkRed;
                button19.BackColor = Color.LightBlue;
                button20.BackColor = Color.DarkRed;
            }

                
        }

        private void radiofb_CheckedChanged(object sender, EventArgs e)
        {
            timer3.Enabled = true;
            axWindowsMediaPlayer1.URL = "C:\\Users\\bekoo\\Desktop\\DERS\\C# Uygulama\\Taraftar Timer\\müzik\\fb.mp3";
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer4.Enabled = false;
            foreach (Control control in Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    button.Text = "Fenerbahçe";
                    button.ForeColor = Color.ForestGreen;
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            saniye = Convert.ToInt32(label1.Text);
            saniye++;
            label1.Text = saniye.ToString();
            if (saniye % 10 == 0)
            {
                button1.BackColor = Color.Yellow;
                button2.BackColor = Color.Navy;
                button3.BackColor = Color.Yellow;
                button4.BackColor = Color.Navy;
                button5.BackColor = Color.Yellow;
                button6.BackColor = Color.Navy;
                button7.BackColor = Color.Yellow;
                button8.BackColor = Color.Navy;
                button9.BackColor = Color.Yellow;
                button10.BackColor = Color.Navy;
                button11.BackColor = Color.Yellow;
                button12.BackColor = Color.Navy;
                button13.BackColor = Color.Yellow;
                button14.BackColor = Color.Navy;
                button15.BackColor = Color.Yellow;
                button16.BackColor = Color.Navy;
                button17.BackColor = Color.Yellow;
                button18.BackColor = Color.Navy;
                button19.BackColor = Color.Yellow;
                button20.BackColor = Color.Navy;
            }
            else if (saniye % 10 == 5)
            {
                button1.BackColor = Color.Navy;
                button2.BackColor = Color.Yellow;
                button3.BackColor = Color.Navy;
                button4.BackColor = Color.Yellow;
                button5.BackColor = Color.Navy;
                button6.BackColor = Color.Yellow;
                button7.BackColor = Color.Navy;
                button8.BackColor = Color.Yellow;
                button9.BackColor = Color.Navy;
                button10.BackColor = Color.Yellow;
                button11.BackColor = Color.Navy;
                button12.BackColor = Color.Yellow;
                button13.BackColor = Color.Navy;
                button14.BackColor = Color.Yellow;
                button15.BackColor = Color.Navy;
                button16.BackColor = Color.Yellow;
                button17.BackColor = Color.Navy;
                button18.BackColor = Color.Yellow;
                button19.BackColor = Color.Navy;
                button20.BackColor = Color.Yellow;
            }


        }

        private void radiobjk_CheckedChanged(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            axWindowsMediaPlayer1.URL = "C:\\Users\\bekoo\\Desktop\\DERS\\C# Uygulama\\Taraftar Timer\\müzik\\bjk.mp3";
            timer1.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            foreach (Control control in Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    button.Text = "Beşiktaş";
                    button.ForeColor = Color.ForestGreen;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            saniye = Convert.ToInt32(label1.Text);
            saniye++;
            label1.Text = saniye.ToString();
            if (saniye % 10 == 0)
            {
                button1.BackColor = Color.Black;
                button2.BackColor = Color.WhiteSmoke;
                button3.BackColor = Color.Black;
                button4.BackColor = Color.WhiteSmoke;
                button5.BackColor = Color.Black;
                button6.BackColor = Color.WhiteSmoke;
                button7.BackColor = Color.Black;
                button8.BackColor = Color.WhiteSmoke;
                button9.BackColor = Color.Black;
                button10.BackColor = Color.WhiteSmoke;
                button11.BackColor = Color.Black;
                button12.BackColor = Color.WhiteSmoke;
                button13.BackColor = Color.Black;
                button14.BackColor = Color.WhiteSmoke;
                button15.BackColor = Color.Black;
                button16.BackColor = Color.WhiteSmoke;
                button17.BackColor = Color.Black;
                button18.BackColor = Color.WhiteSmoke;
                button19.BackColor = Color.Black;
                button20.BackColor = Color.WhiteSmoke;
            }
            else if (saniye % 10 == 5)
            {
                button1.BackColor = Color.WhiteSmoke;
                button2.BackColor = Color.Black;
                button3.BackColor = Color.WhiteSmoke;
                button4.BackColor = Color.Black;
                button5.BackColor = Color.WhiteSmoke;
                button6.BackColor = Color.Black;
                button7.BackColor = Color.WhiteSmoke;
                button8.BackColor = Color.Black;
                button9.BackColor = Color.WhiteSmoke;
                button10.BackColor = Color.Black;
                button11.BackColor = Color.WhiteSmoke;
                button12.BackColor = Color.Black;
                button13.BackColor = Color.WhiteSmoke;
                button14.BackColor = Color.Black;
                button15.BackColor = Color.WhiteSmoke;
                button16.BackColor = Color.Black;
                button17.BackColor = Color.WhiteSmoke;
                button18.BackColor = Color.Black;
                button19.BackColor = Color.WhiteSmoke;
                button20.BackColor = Color.Black;
            }
        }

        private void radiogs_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            axWindowsMediaPlayer1.URL="C:\\Users\\bekoo\\Desktop\\DERS\\C# Uygulama\\Taraftar Timer\\müzik\\gs.mp3";
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            foreach (Control control in Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    button.Text = "Galatasaray";
                    button.ForeColor = Color.ForestGreen;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye = Convert.ToInt32(label1.Text);
            saniye++;
            label1.Text = saniye.ToString();
            if (saniye % 10 == 0)
            {
                button1.BackColor = Color.Yellow;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Yellow;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Yellow;
                button6.BackColor = Color.Red;
                button7.BackColor = Color.Yellow;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Yellow;
                button10.BackColor = Color.Red;
                button11.BackColor = Color.Yellow;
                button12.BackColor = Color.Red;
                button13.BackColor = Color.Yellow;
                button14.BackColor = Color.Red;
                button15.BackColor = Color.Yellow;
                button16.BackColor = Color.Red;
                button17.BackColor = Color.Yellow;
                button18.BackColor = Color.Red;
                button19.BackColor = Color.Yellow;
                button20.BackColor = Color.Red;
            }
            else if (saniye % 10 == 5)
            {
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Yellow;
                button3.BackColor = Color.Red;
                button4.BackColor = Color.Yellow;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Yellow;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Yellow;
                button9.BackColor = Color.Red;
                button10.BackColor = Color.Yellow;
                button11.BackColor = Color.Red;
                button12.BackColor = Color.Yellow;
                button13.BackColor = Color.Red;
                button14.BackColor = Color.Yellow;
                button15.BackColor = Color.Red;
                button16.BackColor = Color.Yellow;
                button17.BackColor = Color.Red;
                button18.BackColor = Color.Yellow;
                button19.BackColor = Color.Red;
                button20.BackColor = Color.Yellow;
            }
        }        
    }
}
