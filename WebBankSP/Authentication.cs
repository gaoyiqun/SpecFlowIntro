using System;

namespace WebBankSP
{
    public class Authentication
    {
        public bool Verify(string id, string password)
        {
            if(id == "1234"&& password == "Irene")
            {
                return true;

            }

            if(id =="1234" && password == "Yiqun")
            {
                return false;
            }

            return false;
        }
    }
}