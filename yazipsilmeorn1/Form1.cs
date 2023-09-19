using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazipsilmeorn1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnyaz_Click(object sender, EventArgs e)
        {
            txtYazsil.Text = "Medine KANAT";
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            txtYazsil.Text = "";
        }
    }
}
