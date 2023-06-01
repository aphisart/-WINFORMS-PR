using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace gwint_prototype
{
    class Card
    {
        public Bitmap CardImage;
        public bool isClicked = false;
        public int width = 42;
        public int height = 84;
        public int pos;
        public string power;
        public string type;
        public string imagePath;
        public int strenght;
        public string clan;

        public Card(string imagePath, int strenght, string power, string clan, string type)
        {
            CardImage = new Bitmap(imagePath);
            this.imagePath = imagePath;
            this.clan = clan;
            this.strenght = strenght;
            this.power = power;
            this.type = type;
        }

        public void Draw(Graphics g, int pos)
        {
            g.DrawImage(CardImage, 100+(width + 15)*pos, 0, width, height);
        }

        public bool isMouseIn(MouseEventArgs e, int pos)
        {
            if (e.X > 100+(width + 15) * pos && e.X <100+ (width + 15) * pos + width && e.Y > 0 && e.Y < height)
                return true;
            return false;
        }
    }
}
