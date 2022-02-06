using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;

namespace QRCodeOlusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            QRCodeEncoder end = new QRCodeEncoder();
            pictureBox1.Image = end.Encode(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QRCodeDecoder deco = new QRCodeDecoder();
            textBox1.Text = (deco.decode(new QRCodeBitmapImage(pictureBox1.Image as Bitmap)));
        }
    }
}
