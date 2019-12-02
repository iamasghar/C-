using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreeTierMgtSystem_1701_02_17_09_19_
{
    public partial class des : Form
    {
        public des()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enc.Text = Encrypt(pt.Text, pwd.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dec.Text = Decrypt(enc.Text, pwd.Text);
        }

        public static string Encrypt(string message, string password)
        {
            // Encode message and password
            byte[] messageBytes = ASCIIEncoding.ASCII.GetBytes(message);
            byte[] passwordBytes = ASCIIEncoding.ASCII.GetBytes(password);

            // Set encryption settings -- Use password for both key and init. vector
            DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
            ICryptoTransform transform = provider.CreateEncryptor(passwordBytes, passwordBytes);
            CryptoStreamMode mode = CryptoStreamMode.Write;

            // Set up streams and encrypt
            MemoryStream memStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memStream, transform, mode);
            cryptoStream.Write(messageBytes, 0, messageBytes.Length);
            cryptoStream.FlushFinalBlock();

            // Read the encrypted message from the memory stream
            byte[] encryptedMessageBytes = new byte[memStream.Length];
            memStream.Position = 0;
            memStream.Read(encryptedMessageBytes, 0, encryptedMessageBytes.Length);

            // Encode the encrypted message as base64 string
            string encryptedMessage = Convert.ToBase64String(encryptedMessageBytes);

            return encryptedMessage;
        }

        public static string Decrypt(string encryptedMessage, string password)
        {
            // Convert encrypted message and password to bytes
            byte[] encryptedMessageBytes = Convert.FromBase64String(encryptedMessage);
            byte[] passwordBytes = ASCIIEncoding.ASCII.GetBytes(password);

            // Set encryption settings -- Use password for both key and init. vector
            DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
            ICryptoTransform transform = provider.CreateDecryptor(passwordBytes, passwordBytes);
            CryptoStreamMode mode = CryptoStreamMode.Write;

            // Set up streams and decrypt
            MemoryStream memStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memStream, transform, mode);
            cryptoStream.Write(encryptedMessageBytes, 0, encryptedMessageBytes.Length);
            cryptoStream.FlushFinalBlock();

            // Read decrypted message from memory stream
            byte[] decryptedMessageBytes = new byte[memStream.Length];
            memStream.Position = 0;
            memStream.Read(decryptedMessageBytes, 0, decryptedMessageBytes.Length);

            // Encode deencrypted binary data to base64 string
            string message = Convert.ToBase64String(decryptedMessageBytes);

            return message;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            stored_procedures sd = new stored_procedures();
            sd.Visible = true;
        }
    }
}
