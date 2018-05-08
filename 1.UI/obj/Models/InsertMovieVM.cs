using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1.UI.Models
{
    public class InsertMovieVM
    {
        public string MovieName { get; set; }
        public int CategoryID { get; set; }
        public string Picture { get; set; }
        public string MovieTrailer { get; set; }
        public Nullable<bool> IsActiv { get; set; }
        public Nullable<int> Level { get; set; }
        public Nullable<int> Ranking { get; set; }
    }
}