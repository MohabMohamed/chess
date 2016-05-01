using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.IO;
namespace chess
{       
  
    class Board
    {
        static public Image  boardimg  = new Bitmap(@"Images\boardBG.jpg");
        static public List <List<Piece> > board=new List<List <Piece> >();
        Board (){
    for(int i=0;i<8;i++){
        for(int j=0;j<8;j++)   board[i].Add(new Piece()); 
     }
            
        }
     
       
     

    }
}
