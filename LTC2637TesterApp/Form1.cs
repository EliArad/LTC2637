using LTC2637Api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTC2637TesterApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbCommand.DataSource = Enum.GetNames(typeof(LTC2637.Command));
            cbDac.DataSource = Enum.GetNames(typeof(LTC2637.DAC));
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            byte slaveAddress = 0;
            if (!byte.TryParse(tbSlaveAddress.Text, out slaveAddress))
            {
                MessageBox.Show("Slave Address should be integer");
            }
                byte msData, lsData = 0x00;
            if (byte.TryParse(tbMSData.Text, out msData) && byte.TryParse(tbLSData.Text, out lsData))
            {
                LTC2637 ltc2637 = new LTC2637(slaveAddress);
                ltc2637.Write((LTC2637.Command)cbCommand.SelectedItem, (LTC2637.DAC)cbDac.SelectedItem, msData, lsData);
            }
            else
            {
                MessageBox.Show("MS/LS Data should be integer value");
            }
        }
    }
}
