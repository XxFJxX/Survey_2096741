using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey_2096741
{
    public class Survey
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public string FavoriteTeam { get; set; }
        public override string ToString()
        {
            return $"{Name} | {Birthdate} | {FavoriteTeam}";
        }
    }
}
