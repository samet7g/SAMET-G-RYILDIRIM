using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PERFORMANS_ÖDEVİ_SAMET_GÜRYILDIRIM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 
        int hak  =0 ;
        private void button1_Click(object sender, EventArgs e)
        {
            string kelime = "ÇADIR";
            textBox1.Text = textBox1.Text.ToUpper();
            if (textBox1.Text == "")
            {
                MessageBox.Show("BİR HARF GİRİNİZ");
            }
            else
            {
                if (textBox1.Text == kelime[0].ToString())
                {
                    label1.Text = "Ç";
                }
                else
                {
                    if (textBox1.Text == kelime[1].ToString())
                    {
                        label2.Text = "A";
                    }
                    else
                    {
                        if (textBox1.Text == kelime[2].ToString())
                        {
                            label3.Text = "D";
                        }
                        else
                        {
                            if (textBox1.Text == kelime[3].ToString())
                            {
                                label4.Text = "I";
                            }
                            else
                            {
                                if (textBox1.Text == kelime[4].ToString())
                                {
                                    label5.Text = "R";
                                }
                                else
                                {
                                   
                                    {
                                        hak++;
                                        if (hak == 1)
                                        {
                                            pictureBox1.ImageLocation = "images\\1.png";
                                        }
                                        else if (hak == 2)
                                        {
                                            pictureBox1.ImageLocation = "images\\2.png";
                                        }
                                        else if (hak == 3)
                                        {
                                            pictureBox1.ImageLocation = "images\\3.png";
                                        }
                                        else if (hak == 4)
                                        {
                                            pictureBox1.ImageLocation = "images\\4.png";
                                        }
                                        else if (hak == 5)
                                        {
                                            pictureBox1.ImageLocation = "images\\5.png";
                                        }
                                        else if (hak == 6)
                                        {
                                            pictureBox1.ImageLocation = "images\\6.png";
                                        }
                                        else if (hak == 7)
                                        {
                                            pictureBox1.ImageLocation = "images\\7.png";
                                        }
                                        else if (hak == 8)
                                        {
                                            pictureBox1.ImageLocation = "images\\8.png";
                                        }
                                        else if (hak == 9)
                                        {
                                            pictureBox1.ImageLocation = "images\\9.png";
                                        }
                                        else if (hak == 10)






                                        {
                                            pictureBox1.ImageLocation = "images\\6.png";
                                            button1.Enabled = false;
                                            textBox1.Enabled = false;
                                            MessageBox.Show("Oyunu Kaybettiniz!");
                                            MessageBox.Show("BARDAK", "Cevap");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (label1.Text == "Ç")
            {
                if (label2.Text == "A")
                {
                    if (label3.Text == "D")
                    {
                        if (label4.Text == "I")
                        {
                            if (label5.Text == "R")
                            {
                                
                                
                                    button1.Enabled = false;
                                    textBox1.Enabled = false;
                                    MessageBox.Show("Tebrikler Oyunu Kazandınız!");
                                
                            }
                        }
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
