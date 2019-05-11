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
    public partial class Form6 : Form
    {
        public Form6()
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
       public static  string dr_id;
       public static string dr_name;
       private void button1_Click(object sender, EventArgs e)
       {
           bool found = false;

           if (textBox1.Text == "")
               MessageBox.Show("Please Enter Dr Name ");
           else
           {


               FileStream f = new FileStream("doctor.txt", FileMode.Open);
               StreamReader sr = new StreamReader(f);
               dr_name = textBox1.Text;
               while (sr.Peek() != -1)
               {
                   string line = sr.ReadLine();
                   string[] tmp = line.Split('*');
                   if (dr_name == tmp[0])
                   {
                       dr_id = tmp[1];
                       found = true;
                       break;
                   }
               } sr.Close();
               if (!found)
               {
                   MessageBox.Show("Doctor Name Is Not Found !");
                   textBox1.Clear();


               }

               else
               {

                   dataGridView1.Rows.Clear();
                   dataGridView1.Visible = true;


                   FileStream fss = new FileStream("patient.txt", FileMode.Open);
                   StreamReader srr = new StreamReader(fss);
                   while (srr.Peek() != -1)
                   {

                       string line = srr.ReadLine();
                       string[] tmp = line.Split('@');
                       if (dr_id == tmp[4])
                       {
                           dataGridView1.Rows.Add(tmp[0]);
                       }

                   }
                   srr.Close();
               }
           }
           }

       
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
