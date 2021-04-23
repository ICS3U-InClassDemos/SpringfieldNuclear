using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media; // allows us to use a sound player

namespace SpringfieldNuclear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //change background colour of form
            this.BackColor = Color.CadetBlue;

            //create sound player and play sound
            SoundPlayer alertPlayer = new SoundPlayer(Properties.Resources.alert);
            alertPlayer.Play();

            //change the colour of the state labels
            reactor1StateLabel.BackColor = Color.Purple;
            reactor2StateLabel.BackColor = Color.Purple;

            //change the message in output label
            outputLabel.Text = "Meltdown Happening";
            startButton.Visible = false;

            //show changes and then pause
            Refresh();
            Thread.Sleep(1000);

            //change the colour of state lables to white
            reactor1StateLabel.BackColor = Color.White;
            reactor2StateLabel.BackColor = Color.White;

            //show changes and then pause
            Refresh();
            Thread.Sleep(1000);

            //change the colour of the state labels
            reactor1StateLabel.BackColor = Color.Purple;
            reactor2StateLabel.BackColor = Color.Purple;
        }
    }
}
