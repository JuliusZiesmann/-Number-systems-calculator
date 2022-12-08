using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RachnerZahlsystemen
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = textBox1;
            textBox1.Focus();
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                textBox1.Focus();   
            }
            
        }
        private void label1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                label1.Focus();

            }
        }
        



        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
                

            } 
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb1.SelectedIndex != 0 && cmb1.SelectedIndex != 1 && cmb1.SelectedIndex != 2
                    && cmb1.SelectedIndex != 3 && cmb1.SelectedIndex != 4 && cmb1.SelectedIndex != 5)
                {
                    int inhalt = int.Parse(textBox1.Text);
                    
                    textBox1.Clear();
                    label4.Text = "Wählen Sie bitte Converter!";
                }

                else if (cmb1.SelectedIndex != 1 && cmb1.SelectedIndex != 2
                    && cmb1.SelectedIndex != 3 && cmb1.SelectedIndex != 4 && cmb1.SelectedIndex != 5)
                {
                    int inhalt = int.Parse(textBox1.Text);
                    string v = Convert.ToString(inhalt, 2);
                    label1.Text = v;
                    textBox1.Clear();
                    label4.Text = inhalt.ToString();
                }
                else if (cmb1.SelectedIndex != 0 && cmb1.SelectedIndex != 2
                    && cmb1.SelectedIndex != 3 && cmb1.SelectedIndex != 4 && cmb1.SelectedIndex != 5)
                {
                    String inhalt = textBox1.Text;
                    string inhalt2 = Convert.ToInt64(inhalt, 2).ToString();
                    label1.Text = inhalt2;
                    label4.Text = inhalt.ToString();
                    textBox1.Clear();
                }

                else if (cmb1.SelectedIndex != 0 && cmb1.SelectedIndex != 1
                    && cmb1.SelectedIndex != 3 && cmb1.SelectedIndex != 4 && cmb1.SelectedIndex != 5)
                {
                    String DecimalNumber = textBox1.Text;
                    int i, j, Octal = 0, dn;
                    int DecimalNumber2 = Convert.ToInt32(DecimalNumber);
                    dn = DecimalNumber2;
                    i = 1;
                    for (j = DecimalNumber2; j > 0; j = j / 8)
                    {
                        Octal = Octal + (j % 8) * i;
                        i *= 10;
                        DecimalNumber2 /= 8;
                    }
                    label1.Text = Convert.ToString(Octal);
                    textBox1.Clear();
                    label4.Text = DecimalNumber.ToString();
                }
                else if (cmb1.SelectedIndex != 0 && cmb1.SelectedIndex != 1
                    && cmb1.SelectedIndex != 2 && cmb1.SelectedIndex != 4 && cmb1.SelectedIndex != 5)
                {
                    int inhalt = int.Parse(textBox1.Text);
                    int Decimal_Number = 0;
                    int BASE = 1;
                    int temp = inhalt;
                    while (temp > 0)
                    {
                        int last_digit = temp % 10;
                        temp /= 10;
                        Decimal_Number += last_digit * BASE;
                        BASE *= 8;
                    }
                    label1.Text = Convert.ToString(Decimal_Number);
                    label4.Text = inhalt.ToString();
                    textBox1.Clear();

                }
                else if (cmb1.SelectedIndex != 0 && cmb1.SelectedIndex != 1
                    && cmb1.SelectedIndex != 2 && cmb1.SelectedIndex != 3 && cmb1.SelectedIndex != 5)
                {

                    int inhalt5 = int.Parse(textBox1.Text);
                    int value = inhalt5;
                    int toBase = 16;

                    string hex = Convert.ToString(value, toBase);
                    label1.Text = hex;
                    label4.Text = inhalt5.ToString();
                    textBox1.Clear();
                }
                else if (cmb1.SelectedIndex != 0 && cmb1.SelectedIndex != 1
                    && cmb1.SelectedIndex != 2 && cmb1.SelectedIndex != 3 && cmb1.SelectedIndex != 4)
                {
                    String hex2 = textBox1.Text;
                    int dez = Int32.Parse(hex2, System.Globalization.NumberStyles.HexNumber);
                    label1.Text = Convert.ToString(dez);
                    textBox1.Clear();
                    label4.Text = hex2.ToString();
                }
                

            }
            catch(Exception ex) {
                label1.Text = ex.Message;
                textBox1.Clear();

            }

        
        }


    }


        

        
    
}



