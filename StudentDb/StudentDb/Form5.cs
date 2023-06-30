using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDb
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentDataSet.Оценки". При необходимости она может быть перемещена или удалена.
            this.оценкиTableAdapter.Fill(this.studentDataSet.Оценки);
        }

        private void оценкиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.оценкиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentDataSet);

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double grade1 = double.Parse(txtGrade1.Text);
            double grade2 = double.Parse(txtGrade2.Text);
            double grade3 = double.Parse(txtGrade3.Text);

            double averageGrade = (grade1 + grade2 + grade3) / 3;
            txtAverageGrade.Text = averageGrade.ToString();
        }
    }
}
