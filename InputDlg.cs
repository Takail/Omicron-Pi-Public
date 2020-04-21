using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            Globals.inputResult = textBox1.Text.ToLower();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void NewNameDlg_Load(object sender, EventArgs e)
        {
            if (Globals.inputType == "role")
            {
                Text = "Please enter a new role name";
                label1.Text = "Please enter a new role name";
                textBox1.Text = Globals.inputResult;
            }
            else
            {
                Text = "Please enter a new userid";
                label1.Text = "Please enter a new userid";
            }
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
    }
}
