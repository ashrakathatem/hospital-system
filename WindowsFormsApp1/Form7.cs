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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form5 f5 = new Form5();
            this.Hide();
            f5.ShowDialog();
            this.Close();
        }
        public static string  disease; 
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Visible = true;
            disease = comboBox1.SelectedItem.ToString();
            if (comboBox1.SelectedItem.ToString() == null)
            {
                MessageBox.Show("please choice a disease");

            }
            else
            {
                FileStream fss = new FileStream("patient.txt", FileMode.Open);
                StreamReader srr = new StreamReader(fss);
                while (srr.Peek() != -1)
                {

                    string line = srr.ReadLine();
                    string[] tmp = line.Split('@');
                    if (disease == tmp[1])
                    {
                        dataGridView1.Rows.Add(tmp[0]);
                    }

                }
                srr.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
