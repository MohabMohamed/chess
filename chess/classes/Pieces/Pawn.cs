using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace chess.Pieces
{
    class Pawn:Piece
    {

        public Pawn(int type, char color,Image img)
            : base(type, color,img)
        {
            
        }

        public override void makemove(int oldrow, int oldcolumn, int newrow, int newcolumn)         {        }
    }
}
