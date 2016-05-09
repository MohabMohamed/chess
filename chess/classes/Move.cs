using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess
{
    class Move
    {
       private MoveBehavior movebehavior;
       public Move(MoveBehavior movebehavior)
       {
           this.movebehavior = movebehavior;
       } 
       bool makemove(int oldrow, int oldcolmn, int newrow, int newcolmn)
       {

           return movebehavior.makemove(oldrow,oldcolmn,newrow,newcolmn);
       }
    }
}
