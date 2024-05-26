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

namespace Szyfrowanie4
{
    public partial class Form1 : Form
    {
        string fileName;
        string FileName
        {
            get
            {
                return fileName;
            }
            set
            {
                fileName = value;
                labelFileName.Text = value;

                if(fileName != null && fileName != string.Empty) 
                {
                    btnEncrypt.Enabled = true;
                    btnDecrypt.Enabled = true;
                } 
                else
                {
                    btnEncrypt.Enabled = false;
                    btnDecrypt.Enabled = false;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();

            using (Aes aes = Aes.Create()) 
            {
                using(RSA rsa = RSA.Create(2048)) 
                {
                    inputEncryptedAesKey.Text = BytesToHexString(rsa.Encrypt(aes.Key, RSAEncryptionPadding.OaepSHA512));
                    inputEncryptedIV.Text = BytesToHexString(rsa.Encrypt(aes.IV, RSAEncryptionPadding.OaepSHA512));
                    inputPrivateRSAKey.Text = RSAParametersToString(rsa.ExportParameters(true));
                    inputPublicRSAKey.Text = RSAParametersToString(rsa.ExportParameters(false));
                }
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            FileDialog fd = (FileDialog)sender;
            FileName = fd.FileName;
        }

        private void btnOpneFile_Click(object sender, EventArgs e)
        {
            fileDialog.ShowDialog();
        }

        private string BytesToHexString(byte[] bytes)
        {
            return BitConverter.ToString(bytes).Replace("-", "");
        }

        private string RSAParametersToString(RSAParameters param)
        {
            var sw = new System.IO.StringWriter();
            var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            xs.Serialize(sw, param);
            return sw.ToString();
        }

        private RSAParameters RSAParametersFromString(string str) 
        {
            var sr = new System.IO.StringReader(str);
            var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            return (RSAParameters)xs.Deserialize(sr);
        }

        private byte[] HexStringToBytes(string str)
        {
            byte[] bytes = new byte[str.Length / 2];

            for (int i = 0; i < str.Length / 2; i++)
            {
                bytes[i] = Convert.ToByte(str.Substring(i * 2, 2), 16);
            }

            return bytes;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            RSAParameters param = RSAParametersFromString(inputPrivateRSAKey.Text);

            using(RSA rsa = RSA.Create(param))
            {
                using (Aes aes = Aes.Create()) 
                {
                    aes.Key = rsa.Decrypt(HexStringToBytes(inputEncryptedAesKey.Text), RSAEncryptionPadding.OaepSHA512);
                    aes.IV = rsa.Decrypt(HexStringToBytes(inputEncryptedIV.Text), RSAEncryptionPadding.OaepSHA512);

                    rsa.ImportParameters(RSAParametersFromString(inputPublicRSAKey.Text));
                    using (FileStream fs = new FileStream(FileName, FileMode.Open))
                    {
                        ICryptoTransform encryptor = aes.CreateEncryptor();
                        byte[] data = new byte[fs.Length];
                        fs.Read(data, 0, (int)fs.Length);

                        byte[] encryptedData = encryptor.TransformFinalBlock(data, 0, data.Length);

                        using(FileStream fs2 = new FileStream(FileName + ".encrypted", FileMode.Create)) 
                        {
                            fs2.Write(encryptedData, 0, encryptedData.Length);
                        }
                    }
                }
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            RSAParameters param = RSAParametersFromString(inputPrivateRSAKey.Text);

            using (RSA rsa = RSA.Create(param))
            {
                using (Aes aes = Aes.Create())
                {
                    aes.Key = rsa.Decrypt(HexStringToBytes(inputEncryptedAesKey.Text), RSAEncryptionPadding.OaepSHA512);
                    aes.IV = rsa.Decrypt(HexStringToBytes(inputEncryptedIV.Text), RSAEncryptionPadding.OaepSHA512);

                    using (FileStream fs = new FileStream(FileName, FileMode.Open))
                    {
                        ICryptoTransform decryptor = aes.CreateDecryptor();
                        byte[] data = new byte[fs.Length];
                        fs.Read(data, 0, (int)fs.Length);

                        byte[] decryptedData = decryptor.TransformFinalBlock(data, 0, data.Length);

                        using (FileStream fs2 = new FileStream(FileName + ".decrypted", FileMode.Create))
                        {
                            fs2.Write(decryptedData, 0, decryptedData.Length);
                        }
                    }
                }
            }
        }
    }
}
