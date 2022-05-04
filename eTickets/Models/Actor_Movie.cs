

// Eliabe Baliero De Moura ID-24066
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/* in thihs part a have my get and set for my object movie
    */
namespace eTickets.Models
{
    public class Actor_Movie
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public int ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}
