using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace gwint_prototype
{
    class Card
    {
        public Bitmap CardImage;
        int power;

        public Card(string imagePath, int power)
        {
            CardImage = new Bitmap(imagePath);
        }
    }
}
