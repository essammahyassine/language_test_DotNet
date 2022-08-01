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
    public partial class FormCordoner : DevComponents.DotNetBar.Metro.MetroForm
    {
        int d;
        test_francaisEntities dc = new test_francaisEntities();
        public FormCordoner()
        {
            InitializeComponent();
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            try
            {
                cordonner c = new cordonner();
                c.cin = textBoxXcin.Text;
                c.Imatricule = textBImatricule.Text;
                c.nom = textBoxXNom.Text;
                c.prenom = textBprenom.Text;
                c.nomutilisateur = textBLogin.Text;
                c.pass = textBpassword.Text;
                c.sexe = comboBoxEx1.SelectedItem.ToString();
                c.datenaissance = dateTimePicker1.Value.ToShortDateString();
                dc.cordonner.AddObject(c);
                dc.SaveChanges();
            }
            catch { }

        }

        private void buttonX8_Click(object sender, EventArgs e)
        {
            textBoxXcin.Clear();
            textBImatricule.Clear();
            textBoxXNom.Clear();
            textBprenom.Clear();
            textBLogin.Clear();
            textBpassword.Clear();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            try
            {
                var re = (from t in dc.question_exam where t.id_n == d select t).SingleOrDefault();
                dc.question_exam.Attach(re);
                dc.question_exam.DeleteObject(re);
                dc.SaveChanges();
                var req = (from t in dc.cordonner where t.id == d select t).SingleOrDefault();

                dc.cordonner.Attach(req);
                dc.cordonner.DeleteObject(req);
                dc.SaveChanges();
            }
            catch { }
        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                d = int.Parse(dataGridViewX1.Rows[e.RowIndex].Cells["id"].Value.ToString());
            }
            catch { }
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewX1.DataSource = dc.cordonner.ToList();
            }
            catch { }
        }
    }
}