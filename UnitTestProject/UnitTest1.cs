using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Crypter;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        private const string PATH = @"C:\Users\student\Desktop\Новая папка\key.txt";
        private const string KEY = "Hello world!";
        private ICrypt crypt;

        [TestMethod]
        public void TestMethodXOR()
        {
            this.crypt = new XOR(PATH, KEY);
            this.crypt.Crypt();
        }
        [TestMethod]
        public void TestMethodCaesar()
        {
            this.crypt = new Caesar(PATH, KEY);
            this.crypt.Crypt();
        }
    }
}
