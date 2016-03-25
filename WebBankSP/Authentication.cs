using System;

namespace WebBankSP
{
    public class Authentication
    {
        public bool Verify(string id, string inputPassword)
        {
            string passwordFromDoc = this.GetPasswordFromDoc(id);
            string passwordAfterHash = this.GetHash(inputPassword);

            var isValid = passwordFromDoc == passwordAfterHash;

            return isValid;
        }

        private string GetHash(string inputPassword)
        {
            var hash = new MyHash();

            var result = hash.GetHash(inputPassword);

            return result;
        }

        private string GetPasswordFromDoc(string id)
        {
            var doc = new Doc();

            var docPassword = doc.GetPassword(id);

            return docPassword;
        }

        /**
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
**/
    }
}