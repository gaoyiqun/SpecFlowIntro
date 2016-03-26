using System;
using System.Security.Cryptography;
using System.Text;

namespace WebBankSP
{
    public class MyHash: IHash
    {

        public string GetHash(string inputPassword)
        {
            var hash = SHA512.Create();
            var encoding = new UTF8Encoding();

            var inputByteArray = encoding.GetBytes(inputPassword);
            var hashValue = hash.ComputeHash(inputByteArray);

            var result = Convert.ToBase64String(hashValue);

            return result;
        }
    }
}