using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectKirov
{
    public partial class Form1 : Form
    {
        private List<int> grades = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private int CalculatePoints(int pts, bool activity, bool course)
        {
            if (activity) pts += 5;
            if (course) pts += 5;
            if (pts > 100) pts = 100;
            return pts;
        }

        private int GetGrade(int pts)
        {
            if (pts <= 49) return 2;
            if (pts <= 61) return 3;
            if (pts <= 74) return 4;
            if (pts <= 87) return 5;
            return 6;
        }

        private void rbStream1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbStream2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkActivity_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkCourse_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFac.Text) || string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Въведете фаркултетен номер и име!");
                return;
            }

            int points;
            if (!int.TryParse(txtPoints.Text, out points) || points < 0 || points > 100)
            {
                MessageBox.Show("Въведете валидни точки от 0 до 100!");
                return;
            }

            int finalPts = CalculatePoints(points, chkActivity.Checked, chkCourse.Checked);
            int grade = GetGrade(finalPts);
            string[] names = { "", "", "Слаб", "Среден" , "Добър" , "Мн. добър" , "Отличен" };
            string stream = rbStream1.Checked ? "Поток 1" : "Поток 2";

            grades.Add(grade);
            lstStudents.Items.Add($"{txtFac.Text} | {txtName.Text} ({stream}) - {finalPts} m. -> {names[grade]} ({grade})");

            txtFac.Clear();
            txtName.Clear();
            txtPoints.Clear();
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            if(grades.Count == 0)
            {
                MessageBox.Show("Няма въведени студенти!");
                return;
            }

            int sum = 0;
            int failed = 0;
            int excellent = 0;

            foreach (int g in grades)
            {
                sum += g;
                if (g == 2) failed++;
                if (g == 6) excellent++;
            }

            double avg = (double)sum / grades.Count;
            lblSummary.Text = $"Среден успех: {avg:F2} | Скъсани (2): {failed} | Отличници (6): {excellent}";
        }

        private void lblSummary_Click(object sender, EventArgs e)
        {

        }

        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtFac_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPoints_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
