using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace TranslateProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool Test()
        {
            string adres = "http://www.google.com";
            try
            {
                WebRequest istek = WebRequest.Create(adres);
                WebResponse yanit = istek.GetResponse();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Test())
            {
                this.Text = "Bağlantı var";
            }
            else
            {
                this.Text = "Bağlantı yok";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://translate.google.com/#tr/en/");

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://translate.google.com/#en/tr/");
        }

        private void RtbTurkce_TextChanged(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("Source").InnerText = RtbTurkce.Text;
            
        }

        private void btnCevir_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                RtbIngilizce.Text = webBrowser1.Document.GetElementById("Result_Box").InnerText;
            }
            if (radioButton2.Checked == true)
            {
                RtbTurkce.Text = webBrowser1.Document.GetElementById("Result_Box").InnerText;
            }
            
        }

        private void RtbIngilizce_TextChanged(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("Source").InnerText = RtbIngilizce.Text;
        }
    }
}
