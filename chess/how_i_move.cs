using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess
{
    interface how_i_move
    {
         bool can_move(int or, int oc, int nr, int nc, bool die = true);
    }
}
