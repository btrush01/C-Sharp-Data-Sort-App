using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    public class RowMap : ClassMap<Row>
    {
        public RowMap()
        {
            Map(x => x.id).Name("id");
            Map(x => x.rated).Name("rated");
            Map(x => x.created_at).Name("created_at");
            Map(x => x.last_move_at).Name("last_move_at");
            Map(x => x.turns).Name("turns");
            Map(x => x.victory_status).Name("victory_status");
            Map(x => x.winner).Name("winner");
            Map(x => x.increment_code).Name("increment_code");
            Map(x => x.white_id).Name("white_id");
            Map(x => x.white_rating).Name("white_rating");
            Map(x => x.black_id).Name("black_id");
            Map(x => x.black_rating).Name("black_rating");
            Map(x => x.moves).Name("moves");
            Map(x => x.opening_eco).Name("opening_eco");
            Map(x => x.opening_name).Name("opening_name");
            Map(x => x.opening_ply).Name("opening_ply");
        }
    }
}
