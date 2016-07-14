using System;
using System.IO;
using System.Security.Cryptography;

namespace VTCP
{
    internal class Hasher
    {
        public Hasher(string fileName, string algorithm)
        {
            FileName = fileName;
            Algorithm = algorithm;
        }

        private string FileName { get; }
        private string Algorithm { get; }

        public string CalculateHash()
        {
            var hasher = HashAlgorithm.Create(Algorithm);
            var sr = new StreamReader(FileName).BaseStream;
            return hasher != null ? BitConverter.ToString(hasher.ComputeHash(sr)).Replace("-", "") : null;
        }
    }
}