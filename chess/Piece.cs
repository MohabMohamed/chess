﻿using System;
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
         public Image img ;
        protected int kind;
        protected char color;
      public Piece(int kind,char color,Image img)
       {
           this.kind = kind;
           this.color = color;
           this.img = img;
       }
      public virtual void Invalid()
      {

      }
      public virtual void move(Piece p)
      {

      }
    }
}
