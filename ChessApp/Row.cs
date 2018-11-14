using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    public class Row
    {
        public String id { get; set; }
        public String rated { get; set; }
        public String created_at { get; set; }
        public String last_move_at { get; set; }
        public int turns { get; set; }
        public String victory_status { get; set; }
        public String winner { get; set; }
        public String increment_code { get; set; }
        public String white_id { get; set; }
        public int white_rating { get; set; }
        public String black_id { get; set; }
        public int black_rating { get; set; }
        public String moves { get; set; }
        public String opening_eco { get; set; }
        public String opening_name { get; set; }
        public int opening_ply { get; set; }
    }
}