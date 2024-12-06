using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projLeds
{
    public partial class Form1 : Form
    {
        private Leds meusLeds;
        public Form1()
        {
            InitializeComponent();
            meusLeds = new Leds(129);
            atualizaInterface();
        }

        private void atualizaInterface()
        {
            txtDado.Text = meusLeds.getDado().ToString();
            txtDado2.Text = Convert.ToString(meusLeds.getDado(),2);
            txtDado16.Text = Convert.ToString(meusLeds.getDado(), 16);
            chkLed1.Checked = meusLeds.getLed(1);
            chkLed2.Checked = meusLeds.getLed(2);
            chkLed3.Checked = meusLeds.getLed(3);
            chkLed4.Checked = meusLeds.getLed(4);
            chkLed5.Checked = meusLeds.getLed(5);
            chkLed6.Checked = meusLeds.getLed(6);
            chkLed7.Checked = meusLeds.getLed(7);
            chkLed8.Checked = meusLeds.getLed(8);
            picLed1.Image = (meusLeds.getLed(1) ? 
                             projLeds.Properties.Resources.acesa : 
                             projLeds.Properties.Resources.apagada);
            picLed2.Image = (meusLeds.getLed(2) ?
                             projLeds.Properties.Resources.acesa :
                             projLeds.Properties.Resources.apagada);
            picLed3.Image = (meusLeds.getLed(3) ?
                             projLeds.Properties.Resources.acesa :
                             projLeds.Properties.Resources.apagada);
            picLed4.Image = (meusLeds.getLed(4) ?
                             projLeds.Properties.Resources.acesa :
                             projLeds.Properties.Resources.apagada);
            picLed5.Image = (meusLeds.getLed(5) ?
                             projLeds.Properties.Resources.acesa :
                             projLeds.Properties.Resources.apagada);
            picLed6.Image = (meusLeds.getLed(6) ?
                             projLeds.Properties.Resources.acesa :
                             projLeds.Properties.Resources.apagada);
            picLed7.Image = (meusLeds.getLed(7) ?
                             projLeds.Properties.Resources.acesa :
                             projLeds.Properties.Resources.apagada);
            picLed8.Image = (meusLeds.getLed(8) ?
                             projLeds.Properties.Resources.acesa :
                             projLeds.Properties.Resources.apagada);
        }

        private void btnLed1ON_Click(object sender, EventArgs e)
        {
            meusLeds.acender(1);
            atualizaInterface();
        }

        private void btnLed2ON_Click(object sender, EventArgs e)
        {
            meusLeds.acender(2);
            atualizaInterface();
        }

        private void btnLed3ON_Click(object sender, EventArgs e)
        {
            meusLeds.acender(3);
            atualizaInterface();
        }

        private void btnLed4ON_Click(object sender, EventArgs e)
        {
            meusLeds.acender(4);
            atualizaInterface();
        }

        private void btnLed5ON_Click(object sender, EventArgs e)
        {
            meusLeds.acender(5);
            atualizaInterface();
        }

        private void btnLed6ON_Click(object sender, EventArgs e)
        {
            meusLeds.acender(6);
            atualizaInterface();
        }

        private void btnLed7ON_Click(object sender, EventArgs e)
        {
            meusLeds.acender(7);
            atualizaInterface();
        }

        private void btnLed8ON_Click(object sender, EventArgs e)
        {
            meusLeds.acender(8);
            atualizaInterface();
        }

        private void btnLed1OFF_Click(object sender, EventArgs e)
        {
            meusLeds.apagar(1);
            atualizaInterface();
        }

        private void btnLed2OFF_Click(object sender, EventArgs e)
        {
            meusLeds.apagar(2);
            atualizaInterface();
        }

        private void btnLed3OFF_Click(object sender, EventArgs e)
        {
            meusLeds.apagar(3);
            atualizaInterface();
        }

        private void btnLed4OFF_Click(object sender, EventArgs e)
        {
            meusLeds.apagar(4);
            atualizaInterface();
        }

        private void btnLed5OFF_Click(object sender, EventArgs e)
        {
            meusLeds.apagar(5);
            atualizaInterface();
        }

        private void btnLed6OFF_Click(object sender, EventArgs e)
        {
            meusLeds.apagar(6);
            atualizaInterface();
        }

        private void btnLed7OFF_Click(object sender, EventArgs e)
        {
            meusLeds.apagar(7);
            atualizaInterface();
        }

        private void btnLed8OFF_Click(object sender, EventArgs e)
        {
            meusLeds.apagar(8);
            atualizaInterface();
        }
    }
}
