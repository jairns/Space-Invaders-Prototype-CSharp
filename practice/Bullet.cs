using System.Drawing;
using System.Windows.Forms;


namespace practice
{
    class Bullet
    {
        public bool isFiring;
        private int speed = 10;
        public bool isActive;
        
        // Set the images
        public PictureBox Sprite { get; private set; }
        public PictureBox InvaderSprite { get; private set; }

        // Generate constructor
        public Bullet()
        {
            Sprite = new PictureBox();
            InvaderSprite = new PictureBox();
        }

        // Make the defender bullet, set the location based on the parameters passed in
        public void makeBullet(int x, int width)
        {
            Sprite.Tag = "defenderBullet";
            Sprite.Size = new Size(5, 10);
            Sprite.BackColor = Color.Black;
            Sprite.Image = Properties.Resources.good_guy_bullet;
            Sprite.SizeMode = PictureBoxSizeMode.StretchImage;
            Sprite.Visible = true;
            Sprite.Enabled = true;
            Sprite.Location = new Point(x + width / 2, 490);
            Sprite.BringToFront();
            isActive = true;
        }

        // Move bullet up 
        public void bulletUp()
        {
            if(isFiring)
                Sprite.Top -= speed;

            if (Sprite.Top <= 0)
                Sprite.Size = new Size(0, 0);
        }

        // Make the invader bullet, set the location based on the parameters passed in
        public void makeInvaderBullet(int x, int y, int width)
        {
            InvaderSprite.Tag = "invaderBullet";
            InvaderSprite.Size = new Size(5, 10);
            InvaderSprite.BackColor = Color.Black;
            InvaderSprite.Image = Properties.Resources.Alien_Bullet;
            InvaderSprite.SizeMode = PictureBoxSizeMode.StretchImage;
            InvaderSprite.Location = new Point(x + width / 2, y);
            InvaderSprite.Enabled = true;
            InvaderSprite.Visible = true;
            InvaderSprite.BringToFront();
            isActive = true;
        }

        // Remove a bullet
        public void removeBullet(string imgBullet)
        {
            // If the parameter is equal to invader, remove the invader bullet image
            if(imgBullet == "invader")
            {
                InvaderSprite.Enabled = false;
                InvaderSprite.Visible = false;
                // Else, remove the defender bullet image
            } else
                Sprite.Enabled = false;
                Sprite.Visible = false;
        }

        // Move bullet down
        public void bulletDown()
        {
            InvaderSprite.Top += speed;
        }

    }
}
