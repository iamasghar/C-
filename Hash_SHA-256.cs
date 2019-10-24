using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreeTierMgtSystem_1701_02_17_09_19_
{
    public partial class Hash_SHA_256 : Form
    {
        public Hash_SHA_256()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String salt = m_SaltHash_TextBox.Text;
            String password = m_UserInput_TextBox.Text;
            //String hashedPassword = EncryptPassword(password, salt);
            String hashedPassword = SHA_256(password);
            m_SaltSHA256Hash_TextBox.Text = hashedPassword;
            Console.Write(hashedPassword.Length);
        }

        private void Hash_SHA_256_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public string EncryptPassword(string password, string saltorusername)
        {
            using (var sha256 = SHA256.Create())
            {
                var saltedPassword = string.Format("{0}{1}", saltorusername, password);
                byte[] saltedPasswordAsBytes = Encoding.UTF8.GetBytes(saltedPassword);
                return Convert.ToBase64String(sha256.ComputeHash(saltedPasswordAsBytes));
            }
        }

        public static string SHA_256(string Plain_text)
        {
            var message = Encoding.ASCII.GetBytes(Plain_text);
            SHA256Managed hashString = new SHA256Managed();
            string hex = "";

            var hashValue = hashString.ComputeHash(message);
            foreach (byte x in hashValue)
            {
                hex += String.Format("{0:x2}", x);
            }
            return hex;
        }
    }
}
