using System;

namespace WebBankSP
{
    public class Authentication:IAuthentication
    {
        private IHash _hash;
        private IDoc _doc;

        public Authentication(IHash hash, IDoc doc) 
        {
            this._hash = hash;
            this._doc = doc;
        }

        public bool Verify(string id, string inputPassword)
        {
            string passwordFromDoc = this.GetPasswordFromDoc(id);
            string passwordAfterHash = this.GetHash(inputPassword);

            var isValid = passwordFromDoc == passwordAfterHash;

            return isValid;
        }

        private string GetHash(string inputPassword)
        {
            var result = this._hash.GetHash(inputPassword);

            return result;
        }

        private string GetPasswordFromDoc(string id)
        {
            var password = this._doc.GetPassword(id);

            return password;
        }

        /**
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
        **/

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