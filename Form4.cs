using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_login
{
    public partial class Form4 : Form
    {
        public Form4(String outputText)
        {
            InitializeComponent();
            Output.Text = outputText;
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Output_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
