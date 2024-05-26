using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnDeCrypt
{
    enum Algorithm
    {
        Aes,
        AesManaged,
        DES,
        TripleDES,
        RijndaelManaged
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboCipherAlgorithm.SelectedIndex = 0;
        }

        private void inputDecryptedASCII_TextChanged(object sender, EventArgs e)
        {
            string txt = ((TextBox) sender).Text;
            byte[] bytes = Encoding.GetEncoding(1252).GetBytes(txt);
            inputDecryptedHEX.Text = BytesToHexString(bytes);
        }

        private void inputEncryptedASCII_TextChanged(object sender, EventArgs e)
        {
            string txt = ((TextBox)sender).Text;
            byte[] bytes = Encoding.GetEncoding(1252).GetBytes(txt);
            inputEncryptedHEX.Text = BytesToHexString(bytes);
        }

        private void comboCipherAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SymmetricAlgorithm alg = GetAlgorithm())
            {
                comboKeySize.Items.Clear();

                foreach (KeySizes ks in alg.LegalKeySizes)
                {
                    int min = ks.MinSize;
                    int max = ks.MaxSize;
                    int step = ks.SkipSize;

                    if (step == 0)
                    {
                        comboKeySize.Items.Add(min);
                        continue;
                    }

                    for (int i = min; i <= max; i += step)
                    {
                        comboKeySize.Items.Add(i);
                    }
                }

                comboKeySize.SelectedIndex = 0;
            }
        }

        private SymmetricAlgorithm GetAlgorithm(bool generateKeyAndIV=true)
        {
            SymmetricAlgorithm result;

            switch((Algorithm)comboCipherAlgorithm.SelectedIndex)
            {
                default:
                case Algorithm.Aes:
                    {
                        result = new AesCryptoServiceProvider();
                        
                        break;
                    }
                case Algorithm.AesManaged:
                    {
                        result = new AesManaged();
                        break;
                    }
                case Algorithm.DES:
                    {
                        result = new DESCryptoServiceProvider();
                        break;
                    }
                case Algorithm.TripleDES:
                    {
                        result = new TripleDESCryptoServiceProvider();
                        break;
                    }
                case Algorithm.RijndaelManaged:
                    {
                        result = new RijndaelManaged();
                        break;
                    }
            }

            result.Padding = PaddingMode.Zeros;

            if (generateKeyAndIV)
            {
                inputKey.Text = BytesToHexString(result.Key); 
                inputIV.Text = BytesToHexString(result.IV);
            }
            else
            {
                result.KeySize = int.Parse(comboKeySize.Text);
                result.Key = HexStringToBytes(inputKey.Text);
                result.IV = HexStringToBytes(inputIV.Text);
            }

            return result;
        }

        private string BytesToHexString(byte[] bytes)
        {
            return BitConverter.ToString(bytes).Replace("-", "");
        }

        private byte[] HexStringToBytes(string str)
        {
            byte[] bytes = new byte[str.Length/2];

            for (int i=0; i<str.Length/2; i++) 
            {
                bytes[i] = Convert.ToByte(str.Substring(i*2, 2), 16);
            }

            return bytes;
        }

        private void btnGenerateKey_Click(object sender, EventArgs e)
        {
            using (SymmetricAlgorithm alg = GetAlgorithm())
            {}
        }

        private void comboKeySize_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SymmetricAlgorithm alg = GetAlgorithm())
            {}
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (inputDecryptedASCII.Text == null || inputDecryptedASCII.Text.Length <= 0)
            {
                MessageBox.Show("There is no text to encrypt");
                return;
            }

            using (SymmetricAlgorithm alg = GetAlgorithm(false))
            {
                Stopwatch sw = Stopwatch.StartNew();

                ICryptoTransform encryptor = alg.CreateEncryptor(alg.Key, alg.IV);

                byte[] decryptedBytes = HexStringToBytes(inputDecryptedHEX.Text);
                byte[] encrypted = encryptor.TransformFinalBlock(decryptedBytes, 0, decryptedBytes.Length);

                inputEncryptedASCII.Text = Encoding.GetEncoding(1252).GetString(encrypted);

                sw.Stop();
                labelEncryptionTimeValue.Text = ((double)sw.ElapsedTicks / 10000000) + "s";
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (inputEncryptedASCII.Text == null || inputEncryptedASCII.Text.Length <= 0)
            {
                MessageBox.Show("There is no text to decrypt");
                return;
            }

            using (SymmetricAlgorithm alg = GetAlgorithm(false))
            {
                Stopwatch sw = Stopwatch.StartNew();

                ICryptoTransform decryptor = alg.CreateDecryptor(alg.Key, alg.IV);

                byte[] encryptedBytes = HexStringToBytes(inputEncryptedHEX.Text);
                byte[] decrypted = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);

                inputDecryptedASCII.Text = Encoding.GetEncoding(1252).GetString(decrypted);

                sw.Stop();
                labelDecryptionTimeValue.Text =  ((double)sw.ElapsedTicks / 10000000) + "s";
            }
        }
    }
}
