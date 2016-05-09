using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace chess
{
    public partial class Form1 : Form
    {
        Piece[,] board;
        Graphics graphics;
        Board b=new Board();
        Image piecesimg;
        int hieght;
        int width;
        public Form1()
        {
            InitializeComponent();
            pictureBox2.Parent = pictureBox1;
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Board.boardimg;
            hieght = pictureBox2.Size.Height;
            width = pictureBox2.Size.Width;
            DoubleBuffered = true;
         GameBegin();    
            
        }
        private void GameBegin()
        {
            
            if(board==null)board=new Piece[8,8];
           b.SetBoard();
           
           if (piecesimg == null) piecesimg = new Bitmap(width,hieght);
           graphics = Graphics.FromImage(piecesimg);
           update();
        }
        private void update()
        {
            graphics.Clear(Color.Transparent);
             board = b.GetBoard();
            for(int i=0;i<8;i++){
                 for(int j=0;j<8;j++){
                     if (board[i, j] != null)
                     {
                         graphics.DrawImage(board[j, i].img, new Rectangle( i* (width/8), j *(hieght/8), width/8, hieght/8));
                   }
                 }
            }
            pictureBox2.Image = piecesimg;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        { 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
