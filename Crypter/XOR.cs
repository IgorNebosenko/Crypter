﻿using System.IO;
using System.Text;

namespace Crypter
{
    public class XOR : ICrypt
    {
        public string Path { get; set; }
        public string Key { get; set; }
        public void Crypt()
        {
            string newPath = this.Path + ".xor";
            StringBuilder sb = new StringBuilder(File.ReadAllText(this.Path));

            int iCurrPosStr = 0;
            for (int i = 0; i < sb.Length; ++i)
            {
                if (iCurrPosStr == this.Key.Length - 1)
                    iCurrPosStr = 0;
                sb[i] ^= this.Key[iCurrPosStr];
            }
            File.WriteAllText(newPath, sb.ToString());
        }

        public XOR(string path, string key)
        {
            this.Path = path;
            this.Key = key;
        }

    }
}