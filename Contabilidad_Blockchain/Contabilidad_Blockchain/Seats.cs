using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contabilidad_Blockchain
{
    public class Seats
    {

        long id;
        DateTime date;
        List<Moviments> fk_movments;

        public Seats(int id, DateTime date, List<Moviments> fk_movments)
        {
            this.id = id;
            this.date = date;
            this.fk_movments = fk_movments;
        }

        public long Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public List<Moviments> Fk_movments { get => fk_movments; set => fk_movments = value; }

    }
}
