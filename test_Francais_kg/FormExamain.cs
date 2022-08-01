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
    public partial class FormExamain : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FormExamain()
        {
            InitializeComponent();
        }
        
        test_francaisEntities dc = new test_francaisEntities();
        string choix_reel;
        string te;
        private void FormExamain_Load(object sender, EventArgs e)
        {
            te=FormMenuExam.nomexam;
            int id_kkk = FormIdentifier.id_aaaa;
            //MessageBox.Show(id_kkk.ToString());
            var re = (from t in dc.cordonner where t.id == id_kkk select t).FirstOrDefault();
            string a = re.cin.ToString();
            label2.Text += a;
            string b = re.nom.ToString();
            label11.Text += b;
            string c = re.prenom.ToString();
            label12.Text += c;
            var req = (from t in dc.lesquestion where t.Type_ques==te select t).FirstOrDefault();
            textBoxX1.Text = req.question;
            radioButton1.Text=req.choix1;
            radioButton2.Text=req.choix2;
            radioButton3.Text = req.choix3;
            choix_reel = req.choixrelle;

        }
        int d = 0;
        private void buttonX5_Click(object sender, EventArgs e)
        {
            try
            {
                int id_kkk = FormIdentifier.id_aaaa;

                var r = (from t in dc.lesquestion where  t.Type_ques == te select t).Count();
                d++;
                if (d > r - 1)
                {
                    d = r - 1;
                    int id_k = FormIdentifier.id_aaaa;
                    
                    var re = (from t in dc.question_exam where t.id_n == id_k && t.Type_ques == te select t.compteur).Sum();
                    buttonX5.Enabled = false;
                    buttonX8.Enabled = false;
                    MessageBox.Show(re.ToString() + "/20");

                    //int id_kkk = FormIdentifier.id_aaaa;

                  //MessageBox.Show(id_kkk.ToString());
                  var rr = (from t in dc.cordonner where t.id == id_kkk select t).SingleOrDefault();
                  
                    exam exa = new exam();
                    exa.cin=rr.cin;
                    exa.nom=rr.nom;
                    exa.prenom=rr.prenom;
                    exa.Type_ques = te;
                    exa.Note=re;
                    dc.exam.AddObject(exa);
                    dc.SaveChanges();
                    
                }
                else
                {
                    groupBox1.Text = "Question" + " " + (d + 1).ToString();
                    var req = (from t in dc.lesquestion where t.Type_ques == te select t).ToList();
                    textBoxX1.Text = req[d].question;
                    radioButton1.Text = req[d].choix1;
                    radioButton2.Text = req[d].choix2;
                    radioButton3.Text = req[d].choix3;
                    choix_reel = req[d].choixrelle;
                    buttonX8.Enabled = true;
                    
                   
                }
            }
            catch { }
            

        }

        private void buttonX8_Click(object sender, EventArgs e)
        {
            int id_kkkkk=FormIdentifier.id_aaaa;
            question_exam qe = new question_exam();
            if (radioButton1.Checked == true) { qe.choix1 = radioButton1.Text; }
            if (radioButton2.Checked == true) { qe.choix1 = radioButton2.Text; }
            if (radioButton3.Checked == true) { qe.choix1 = radioButton3.Text; }
            qe.choixrelle = choix_reel;
            qe.id_n = id_kkkkk;
            qe.Type_ques = te;
            if (qe.choix1 == qe.choixrelle) { qe.compteur = 1; } else { qe.compteur = 0; }
            qe.question = textBoxX1.Text;
            dc.question_exam.AddObject(qe);
            dc.SaveChanges();
            buttonX8.Enabled = false;


            
        }
    }
}