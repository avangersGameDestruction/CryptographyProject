using System;
using System.IO;
using System.Security.Cryptography;

namespace CryptographyProject
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public sealed class Cryption
        {
            // algorithms (RijndaelManaged)
            private RijndaelManaged algorithm;

            // memory stream
            private MemoryStream MemoryStream;

            // ICryptoTransform interface + CryptoStream
            private ICryptoTransform EncryptorDecryptor;
            private CryptoStream CryptoStream;

            // Stream writer and Stream reader
            private StreamWriter StreamWriter;
            private StreamReader StreamReader;

            // internal strings
            private string mKey;
            private string mIV;

            // the Key and the Inicialization Vector
            private byte[] Key;
            private byte[] IV;

            // password view
            private string password_string;
            private byte[] password_bytes;

            // Constructor
            public Cryption(string key_valeu, string iv_valeu)
            {
                Key = new byte[32];
                IV = new byte[32];

                int i;

                mKey = key_valeu;
                mIV = iv_valeu;

                // key calculation, depends on first constructor parameter
                for (i = 0; i < mKey.Length; i++)
                {
                    Key[i] = Convert.ToByte(mKey[i]);
                }

                // IV calculation, depends on second constructor parameter
                for (i = 0; i < mIV.Length; i++)
                {
                    IV[i] = Convert.ToByte(mIV[i]);
                }
            }
        }
    }
}
