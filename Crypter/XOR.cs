using System.IO;
using System.Text;

namespace Crypter
{
    /// <summary>
    /// Class of Xor Crypt
    /// </summary>
    public class XOR : ICrypt
    {
        /// <summary>
        /// Property of Path
        /// </summary>
        public string Path { get; set; }
        /// <summary>
        /// Property of key
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// Crypt method
        /// </summary>
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
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="path">Path</param>
        /// <param name="key">Key</param>
        public XOR(string path, string key)
        {
            this.Path = path;
            this.Key = key;
        }

    }
}
