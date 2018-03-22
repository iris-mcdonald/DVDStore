using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace DVDStore.db
namespace DVDStore
{
    public class DVD
    {
        public int ID { get; set; }
        public string  Title { get; set; }
        public string  Genre { get; set; }
        public string  Price { get; set; }  
        public int     YearReleased { get; set; }
        public int     RunTime { get; set; }
        public decimal TotalSalesCount { get; set; }
        public string  Summary { get; set; }
        //CoverImg
        
        public virtual ICollection<Actor> Actors { get; set; }
    }
}
