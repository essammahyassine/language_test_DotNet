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
    public partial class FormMenuExam : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FormMenuExam()
        {
            InitializeComponent();
        }
        public static string nomexam;
        test_francaisEntities dc = new test_francaisEntities();
        private void buttonX3_Click(object sender, EventArgs e)
        {
            nomexam = "Culture";
            int id_kkk = FormIdentifier.id_aaaa;
            //MessageBox.Show(id_kkk.ToString());
            var req = (from t in dc.cordonner where t.id == id_kkk select t).FirstOrDefault();

            var re = (from t in dc.exam where t.Type_ques == nomexam && t.nom==req.nom && t.prenom==req.prenom select t).FirstOrDefault();

            if (re== null)
            {
                
                
                new FormExamain().Show();
            }
        }

        private void FormMenuExam_Load(object sender, EventArgs e)
        {

        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            nomexam = "Langue";
            int id_kkk = FormIdentifier.id_aaaa;
            //MessageBox.Show(id_kkk.ToString());
            var req = (from t in dc.cordonner where t.id == id_kkk select t).FirstOrDefault();

            var re = (from t in dc.exam where t.Type_ques == nomexam && t.nom == req.nom && t.prenom == req.prenom select t).FirstOrDefault();

            //var re = (from t in dc.exam where t.Type_ques == nomexam && t.id == id_kkk select t).FirstOrDefault();

            if (re == null)
            {
                
                //nomexam = "Langue";
                new FormExamain().Show();
            }
        }
    }
}