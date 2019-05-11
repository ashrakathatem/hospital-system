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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form8 f8 = new Form8();
            this.Hide();
            f8.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }
        string searching;
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            //write the file 
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || comboBox1.SelectedItem.ToString().Length == 0 || textBox5.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Complete Information");

            }


            else
            {
                Patient p = new Patient(textBox1.Text, comboBox1.SelectedItem.ToString(), textBox2.Text, textBox5.Text);
                comboBox2.Visible = true;
                label3.Visible = true;
                button3.Visible = true;
                FileStream fs = new FileStream("doctor.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                searching = comboBox1.SelectedItem.ToString();

                switch (searching)
                {
                    case "Heart":
                        {
                            while (sr.Peek() != -1)
                            {
                                string line = sr.ReadLine();
                                string[] statements = line.Split('*');
                                if (statements[2] == "Cardiology")
                                {
                                    String idHeart = statements[1];
                                    comboBox2.Items.Add(idHeart);
                                }

                            }
                            break;
                        }
                    case "Skin":
                        {
                            while (sr.Peek() != -1)
                            {
                                string line = sr.ReadLine();
                                string[] statements = line.Split('*');
                                if (statements[2] == "Dermatology")
                                {
                                    String idSkin = statements[1];
                                    comboBox2.Items.Add(idSkin);
                                }

                            }
                            break;
                        }
                    case "Pregnancy":
                        {
                            while (sr.Peek() != -1)
                            {
                                string line = sr.ReadLine();
                                string[] statements = line.Split('*');
                                if (statements[2] == "Obstetric and Gynecology")
                                {
                                    String idFemale = statements[1];
                                    comboBox2.Items.Add(idFemale);
                                }

                            }
                            break;
                        }
                    case "Nervous System":
                        {
                            while (sr.Peek() != -1)
                            {
                                string line = sr.ReadLine();
                                string[] statements = line.Split('*');
                                if (statements[2] == "Neurology")
                                {
                                    String idNeuro = statements[1];
                                    comboBox2.Items.Add(idNeuro);
                                }

                            }
                            break;
                        }
                    case "Bones":
                        {
                            while (sr.Peek() != -1)
                            {
                                string line = sr.ReadLine();
                                string[] statements = line.Split('*');
                                if (statements[2] == "Orthopedic Surgery")
                                {
                                    String idBones = statements[1];
                                    comboBox2.Items.Add(idBones);
                                }

                            }
                            break;
                        }
                    case "Xrays":
                        {
                            while (sr.Peek() != -1)
                            {
                                string line = sr.ReadLine();
                                string[] statements = line.Split('*');
                                if (statements[2] == "Radiology")
                                {
                                    String idXrays = statements[1];
                                    comboBox2.Items.Add(idXrays);
                                }

                            }
                            break;
                        }
                    case "Internal Medicine":
                        {
                            while (sr.Peek() != -1)
                            {
                                string line = sr.ReadLine();
                                string[] statements = line.Split('*');
                                if (statements[2] == "Disorder of the Internal Structure of the Body")
                                {
                                    String idDisorder = statements[1];
                                    comboBox2.Items.Add(idDisorder);
                                }

                            }
                            break;
                        }





                }
                sr.Close();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
             if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || comboBox2.SelectedItem.ToString().Length == 0||comboBox1.SelectedItem.ToString().Length == 0 || textBox5.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Complete Information");

            

            }
            else
            {

                FileStream fss = new FileStream("patient.txt", FileMode.Append);
                StreamWriter sww = new StreamWriter(fss);
                FileStream fs22 = new FileStream("index_pt.txt", FileMode.Append);
                StreamWriter sw22 = new StreamWriter(fs22);
                string strr = textBox1.Text + '@' + comboBox1.SelectedItem.ToString() + '@' + textBox2.Text + '@' + textBox5.Text + "@" + comboBox2.SelectedItem.ToString();
                int len = (int)sww.BaseStream.Length;
                sw22.WriteLine(len);
                sww.WriteLine(strr);
                sww.Close();
                sw22.Close();
                textBox1.Clear();
                textBox2.Clear();
                textBox5.Clear();
                comboBox2.SelectedItem =null;
                comboBox1.SelectedItem = null;  
                MessageBox.Show("Information Added Successfully ");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
