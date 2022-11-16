using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Contabilidad_Blockchain
{
    public class Block
    {

        private long id;
        private string hash;
        private string prev;
        private List<Seats> fk_seats;

        public Block(int id, string hash, string prev, List<Seats> fk_seats)
        {
            this.id = id;
            this.hash = hash;
            this.prev = prev;
            this.fk_seats = fk_seats;
        }

        public long Id { get => id; set => id = value; }
        public string Hash { get => hash; set => hash = value; }
        public string Prev { get => prev; set => prev = value; }
        public List<Seats> Fk_seats { get => fk_seats; set => fk_seats = value; }


    }
}
