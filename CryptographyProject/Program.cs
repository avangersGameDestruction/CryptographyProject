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
        }
    }
}
