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

    class  Board
    {
        public  static  Image boardimg = new Bitmap(@"Images\boardBG.jpg");
        private static Piece[,] board;
        private static PColor col=new PColor();
        public  Board()
        {
            SetBoard();
        }
        public void SetBoard()
        {
         board =new Piece [8,8];
            // set white pieces on the board
         board[0,0]= col[0,'w'];
         board[0, 1] = col[1, 'w'];
         board[0, 2] = col[2, 'w'];
         board[0, 3] = col[3, 'w'];
         board[0, 4] = col[4, 'w'];
         board[0, 5] = col[2, 'w'];
         board[0, 6] = col[1, 'w'];
         board[0, 7] = col[0, 'w'];
         for (int i = 0; i < 8; i++) board[1, i] = col[5, 'w'];
            // set black pieces on the board
         board[7, 0] = col[0, 'b'];
         board[7, 1] = col[1, 'b'];
         board[7, 2] = col[2, 'b'];
         board[7, 3] = col[3, 'b'];
         board[7, 4] = col[4, 'b'];
         board[7, 5] = col[2, 'b'];
         board[7, 6] = col[1, 'b'];
         board[7, 7] = col[0, 'b'];
         for (int i = 0; i < 8; i++) board[6, i] = col[5, 'b'];
        }
        public Piece[,] GetBoard(){
            Piece [,] tmp = new Piece [8,8];
            for (int i = 0; i < 8; i++) {
                for (int j = 0; j < 8; j++)
                {
                    if (board[i, j] == null) tmp[i, j] = null;
                    else tmp[i, j] = board[i, j];

                }
            
            }
            return tmp;
        }
        public Piece this[int x,int y]{
            get { return board[x, y]; }
            set { board[x, y] = value; }
        }



    }
}