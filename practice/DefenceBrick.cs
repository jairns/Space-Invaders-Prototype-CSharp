using System.Drawing;
using System.Windows.Forms;

namespace practice
{
    class DefenceBrick
    {
        // Set BrickSprite to picture box
        public PictureBox BrickSprite { get; private set; }

        public DefenceBrick()
        {
            // Pass the image within the constructor
            BrickSprite = new PictureBox();
        }

        // Make a brick
        public void makeBrick(int x, int y)
        {
            BrickSprite.Tag = "defenderBullet";
            BrickSprite.Size = new Size(100, 100);
            BrickSprite.BackColor = Color.Black;
            BrickSprite.Image = Properties.Resources.Protector;
            BrickSprite.SizeMode = PictureBoxSizeMode.StretchImage;
            // Get location from parameters
            BrickSprite.Location = new Point(x, y);
        }

        // Remove the brick
        public void removeBrick()
        {
            BrickSprite.Enabled = false;
            BrickSprite.Visible = false;
            BrickSprite.SendToBack();
            BrickSprite.Size = new Size(0, 0);
        }
    }
}
