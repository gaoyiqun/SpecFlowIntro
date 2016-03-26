using System;
using System.Collections.Generic;

namespace WebBankSP
{
    public class Doc : IDoc
    {
        private Dictionary<string, string> _data = new Dictionary<string, string>();
      
        public Doc()
        {
            this._data.Add("1234", "S2EQGhNLvF9Qh2QZMmB9wo2Ezuif8rmYCTaGUEKqdMz+w5SHZXSreKazP0QuUG67cBMFbnDmtwOoKVvk7IWzVQ==");
        }

        public string GetPassword(string id)
        {
            if (this._data.ContainsKey(id))
            {
                return this._data[id];
            }
            else
            {
                return string.Empty;
            }
        }
    }
}