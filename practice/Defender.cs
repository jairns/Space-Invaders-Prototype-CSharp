using System.Drawing;
using System.Windows.Forms;

namespace practice
{
    class Defender
    {
        public bool goRight;
        public bool goLeft;
        private int speed = 5;
  
        // Set picture box equal to Sprite
        public PictureBox Sprite { get; private set; }

        public Defender()
        {
            // Create the defender image
            Sprite = new PictureBox
            {
                Tag = "player",
                Size = new Size(60,60),
                BackColor = Color.Black,
                Image = Properties.Resources.Defender,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point(310, 500)
            };
            Sprite.BringToFront();
        }

        // Move defedner left
        internal void defenderLeft()
        {
            Sprite.Left -= speed;
            // Prevent defender from going off screen
            if (Sprite.Left <= 0) Sprite.Left = 1;
        }

        // Move the defender right
        internal void defenderRight()
        {
            Sprite.Left += speed;
            // Prevent the defender going off screen
            if (Sprite.Left >= 630) Sprite.Left = 629;
        }

    }
}
