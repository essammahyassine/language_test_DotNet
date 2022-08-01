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
    public partial class FormIdentifier : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FormIdentifier()
        {
            InitializeComponent();
        }
        int d;
        public static int id_aaaa=100;
        test_francaisEntities dc = new test_francaisEntities();
        private void buttonX5_Click(object sender, EventArgs e)
        {
            string a = textBLoguin.Text;
            string b = textBPassword.Text;
            if (a == "Admin" && b == "0032")
            {
                new FormMenu().Show();
                this.Hide();

            }
            else
            {
                var req = (from t in dc.cordonner where t.nomutilisateur == a && t.pass == b select t).SingleOrDefault();
                id_aaaa = req.id;
                if (req != null)
                {
                    new FormMenuExam().Show();
                    this.Hide();

                }
            }
            
        }

        private void FormIdentifier_Load(object sender, EventArgs e)
        {

        }
    }
}