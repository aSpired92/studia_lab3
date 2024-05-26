using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace Szyfrowanie2
{
    enum Algorithm
    {
        Aes,
        AesManaged,
        DES,
        TripleDES,
        RijndaelManaged
    }

    internal class Program
    {
        static Algorithm currentAlg = Algorithm.Aes;

        static byte[] key;
        static byte[] iv;
        static int keySize = 128;

        static string testFilePath = @"./test.bin";
        static byte[] testBytes = new byte[1073741824];

        static void Main(string[] args)
        {
            CreateTestData();

            for(int i=0; i<5; i++) 
            {
                currentAlg = (Algorithm)i;
                using (SymmetricAlgorithm alg = GetAlgorithm()) 
                {
                    foreach(KeySizes ks in alg.LegalKeySizes) 
                    {
                        int min = ks.MinSize;
                        int max = ks.MaxSize;
                        int step = ks.SkipSize;

                        if (step == 0)
                        {
                            Test(min, alg);
                            continue;
                        }

                        for (int j = min; j <= max; j += step)
                        {
                            Test(j, alg);
                        }
                    }
                }
            }
        }

        private static void CreateTestData()
        {
            Random rnd = new Random();
            rnd.NextBytes(testBytes);

            using (FileStream fs = new FileStream(testFilePath, FileMode.Create))
            {
                using (BinaryWriter bwOutput = new BinaryWriter(fs))
                {
                    bwOutput.Write(testBytes);
                }
            }
        }

        private static void Test(int keySize, SymmetricAlgorithm alg)
        {
            alg.KeySize = keySize;
            alg.GenerateKey();
            alg.GenerateIV();

            Console.WriteLine(currentAlg.ToString() + " " + keySize + "bit");

            Stopwatch sw = Stopwatch.StartNew();

            ICryptoTransform encryptor = alg.CreateEncryptor(alg.Key, alg.IV);

            byte[] encrypted = encryptor.TransformFinalBlock(testBytes, 0, testBytes.Length);

            sw.Stop();

            double seconds = (double)sw.ElapsedTicks / 10000000;
            double secondshdd = 0;

            using (FileStream fs = new FileStream(testFilePath, FileMode.Open))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    sw.Restart();

                    byte[] bytes = br.ReadBytes((int)br.BaseStream.Length);
                    encryptor.TransformFinalBlock(bytes, 0, bytes.Length);

                    sw.Stop();
                    secondshdd = (double)sw.ElapsedTicks / 10000000;
                }
            }

            Console.WriteLine("\t" + (seconds / (encrypted.Length / alg.BlockSize)).ToString("F10").TrimEnd('0') + " sekund/blok");
            Console.WriteLine("\t" + (testBytes.Length / seconds).ToString("F10").TrimEnd('0') + " bajtów/sekundę (RAM)");
            Console.WriteLine("\t" + (testBytes.Length / secondshdd).ToString("F10").TrimEnd('0') + " bajtów/sekundę (HDD)");
        }

        private static SymmetricAlgorithm GetAlgorithm(bool generateKeyAndIV = true)
        {
            SymmetricAlgorithm result;

            switch (currentAlg)
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
                key = result.Key;
                iv = result.IV;
            }
            else
            {
                result.KeySize = keySize;
                result.Key = key;
                result.IV = iv;
            }

            return result;
        }
    }
}