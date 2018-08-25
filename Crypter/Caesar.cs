using System.IO;
using System.Text;
namespace Crypter
{
    public class Caesar : ICrypt
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
                int iVal = sb[i] + this.Key[iCurrPosStr];
                if (iVal > char.MaxValue)
                    iVal -= char.MaxValue;
                sb[i] = (char)iVal;
            }
            File.WriteAllText(newPath, sb.ToString());
        }

        public Caesar(string path, string key)
        {
            this.Path = path;
            this.Key = key;
        }
    }
}
