using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace chess
{
   
 class Piece
    {
        static public Image img ;
      public Piece()
       {
           
          
       }
      public virtual void Invalid()
      {

      }
      public virtual void move(Piece p)
      {

      }
    }
}
