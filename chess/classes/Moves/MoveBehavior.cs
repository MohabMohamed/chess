using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess
{
    interface MoveBehavior
    {
        bool makemove(int oldrow, int oldcolmn, int newrow, int newcolmn);
    }
}
