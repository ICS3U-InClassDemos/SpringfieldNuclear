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
using System.Media;

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
            SoundPlayer sp = new SoundPlayer(Properties.Resources.alert);
            sp.Play();

            reactorStateLabel.BackColor = Color.Red;
            outputLabel.Text = "Meltdown Happening";
            Refresh();
            Thread.Sleep(1000);

            reactorStateLabel.BackColor = Color.White;
            outputLabel.Text = "Meltdown Still Happening";
            Refresh();
            Thread.Sleep(1000);

            reactorStateLabel.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(1000);

            reactorStateLabel.BackColor = Color.White;
            Refresh();
            Thread.Sleep(1000);

        }
    }
}
