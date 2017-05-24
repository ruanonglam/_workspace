using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Drawing;

// http://www.fluxbytes.com/csharp/encrypt-and-decrypt-files-in-c/
namespace EncryptAndDecryptData.Classes
{
    class EncryptAndDecryptData
    {

        private String key;

        public EncryptAndDecryptData(String key)
        {
            this.key = key;
        }

        public String Key
        {
            get;
            set;
        }

        public Boolean EncryptSigleFile(String inputFile, String outputFile)
        {
            try
            {
                using (RijndaelManaged aes = new RijndaelManaged())
                {
                    byte[] key = ASCIIEncoding.UTF8.GetBytes(this.key);

                    /* This is for demostrating purposes only. 
                     * Ideally you will want the IV key to be different from your key and you should always generate a new one for each encryption in other to achieve maximum security*/
                    byte[] IV = ASCIIEncoding.UTF8.GetBytes(this.key);

                    using (FileStream fsCrypt = new FileStream(outputFile, FileMode.Create))
                    {
                        using (ICryptoTransform encryptor = aes.CreateEncryptor(key, IV))
                        {
                            using (CryptoStream cs = new CryptoStream(fsCrypt, encryptor, CryptoStreamMode.Write))
                            {
                                using (FileStream fsIn = new FileStream(inputFile, FileMode.Open))
                                {
                                    int data;
                                    while ((data = fsIn.ReadByte()) != -1)
                                    {
                                        cs.WriteByte((byte)data);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public Boolean DecryptSingleFile(String inputFile, String outputFile)
        {
            try
            {
                using (RijndaelManaged aes = new RijndaelManaged())
                {
                    byte[] key = ASCIIEncoding.UTF8.GetBytes(this.key);

                    /* This is for demostrating purposes only. 
                     * Ideally you will want the IV key to be different from your key and you should always generate a new one for each encryption in other to achieve maximum security*/
                    byte[] IV = ASCIIEncoding.UTF8.GetBytes(this.key);

                    using (FileStream fsCrypt = new FileStream(inputFile, FileMode.Open))
                    {
                        using (FileStream fsOut = new FileStream(outputFile, FileMode.Create))
                        {
                            using (ICryptoTransform decryptor = aes.CreateDecryptor(key, IV))
                            {
                                using (CryptoStream cs = new CryptoStream(fsCrypt, decryptor, CryptoStreamMode.Read))
                                {
                                    int data;
                                    while ((data = cs.ReadByte()) != -1)
                                    {
                                        fsOut.WriteByte((byte)data);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                return false;
            }
            return true;    
        }

        public Bitmap DecryptSingleFileToBitmap(String inputFile)
        {
            MemoryStream mStream = new MemoryStream();
            try
            {
                using (RijndaelManaged aes = new RijndaelManaged())
                {
                    byte[] key = ASCIIEncoding.UTF8.GetBytes(this.key);

                    /* This is for demostrating purposes only. 
                     * Ideally you will want the IV key to be different from your key and you should always generate a new one for each encryption in other to achieve maximum security*/
                    byte[] IV = ASCIIEncoding.UTF8.GetBytes(this.key);

                    using (FileStream fsCrypt = new FileStream(inputFile, FileMode.Open))
                    {
                        using (ICryptoTransform decryptor = aes.CreateDecryptor(key, IV))
                        {
                            using (CryptoStream cs = new CryptoStream(fsCrypt, decryptor, CryptoStreamMode.Read))
                            {
                                int data;
                                while ((data = cs.ReadByte()) != -1)
                                {
                                    mStream.WriteByte((byte)data);
                                }
                            }
                        }

                        //using (FileStream fsOut = new FileStream(outputFile, FileMode.Create))
                        //{
                        //    using (ICryptoTransform decryptor = aes.CreateDecryptor(key, IV))
                        //    {
                        //        using (CryptoStream cs = new CryptoStream(fsCrypt, decryptor, CryptoStreamMode.Read))
                        //        {
                        //            int data;
                        //            while ((data = cs.ReadByte()) != -1)
                        //            {
                        //                fsOut.WriteByte((byte)data);
                        //            }
                        //        }
                        //    }
                        //}
                    }
                }
            }
            catch
            {
                return null;
            }
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        //public static Bitmap ByteToImage(String filename)
        //{
        //    MemoryStream mStream = new MemoryStream();
        //    byte[] pData = File.ReadAllBytes(filename);
        //    if (pData == null)
        //    {
        //        return null;
        //    }
        //    mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            
        //    Bitmap bm = new Bitmap(mStream, false);
        //    mStream.Dispose();
        //    return bm;
        //}
    }
}
