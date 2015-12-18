using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace VTCP
{
    class Hasher
    {
        private string fileName { get; set; }
        private string algorithm { get; set; }

        public Hasher(string fileName, string algorithm)
        {

            this.fileName = fileName;
            this.algorithm = algorithm;

        }

        public string calculateHash()
        {
            HashAlgorithm hasher = HashAlgorithm.Create(algorithm);
            var sr = (new StreamReader(fileName)).BaseStream;
            return BitConverter.ToString(hasher.ComputeHash(sr)).Replace("-","");
        }
    }
}
