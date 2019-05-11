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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            if (txtdrname.Text.Length == 0 || comboBox1.SelectedItem.ToString().Length == 0 || txtdrid.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Complete Information");
               
            }
            
            else
            {
                Doctor d = new Doctor(txtdrname.Text, comboBox1.SelectedItem.ToString(), txtdrid.Text);
                FileStream fs = new FileStream("doctor.txt", FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);
                FileStream fs2 = new FileStream("index_dr.txt", FileMode.Append);
                StreamWriter sw2 = new StreamWriter(fs2);
                string str = txtdrname.Text + '*' + txtdrid.Text +'*'+comboBox1.SelectedItem.ToString() ;
                int len = (int)sw.BaseStream.Length;
                sw2.WriteLine(len);
                sw.WriteLine(str);
                sw.Close();
                sw2.Close();
                txtdrname.Clear();
                txtdrid.Clear();
                comboBox1.SelectedItem=null;

                MessageBox.Show("Information Added Sucessfully ");
            }
            //add a doctor in file 
            //cout a message box

                    }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtdrname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdrid_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
