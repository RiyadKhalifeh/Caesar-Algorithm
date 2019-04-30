using System;
using System.Linq;
using System.Windows.Forms;

namespace خوازمية_قيصر
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int Mod(int a, int n)
        {
            return a - (int)Math.Floor((double)a / n) * n; 
        }

        string alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";     
        //string Arabicalphabets = "أبتثجحخدذرزسشصضطظعغفقكلمنه";

        private void button1_Click(object sender, EventArgs e)     //زر التشفير
        {
            textBoxCipherText.Clear();
            textBoxDecryptText.Clear();
            if (textBoxPlanText.Text == "" || textBoxKey.Text == "")
                MessageBox.Show("بعض الحقول المطلوبة فارغة");
            else
            {
                string CharToUpper=textBoxPlanText.Text.ToUpper();
                for (int i = 0; i < CharToUpper.Length; i++)
                {
                    if (alphabets.Contains(CharToUpper[i]))
                    {
                        int PlanNumber = alphabets.IndexOf(CharToUpper[i]);
                        textBoxCipherText.Text += alphabets[Mod(PlanNumber + Convert.ToInt32(textBoxKey.Text), 26)];
                    }
                    else
                        textBoxCipherText.Text += CharToUpper[i];
                }
            }
        }

        private void buttonCipherRext_Click(object sender, EventArgs e)  //كود زر فك التشفير
        {
            if (textBoxCipherText.Text == "" || textBoxKey.Text == "")
                MessageBox.Show("بعض الحقول المطلوبة فارغة");
            else
            {
                string CharToUpper = textBoxCipherText.Text.ToUpper();

                for (int i = 0; i < CharToUpper.Length; i++)
                {
                    if (alphabets.Contains(CharToUpper[i]) == true)
                    {
                        int CipherNumber = alphabets.IndexOf(CharToUpper[i]);
                        textBoxDecryptText.Text += alphabets[Mod(CipherNumber - Convert.ToInt32(textBoxKey.Text), 26)];
                    }
                    else
                        textBoxDecryptText.Text += CharToUpper[i];  
                }

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBoxCipherText.Text = "";
            textBoxKey.Clear();
            textBoxPlanText.Text = "";
            textBoxDecryptText.Text = "";
            buttonCipherRext.Enabled = false;
        }
    }
}
