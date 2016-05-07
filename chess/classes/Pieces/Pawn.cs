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
        Pawn(int type, char color, Image img)
            : base(type, color,img)
        {
            
        }
    }
}
