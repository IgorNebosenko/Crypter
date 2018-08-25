using System;
using System.IO;
namespace Crypter
{
    /// <summary>
    /// Main class of programm
    /// </summary>
    class Program
    {
        /// <summary>
        /// Entry point of programm
        /// </summary>
        /// <param name="args">Arguments</param>
        /// <returns> 0 if all good, also - error code</returns>
        static int Main(string[] args)
        {
            Console.WriteLine("Print path");
            string str = Console.ReadLine();
            if (!File.Exists(str))
            {
                Console.WriteLine("File not exist!");
                return 1;
            }

            Console.WriteLine("Print string witch used to crypt");
            string strKey = Console.ReadLine();
            if (strKey == "")
            {
                Console.WriteLine("Key must be not null!");
                return 2;
            }

            Console.WriteLine("0 - Crypt XOR, 1 - Crypt Caesar");
            char chSw = (char)Console.Read();

            ICrypt crypt;
            switch (chSw)
            {
                case '0':
                    crypt = new XOR(str, strKey);
                    break;
                case '1':
                    crypt = new Caesar(str, strKey);
                    break;
                default:
                    Console.WriteLine("Incorrect variant!");
                    return 3;
            }
            crypt.Crypt();
            return 0;
        }
    }
}
