using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YamlDotNet.Core.Tokens;

namespace Omicron_Pi
{
    public partial class InputDlg : Form
    {
        public InputDlg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Globals.inputResult.Length == 32)
                Globals.inputResult = textBox1.Text;
            else
                Globals.inputResult = textBox1.Text.ToLower();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void inputDlg_Load(object sender, EventArgs e)
        {
            string textToFill = "";
            switch (Globals.inputType)
            {
                case "role":
                    textToFill = "Please enter a new role name";
                    break;
                case "userid":
                    textToFill = "Please enter a new userid";
                    Globals.inputResult = "";
                    break;
                case "steamAPIKey":
                    textToFill = "Please your SteamAPI key.";
                    helpButton.Show();
                    Globals.inputResult = "";
                    break;
            }
            Text = textToFill;
            label1.Text = textToFill;
            textBox1.Text = Globals.inputResult;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                e.Handled = true;
                Globals.inputResult = textBox1.Text.ToLower();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you like to open the webpage where you can get your SteamAPIKey?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://steamcommunity.com/dev/apikey");
            }
        }
    }
}
