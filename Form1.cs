using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prime_number_IX_F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void checkButton_Click(object sender, EventArgs e)
        {

            int result = 0;
            bool isNumber = Int32.TryParse(PrimeNumberTextBox.Text, out result);
            if (isNumber)
            {
                
                bool isPrime = true;
                for (int i = 2; i <= result / 2; i++)
                {
                    if (result % i == 0)
                        isPrime = false;
                }

                if (isPrime)
                {
                    this.BackColor = Color.Green;
                    PrimeNumberLabel.Text = PrimeNumberLabel.Text + PrimeNumberTextBox.Text;
                        
                }
                else
                {
                    this.BackColor = Color.Red;
                    HistoryLabel.Text += PrimeNumberTextBox.Text;
                }
            }
            else
            {
                MessageBox.Show("S-a introdus text");
                this.BackColor = Color.Yellow;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrimeNumberTextBox.Text = String.Empty;
        }
    }  
}