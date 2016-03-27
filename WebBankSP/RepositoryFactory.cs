using System;

namespace WebBankSP
{
    public class RepositoryFactory
    {
        public static IAuthentication GetIAuthentication()
        {
            IDoc doc = GetDoc();
            IHash hash = GetHash();

            return new Authentication(hash, doc);
        }

        private static IHash GetHash()
        {
            return new MyHash();
        }

        private static IDoc GetDoc()
        {
            return new Doc();
        }
    }
}