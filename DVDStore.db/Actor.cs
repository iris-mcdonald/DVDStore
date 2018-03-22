using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace DVDStore.db
namespace DVDStore
{
    public class Actor
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }

        public virtual ICollection<DVD> DVDS { get; set; }
    }
}
