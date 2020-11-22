using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdevHesapMakinası
{
    public partial class HesapMakinası : Form
    {
        public HesapMakinası()
        {
            InitializeComponent();
        }
       

        private void buttonC_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Trim()!="")
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);

                textBox1.Show(); 
            }
            else
            {
                MessageBox.Show("Sayısal Bir Değer Giriniz");
                
            }
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            
            textBox1.Show();
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            
            textBox1.Show();
        }

        private void buttonartı_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
            textBox1.Show();
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            textBox1.Text+= "3";
           
            textBox1.Show();
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            
            textBox1.Show();
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            
            textBox1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            
            textBox1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            
            textBox1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            
            textBox1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            
            textBox1.Show();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
            
            textBox1.Show();
        }

        private void buttoneksi_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
            textBox1.Show();
        }

        private void buttoncarpı_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
            textBox1.Show();
        }

        private void buttonbolme_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
            textBox1.Show();
        }

        private void buttonYuzde_Click(object sender, EventArgs e)
        {
            textBox1.Text += "%";
            textBox1.Show();
        }

        private void buttonkok_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() == "")
            {
                try
                {
                    string[] son = new string[10];


                    son = textBox1.Text.Split('+', '-', '*', '/', '%');

                    if (textBox1.Text.Contains("+"))
                    {
                        var sayı1 = son[0];
                        var sayı2 = son[1];
                        double s1 = Convert.ToDouble(sayı1);
                        double s2 = Convert.ToDouble(sayı2);
                        double sonuc = s1 + s2;
                        double kare = Math.Sqrt(sonuc);
                        textBox2.Text = Convert.ToString(kare);

                        textBox2.Show();

                    }
                    else if (textBox1.Text.Contains("-"))
                    {
                        var sayı1 = son[0];
                        var sayı2 = son[1];
                        double s1 = Convert.ToDouble(sayı1);
                        double s2 = Convert.ToDouble(sayı2);
                        double sonuc = s1 - s2;
                        double kare = Math.Sqrt(sonuc);
                        textBox2.Text = Convert.ToString(sonuc);

                        textBox2.Show();

                    }
                    else if (textBox1.Text.Contains("*"))
                    {
                        var sayı1 = son[0];
                        var sayı2 = son[1];
                        double s1 = Convert.ToDouble(sayı1);
                        double s2 = Convert.ToDouble(sayı2);
                        double sonuc = s1 * s2;
                        double kare = Math.Sqrt(sonuc);
                        textBox2.Text = Convert.ToString(kare);

                        textBox2.Show();

                    }
                    else if (textBox1.Text.Contains("/"))
                    {
                        var sayı1 = son[0];
                        var sayı2 = son[1];
                        double s1 = Convert.ToDouble(sayı1);
                        double s2 = Convert.ToDouble(sayı2);
                        double sonuc = s1 / s2;
                        double kare = Math.Sqrt(sonuc);
                        textBox2.Text = Convert.ToString(kare);

                        textBox2.Show();

                    }
                    else if (textBox1.Text.Contains("%"))
                    {
                        var sayı1 = son[0];
                        var sayı2 = son[1];
                        double s1 = Convert.ToDouble(sayı1);
                        double s2 = Convert.ToDouble(sayı2);
                        double sonuc = s1 % s2;
                        double kare = Math.Sqrt(sonuc);
                        textBox2.Text = Convert.ToString(kare);

                        textBox2.Show();

                    }
                    else
                    {
                        double a1 = Convert.ToDouble(textBox1.Text);
                        double kare = Math.Sqrt(a1); ;
                        textBox2.Text = Convert.ToString(kare);
                        textBox2.Show();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Sayısal Bir Değer Giriniz");

                }
                textBox1.Clear();
            }
            else if (textBox2.Text.Trim() != "")
            {
                try
                {



                    string[] son = new string[10];


                    son = textBox1.Text.Split('+', '-', '*', '/', '%');

                    if (textBox1.Text.Contains("+"))
                    {

                        var sayı1 = son[0];
                        var sayı2 = son[1];
                        sayı1 = textBox2.Text;
                        double s1 = Convert.ToDouble(sayı1);
                        double s2 = Convert.ToDouble(sayı2);
                        double sonuc = s1 + s2;
                        double kare = Math.Sqrt(sonuc);
                        textBox2.Text = Convert.ToString(sonuc);

                        textBox2.Show();

                    }
                    else if (textBox1.Text.Contains("-"))
                    {
                        var sayı1 = son[0];
                        var sayı2 = son[1];
                        sayı1 = textBox2.Text;
                        double s1 = Convert.ToDouble(sayı1);
                        double s2 = Convert.ToDouble(sayı2);
                        double sonuc = s1 - s2;
                        double kare = Math.Sqrt(sonuc);
                        textBox2.Text = Convert.ToString(sonuc);

                        textBox2.Show();

                    }
                    else if (textBox1.Text.Contains("*"))
                    {
                        var sayı1 = son[0];
                        var sayı2 = son[1];
                        sayı1 = textBox2.Text;
                        double s1 = Convert.ToDouble(sayı1);
                        double s2 = Convert.ToDouble(sayı2);
                        double sonuc = s1 * s2;
                        double kare = Math.Sqrt(sonuc);
                        textBox2.Text = Convert.ToString(sonuc);

                        textBox2.Show();

                    }
                    else if (textBox1.Text.Contains("/"))
                    {
                        var sayı1 = son[0];
                        var sayı2 = son[1];
                        sayı1 = textBox2.Text;
                        double s1 = Convert.ToDouble(sayı1);
                        double s2 = Convert.ToDouble(sayı2);
                        double sonuc = s1 / s2;
                        double kare = Math.Sqrt(sonuc);
                        textBox2.Text = Convert.ToString(sonuc);

                        textBox2.Show();

                    }
                    else if (textBox1.Text.Contains("%"))
                    {
                        var sayı1 = son[0];
                        var sayı2 = son[1];
                        sayı1 = textBox2.Text;
                        double s1 = Convert.ToDouble(sayı1);
                        double s2 = Convert.ToDouble(sayı2);
                        double sonuc = s1 % s2;
                        double kare = Math.Sqrt(sonuc);
                        textBox2.Text = Convert.ToString(sonuc);

                        textBox2.Show();

                    }
                    else
                    {
                        if (textBox1.Text.Trim() == "")
                        {
                            double a = Convert.ToDouble(textBox2.Text);
                            double kare = Math.Sqrt(a);
                            textBox2.Text = Convert.ToString(kare);

                            textBox2.Show();
                        }
                        else
                        {
                            double a1 = Convert.ToDouble(textBox1.Text);
                            double kare = Math.Sqrt(a1); ;
                            textBox2.Text = Convert.ToString(kare);
                            textBox2.Show();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Sayısal Bir Değer Giriniz");
                    throw;
                }
                textBox1.Clear();
            }
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void buttonvirgul_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
            textBox1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonesıttır_Click(object sender, EventArgs e)
        {
            
            if (textBox2.Text.Trim()=="")
            {
                try
                {



                    string[] son = new string[10];


                    son = textBox1.Text.Split('+', '-', '*', '/', '%');

                    if (textBox1.Text.Contains("+"))
                    {
                        var sayı1 = son[0];
                        var sayı2 = son[1];
                        double s1 = Convert.ToDouble(sayı1);
                        double s2 = Convert.ToDouble(sayı2);
                        double sonuc = s1 + s2;
                        textBox2.Text = Convert.ToString(sonuc);

                        textBox2.Show();

                    }
                    else if (textBox1.Text.Contains("-"))
                    {
                        var sayı1 = son[0];
                        var sayı2 = son[1];
                        double s1 = Convert.ToDouble(sayı1);
                        double s2 = Convert.ToDouble(sayı2);
                        double sonuc = s1 - s2;
                        textBox2.Text = Convert.ToString(sonuc);

                        textBox2.Show();

                    }
                    else if (textBox1.Text.Contains("*"))
                    {
                        var sayı1 = son[0];
                        var sayı2 = son[1];
                        double s1 = Convert.ToDouble(sayı1);
                        double s2 = Convert.ToDouble(sayı2);
                        double sonuc = s1 * s2;
                        textBox2.Text = Convert.ToString(sonuc);

                        textBox2.Show();

                    }
                    else if (textBox1.Text.Contains("/"))
                    {
                        var sayı1 = son[0];
                        var sayı2 = son[1];
                        double s1 = Convert.ToDouble(sayı1);
                        double s2 = Convert.ToDouble(sayı2);
                        double sonuc = s1 / s2;
                        textBox2.Text = Convert.ToString(sonuc);

                        textBox2.Show();

                    }
                    else if (textBox1.Text.Contains("%"))
                    {
                        var sayı1 = son[0];
                        var sayı2 = son[1];
                        double s1 = Convert.ToDouble(sayı1);
                        double s2 = Convert.ToDouble(sayı2);
                        double sonuc = s1 % s2;
                        textBox2.Text = Convert.ToString(sonuc);

                        textBox2.Show();

                    }
                    else
                    {
                        textBox2.Text += textBox1.Text;
                        textBox2.Show();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Sayısal Bir Değer Giriniz");
                    throw;
                }
                textBox1.Clear();
            }
            else if(textBox2.Text.Trim() != "")
            {
                try
                {

                   

                    string[] son = new string[10];


                    son = textBox1.Text.Split('+', '-', '*', '/', '%');

                    if (textBox1.Text.Contains("+"))
                    {
                        
                        var sayı1= son[0];
                        var sayı2 = son[1];
                        sayı1 = textBox2.Text;
                        double s1 = Convert.ToDouble(sayı1);
                        double s2 = Convert.ToDouble(sayı2);
                        double sonuc = s1 + s2;
                        textBox2.Text = Convert.ToString(sonuc);

                        textBox2.Show();

                    }
                    else if (textBox1.Text.Contains("-"))
                    {
                        var sayı1 = son[0];
                        var sayı2 = son[1];
                        sayı1 = textBox2.Text;
                        double s1 = Convert.ToDouble(sayı1);
                        double s2 = Convert.ToDouble(sayı2);
                        double sonuc = s1 - s2;
                        textBox2.Text = Convert.ToString(sonuc);

                        textBox2.Show();

                    }
                    else if (textBox1.Text.Contains("*"))
                    {
                        var sayı1 = son[0];
                        var sayı2 = son[1];
                        sayı1 = textBox2.Text;
                        double s1 = Convert.ToDouble(sayı1);
                        double s2 = Convert.ToDouble(sayı2);
                        double sonuc = s1 * s2;
                        textBox2.Text = Convert.ToString(sonuc);

                        textBox2.Show();

                    }
                    else if (textBox1.Text.Contains("/"))
                    {
                        var sayı1 = son[0];
                        var sayı2 = son[1];
                        sayı1 = textBox2.Text;
                        double s1 = Convert.ToDouble(sayı1);
                        double s2 = Convert.ToDouble(sayı2);
                        double sonuc = s1 / s2;
                        textBox2.Text = Convert.ToString(sonuc);

                        textBox2.Show();

                    }
                    else if (textBox1.Text.Contains("%"))
                    {
                        var sayı1 = son[0];
                        var sayı2 = son[1];
                        sayı1 = textBox2.Text;
                        double s1 = Convert.ToDouble(sayı1);
                        double s2 = Convert.ToDouble(sayı2);
                        double sonuc = s1 % s2;
                        textBox2.Text = Convert.ToString(sonuc);

                        textBox2.Show();

                    }
                    else
                    {
                        textBox2.Text = textBox1.Text;
                        textBox2.Show();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Sayısal Bir Değer Giriniz");
                    throw;
                }
                textBox1.Clear();
            }

        }

        private void buttonKareeee_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() == "")
            {
                try
                {
                    string[] son = new string[10];


                    son = textBox1.Text.Split('+', '-', '*', '/', '%');

                    if (textBox1.Text.Contains("+"))
                    {
                        var sayı1 = son[0];
                        var sayı2 = son[1];
                        double s1 = Convert.ToDouble(sayı1);
                        double s2 = Convert.ToDouble(sayı2);
                        double sonuc = s1 + s2;
                        double kare = sonuc * sonuc;
                        textBox2.Text = Convert.ToString(kare);

                        textBox2.Show();

                    }
                    else if (textBox1.Text.Contains("-"))
                    {
                        var sayı1 = son[0];
                        var sayı2 = son[1];
                        double s1 = Convert.ToDouble(sayı1);
                        double s2 = Convert.ToDouble(sayı2);
                        double sonuc = s1 - s2;
                        double kare = sonuc * sonuc;
                        textBox2.Text = Convert.ToString(sonuc);

                        textBox2.Show();

                    }
                    else if (textBox1.Text.Contains("*"))
                    {
                        var sayı1 = son[0];
                        var sayı2 = son[1];
                        double s1 = Convert.ToDouble(sayı1);
                        double s2 = Convert.ToDouble(sayı2);
                        double sonuc = s1 * s2;
                        double kare = sonuc * sonuc;
                        textBox2.Text = Convert.ToString(kare);

                        textBox2.Show();

                    }
                    else if (textBox1.Text.Contains("/"))
                    {
                        var sayı1 = son[0];
                        var sayı2 = son[1];
                        double s1 = Convert.ToDouble(sayı1);
                        double s2 = Convert.ToDouble(sayı2);
                        double sonuc = s1 / s2;
                        double kare = sonuc * sonuc;
                        textBox2.Text = Convert.ToString(kare);

                        textBox2.Show();

                    }
                    else if (textBox1.Text.Contains("%"))
                    {
                        var sayı1 = son[0];
                        var sayı2 = son[1];
                        double s1 = Convert.ToDouble(sayı1);
                        double s2 = Convert.ToDouble(sayı2);
                        double sonuc = s1 % s2;
                        double kare = sonuc * sonuc;
                        textBox2.Text = Convert.ToString(kare);

                        textBox2.Show();

                    }
                    else
                    {
                        double a1 = Convert.ToDouble(textBox1.Text);
                        double kare = a1 * a1;
                        textBox2.Text = Convert.ToString(kare);
                        textBox2.Show();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Sayısal Bir Değer Giriniz");

                }
                textBox1.Clear();
            }
            else if (textBox2.Text.Trim() != "")
            {
                try
                {



                    string[] son = new string[10];


                    son = textBox1.Text.Split('+', '-', '*', '/', '%');

                    if (textBox1.Text.Contains("+"))
                    {

                        var sayı1 = son[0];
                        var sayı2 = son[1];
                        sayı1 = textBox2.Text;
                        double s1 = Convert.ToDouble(sayı1);
                        double s2 = Convert.ToDouble(sayı2);
                        double sonuc = s1 + s2;
                        double kare = sonuc * sonuc;
                        textBox2.Text = Convert.ToString(sonuc);

                        textBox2.Show();

                    }
                    else if (textBox1.Text.Contains("-"))
                    {
                        var sayı1 = son[0];
                        var sayı2 = son[1];
                        sayı1 = textBox2.Text;
                        double s1 = Convert.ToDouble(sayı1);
                        double s2 = Convert.ToDouble(sayı2);
                        double sonuc = s1 - s2;
                        double kare = sonuc * sonuc;
                        textBox2.Text = Convert.ToString(sonuc);

                        textBox2.Show();

                    }
                    else if (textBox1.Text.Contains("*"))
                    {
                        var sayı1 = son[0];
                        var sayı2 = son[1];
                        sayı1 = textBox2.Text;
                        double s1 = Convert.ToDouble(sayı1);
                        double s2 = Convert.ToDouble(sayı2);
                        double sonuc = s1 * s2;
                        double kare = sonuc * sonuc;
                        textBox2.Text = Convert.ToString(sonuc);

                        textBox2.Show();

                    }
                    else if (textBox1.Text.Contains("/"))
                    {
                        var sayı1 = son[0];
                        var sayı2 = son[1];
                        sayı1 = textBox2.Text;
                        double s1 = Convert.ToDouble(sayı1);
                        double s2 = Convert.ToDouble(sayı2);
                        double sonuc = s1 / s2;
                        double kare = sonuc * sonuc;
                        textBox2.Text = Convert.ToString(sonuc);

                        textBox2.Show();

                    }
                    else if (textBox1.Text.Contains("%"))
                    {
                        var sayı1 = son[0];
                        var sayı2 = son[1];
                        sayı1 = textBox2.Text;
                        double s1 = Convert.ToDouble(sayı1);
                        double s2 = Convert.ToDouble(sayı2);
                        double sonuc = s1 % s2;
                        double kare = sonuc * sonuc;
                        textBox2.Text = Convert.ToString(sonuc);

                        textBox2.Show();

                    }
                    else
                    {
                        if (textBox1.Text.Trim() == "")
                        {
                            double a = Convert.ToDouble(textBox2.Text);
                            double kare = a * a;
                            textBox2.Text = Convert.ToString(kare);

                            textBox2.Show();
                        }
                        else
                        {
                            double a1 = Convert.ToDouble(textBox1.Text);
                            double kare = a1 * a1;
                            textBox2.Text = Convert.ToString(kare);
                            textBox2.Show();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Sayısal Bir Değer Giriniz");
                    throw;
                }
                textBox1.Clear();
            }
        }
    }
}
