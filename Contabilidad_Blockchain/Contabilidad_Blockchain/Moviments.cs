using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Contabilidad_Blockchain
{
    public class Moviments
    {

        long id;
        int amount;
        Accounts fk_accounts;

        public Moviments(int id, int amount, Accounts fk_accounts)
        {
            this.id = id;
            this.amount = amount;
            this.fk_accounts = fk_accounts;
        }

        public long Id { get => id; set => id = value; }
        public int Amount { get => amount; set => amount = value; }
        public Accounts Fk_accounts { get => fk_accounts; set => fk_accounts = value; }
    }
}
