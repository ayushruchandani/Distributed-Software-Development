using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowserContent.encryptDecryptService;
using WebBrowserContent.stockService;

namespace WebBrowserContent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grpEncryptDecrypt.Hide();
            grpStock.Hide();
            webBrowser1.Show();
            if (textBox1.Text != "" && (textBox1.Text.Substring(textBox1.Text.Length - 4)==".com"))
            {
                webBrowser1.Navigate(textBox1.Text);
                this.Text += " -- "+textBox1.Text;
            }
            else
            {
                webBrowser1.DocumentText = "Invalid or empty URL";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Show();
            webBrowser1.Refresh();
            grpEncryptDecrypt.Hide();
            grpStock.Hide();
        }

        private void encryptDecryptBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Hide();
            grpStock.Hide();
            grpEncryptDecrypt.Show();
            richAnswer.Hide();
            Button clickedButton = (Button)sender;
            if(clickedButton == btnEncrypt)
            {
                btnEncrypt_Click(sender, e);
            }
            else if(clickedButton == btnDecrypt)
            {
                btnDecrypt_Click(sender, e);
            }
        }

        private void stockQuoteBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Hide();
            grpEncryptDecrypt.Hide();
            grpStock.Show();
            Button clickedButton = (Button)sender;
            if(clickedButton == btnStock)
            {
                btnStock_Click(sender, e);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Hide();
            grpEncryptDecrypt.Hide();
            grpStock.Hide();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            encryptDecryptService.Service prxy = new encryptDecryptService.Service();
            string encryptText;
            string answer;
            if(txtEncrypt.Text=="")
            {
                richAnswer.Hide();
                lblEncryptAns.Show();
                lblEncryptAns.Text = "Encrypted text cannot be null";
            }
            else
            {
                richAnswer.Show();
                lblEncryptAns.Hide();
                encryptText = txtEncrypt.Text;
                answer = prxy.Encrypt(encryptText);
                //lblEncryptAns.Text = answer;
                richAnswer.Text = "Encrypted Text=\n" + answer;
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            encryptDecryptService.Service prxy = new encryptDecryptService.Service();
            string decryptText;
            string answer;
            if (txtDecrypt.Text == "")
            {
                richAnswer.Hide();
                lblDecryptAns.Show();
                lblDecryptAns.Text = "Decrypted text cannot be null";
            }
            else
            {
                lblDecryptAns.Hide();
                richAnswer.Show();
                decryptText = txtDecrypt.Text;
                answer = prxy.Decrypt(decryptText);
                //lblDecryptAns.Text = answer;
                richAnswer.Text = "Decrypted Text=\n" + answer;
            }
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            stockService.Service proxy = new stockService.Service();
            if (txtStock.Text == "")
            {
                txtStockQuote.Text = "Please enter a stock symbol";
            }
            else
            {
                string answer = proxy.getStockquote(txtStock.Text);
                if(answer.Contains("N/A"))
                { 
                    txtStockQuote.Text = "Company Name = "+txtStock.Text+"\n"+"Stock Price = No Company of this name exists";
                }
                else
                {
                    txtStockQuote.Text = "Company Name = " + txtStock.Text + "\n" + "Stock Price = " + proxy.getStockquote(txtStock.Text);
                }
            }
        }
    }
}
