using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contabilidad_Blockchain
{
    public class Accounts
    {

        long id;
        string name;

        public Accounts(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public long Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

    }
}
