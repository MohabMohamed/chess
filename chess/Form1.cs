using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chess
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            pictureBox2.Parent = pictureBox1;
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Board.boardimg;
       //     _graphics.Clear(Color.Transparent);
            
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
