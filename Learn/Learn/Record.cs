using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Mapping;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learn
{
    public partial class Record : Form
    {
        public Record()
        {
            InitializeComponent();
        }

        private void BuckButton_Click(object sender, EventArgs e)
        {
            Form MainForm = Application.OpenForms[0];
            MainForm.Show();
            this.Close();
        }

        private void Record_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school_13ip213DataSet2.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.school_13ip213DataSet2.Service);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school_13ip213DataSet1.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.school_13ip213DataSet1.Client);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        int TimeInSecunds(int a, int b)
        {
            return a * 3600 + b * 60;
         
        }
        //Настраиваем кнопку и делаем вычисления перевода времени в секунды
        private void EndButton_Click(object sender, EventArgs e)
        {
            int ch, min, sec;
            ch = Convert.ToInt32(textBox1.Text);
            min = Convert.ToInt32(textBox2.Text);
            sec = TimeInSecunds(ch, min);
            int dur = Convert.ToInt32(textBox3.Text);
            sec = sec + dur;
            textBox4.Text = Convert.ToString((int)sec / 3600);
            sec = sec % 3600;
            textBox5.Text = Convert.ToString((int)sec / 60);
        }
    }
}