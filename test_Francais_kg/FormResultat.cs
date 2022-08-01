using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Linq;

namespace test_Francais_kg
{
    public partial class FormResultat : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FormResultat()
        {
            InitializeComponent();
        }
        test_francaisEntities dc = new test_francaisEntities();
        private void FormResultat_Load(object sender, EventArgs e)
        {
            dataGridViewX1.DataSource = dc.exam.ToList();
        }
    }
}