using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learn
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void EditBatton_Click(object sender, EventArgs e)
        {
            Edit Edit = new Edit();
            Edit.Show();
            this.Hide();
        }
        private void RecordBatton_Click(object sender, EventArgs e)
        {
            Record Record = new Record();
            Record.Show();
            this.Hide();
        }

        private void ViewBatton_Click(object sender, EventArgs e)
        {
            View View = new View();
            View.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school_13ip213DataSet.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.school_13ip213DataSet.Service);
            //делаем кнопки недоступными
            EditBatton.Enabled = false;
            RecordBatton.Enabled= false;
            ViewBatton.Enabled = false;
        }

        private void dataGridService_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kodButton_Click(object sender, EventArgs e)
        {
            //делаем кнопки доступными при верном пароле
            if (kodBox.Text =="0000")
            {
                EditBatton.Enabled = true;
                RecordBatton.Enabled = true;
                ViewBatton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Неверный паролик");
            }
        }
    }
}
