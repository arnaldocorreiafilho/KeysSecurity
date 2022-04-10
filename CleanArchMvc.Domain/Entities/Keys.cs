using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Entities
{
    public class Keys : Entities.Entity
    {

        public string Key { get; set; }
        public string Value { get; set; }
        public string Hash { get; set; }
    }
}
