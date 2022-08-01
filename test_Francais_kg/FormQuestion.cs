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
    public partial class FormQuestion : DevComponents.DotNetBar.Metro.MetroForm
    {
        test_francaisEntities dc = new test_francaisEntities();
        public FormQuestion()
        {
            InitializeComponent();
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            lesquestion q = new lesquestion();
            q.question = textBQuestion.Text;
            q.choix1 = textBchoix1.Text;
            q.choix2 = textBchoix2.Text;
            q.choix3 = textBchoix3.Text;
            q.choixrelle = textBresultat.Text;
            q.Type_ques = comboBoxEx1.SelectedItem.ToString();
            dc.lesquestion.AddObject(q);
            dc.SaveChanges();
            dataGridViewX1.DataSource = dc.lesquestion.ToList();
        }

        private void buttonX8_Click(object sender, EventArgs e)
        {
            textBQuestion.Clear();
            textBchoix1.Clear();
            textBchoix2.Clear();
            textBchoix3.Clear();
            textBresultat.Clear();
        }

        private void FormQuestion_Load(object sender, EventArgs e)
        {
            dataGridViewX1.DataSource = dc.lesquestion.ToList();
        }
    }
}