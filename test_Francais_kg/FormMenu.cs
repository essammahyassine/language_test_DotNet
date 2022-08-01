using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace test_Francais_kg
{
    public partial class FormMenu : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            new FormCordoner().ShowDialog();
        }

        private void buttonX8_Click(object sender, EventArgs e)
        {
            new FormQuestion().ShowDialog();
        }

        private void buttonX13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX14_Click(object sender, EventArgs e)
        {
            new FormIdentifier().Show();
            this.Hide();
        }

        private void buttonX9_Click(object sender, EventArgs e)
        {
            new FormResultat().ShowDialog();
            
        }
    }
}