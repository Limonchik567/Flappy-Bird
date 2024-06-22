using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace flappy_bird
{
    internal class TheWall
    {
        public int x;
        public int y;

        public int sizeX;
        public int sizeY;

        public Image wallImg;


        public TheWall(int x, int y, bool isRotatedImage = false)
        {
            wallImg = new Bitmap("G:\\p\\tube.png");
            this.x = x;
            this.y = y;
            sizeX = 70;
            sizeY = 350;
            if (isRotatedImage)
                wallImg.RotateFlip(RotateFlipType.Rotate180FlipX);
        }
    }
}
