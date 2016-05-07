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
    class PColor
    {
        private static  List<Piece> white ;
        private static List<Piece> black;
        public PColor(){
            if(white==null){
                white = new List<Piece>();
                white.Add(new Piece(1,'w',new Bitmap(@"Images\wRock.png")));
                white.Add(new Piece(2,'w',new Bitmap(@"Images\wKnight.png")));
                white.Add(new Piece(3,'w',new Bitmap(@"Images\wBishop.png")));
                white.Add(new Piece(4,'w',new Bitmap(@"Images\wKing.png")));
                white.Add(new Piece(5,'w',new Bitmap(@"Images\wQueen.png")));
                white.Add(new Piece(6,'w',new Bitmap(@"Images\wPawn.png")));
            }
            if (black == null)
            {
                black = new List<Piece>();
                black.Add(new Piece(1,'b',new Bitmap(@"Images\bRock.png")));
                black.Add(new Piece(2,'b',new Bitmap(@"Images\bKnight.png")));
                black.Add(new Piece(3,'b',new Bitmap(@"Images\bBishop.png")));
                black.Add(new Piece(4,'b',new Bitmap(@"Images\bKing.png")));
                black.Add(new Piece(5,'b',new Bitmap(@"Images\bQueen.png")));
                black.Add(new Piece(6,'b',new Bitmap(@"Images\bPawn.png")));
            }

        }
        public Piece this[int x,char c]{
            get { 
            if (c == 'w') return white[x];
            if (c == 'b') return black[x];
            else return null;
            }
            set { 
            if (c == 'w')  white[x]=value;
            if (c == 'b')  black[x]=value;
            }
        }
        

        
    }
}
