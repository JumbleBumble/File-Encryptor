using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace FileEncryptor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private byte[] DeriveKeyFromPassword(string password)
        {
            byte[] salt = Encoding.UTF8.GetBytes("Y4E!%-@DRt%ffrLV}M#e9VZy7}ZW9tGY");

            var keyDerivation = new Rfc2898DeriveBytes(password, salt, 10000);

            return keyDerivation.GetBytes(32);
        }

        private SymmetricAlgorithm GetAlgorithm()
        {
            switch (AlgBox.SelectedItem)
            {
                case "AES":
                    return Aes.Create();
                case "Rijndael":
                    return Rijndael.Create();
            }
            return Aes.Create();
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            SymmetricAlgorithm algorithm = GetAlgorithm();

            algorithm.Key = DeriveKeyFromPassword(keyTextBox.Text);//Encoding.UTF8.GetBytes(keyTextBox.Text);
            algorithm.GenerateIV();      

            FileStream inputFile = new FileStream(inputFileTextBox.Text, FileMode.Open);
            byte[] bytesToBeEncrypted = new byte[inputFile.Length + algorithm.IV.Length];
            inputFile.Read(bytesToBeEncrypted, algorithm.IV.Length, (int)inputFile.Length);
            Buffer.BlockCopy(algorithm.IV, 0, bytesToBeEncrypted, 0, algorithm.IV.Length);

            FileStream outputFile = new FileStream(outputFileTextBox.Text, FileMode.Create);
            using (var encryptor = algorithm.CreateEncryptor())
            {
                using (var cryptoStream = new CryptoStream(outputFile, encryptor, CryptoStreamMode.Write))
                {
                    cryptoStream.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                }
            }

            inputFile.Close();
            outputFile.Close();
            
    }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            SymmetricAlgorithm algorithm = GetAlgorithm();

            algorithm.Key = DeriveKeyFromPassword(keyTextBox.Text);//Encoding.UTF8.GetBytes(keyTextBox.Text);

            FileStream inputFile = new FileStream(inputFileTextBox.Text, FileMode.Open);
            byte[] bytesToBeDecrypted = new byte[inputFile.Length];
            inputFile.Read(bytesToBeDecrypted, 0, (int)inputFile.Length);

            algorithm.IV = new byte[16];
            Buffer.BlockCopy(bytesToBeDecrypted, 0, algorithm.IV, 0, 16);

            byte[] ciphertext = new byte[bytesToBeDecrypted.Length - 16];
            Buffer.BlockCopy(bytesToBeDecrypted, 16, ciphertext, 0, ciphertext.Length);

            FileStream outputFile = new FileStream(outputFileTextBox.Text, FileMode.Create);
            try
            {
                using (var decryptor = algorithm.CreateDecryptor())
                {
                    using (var cryptoStream = new CryptoStream(outputFile, decryptor, CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(ciphertext, 0, ciphertext.Length);
                    }
                }
            }
            catch (CryptographicException)
            {
                MessageBox.Show("The key you entered is incorrect for this file.", "Incorrect Key", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            inputFile.Close();
            outputFile.Close();
            
        }

        private void inputFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "All Files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    inputFileTextBox.Text = openFileDialog.FileName;
                }
            }
        }

        private void outputFileButton_Click_1(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "All Files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    outputFileTextBox.Text = saveFileDialog.FileName;
                }
            }
        }
    }
}
