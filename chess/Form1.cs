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
        Board b;//=new Board();
        public Form1()
        {
            InitializeComponent();
            pictureBox2.Parent = pictureBox1;
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Board.boardimg;
            
           
          //  GameBegin();    
            
        }
        private void GameBegin()
        {
            
            if(board==null)board=new Piece[8,8];
           // b.SetBoard();
           // if (graphics == null) graphics = Graphics.FromImage(pictureBox2.Image);
         //   update();
        }
        private void update()
        {
            graphics.Clear(Color.Transparent);
             board = b.GetBoard();
            for(int i=0;i<8;i++){
                 for(int j=0;j<8;j++){
                     if (board[i, j] != null)
                     {
                         graphics.DrawImage(board[i, j].img, new Rectangle(i * 50, j * 50, 50, 50));
                   }
                 }
            }
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
