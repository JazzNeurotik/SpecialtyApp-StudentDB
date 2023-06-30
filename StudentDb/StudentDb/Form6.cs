using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentDb
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentDataSet.Студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter.Fill(this.studentDataSet.Студенты);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewColumn Col = dataGridView1.Columns[0]; switch (listBox1.SelectedIndex)
            {
                case 0: Col = dataGridView1.Columns[0]; break;
                case 1: Col = dataGridView1.Columns[1]; break;
                case 2: Col = dataGridView1.Columns[2]; break;
                case 3: Col = dataGridView1.Columns[3]; break;
                case 4: Col = dataGridView1.Columns[4]; break;
                case 5: Col = dataGridView1.Columns[5]; break;
                case 6: Col = dataGridView1.Columns[6]; break;
                case 7: Col = dataGridView1.Columns[7]; break;
                case 8: Col = dataGridView1.Columns[8]; break;
                case 9: Col = dataGridView1.Columns[9]; break;
                case 10: Col = dataGridView1.Columns[10]; break;
            }
            if (radioButton1.Checked)
                dataGridView1.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
            else
                dataGridView1.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            студентыBindingSource.Filter = "ФИО='" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            студентыBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.ColumnCount; i++) for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    dataGridView1[i, j].Style.BackColor = Color.White; dataGridView1[i, j].Style.ForeColor = Color.Black;
                }
            for (int i = 0; i < dataGridView1.ColumnCount; i++) for (int j = 0; j < dataGridView1.RowCount - 1; j++)
                    if (dataGridView1[i, j].Value.ToString().Contains(textBox1.Text))
                    {
                        dataGridView1[i, j].Style.BackColor = Color.AliceBlue; dataGridView1[i, j].Style.ForeColor = Color.Blue;

                    }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
