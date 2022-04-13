using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Entities
{
    public class Keys : Entities.Entity
    {
        

        public Keys(string key, string value)
        {
            this.Key = key;
            this.Value = value;
        }

        public string Key { get; set; }
        public string Value { get; set; }
        public string Hash { get; set; }
        public void GenerateHash() 
        {
            using var provider = System.Security.Cryptography.MD5.Create();
            StringBuilder builder = new StringBuilder();

            foreach (byte b in provider.ComputeHash(Encoding.UTF8.GetBytes(this.Key+this.Value)))
                builder.Append(b.ToString("x2").ToLower());
            this.Hash = builder.ToString();
        }
    }
}
