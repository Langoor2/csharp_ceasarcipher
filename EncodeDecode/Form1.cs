using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncodeDecode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string encryptionKey = textBox3.Text;
            string originalString = textBox1.Text;
            textBox2.Text = Encrypter.getEncryptedString(originalString, encryptionKey);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string encryptionKey = textBox3.Text;
            string encryptedString = textBox2.Text;
            textBox4.Text = Encrypter.getDecryptedString(encryptedString, encryptionKey);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
