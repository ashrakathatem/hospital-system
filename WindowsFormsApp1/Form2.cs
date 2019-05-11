using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            dataGridView1.Rows.Clear();
            FileStream fs = new FileStream("doctor.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            while(sr.Peek() != -1)
            {
                string line = sr.ReadLine();
                string[] tmp = line.Split('*');
                dataGridView1.Rows.Add(tmp[0], tmp[1], tmp[2]);
            }
       
            sr.Close();

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.ShowDialog();
            this.Close();
        }

        private void return_btn3_Click(object sender, EventArgs e)
        {

            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

      
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

       

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
      

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

      

       
    }
}
