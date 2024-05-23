using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAWSSecrets.Models
{
    public class Test
    {
        private KeysModel keys;

        public Test(KeysModel keys)
        {
            this.keys = keys;
        }

        public string GetValue()
        {
            return this.keys.Api;
        }
    }
}
