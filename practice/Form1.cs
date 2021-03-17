using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace practice
{
    public partial class Form1 : Form
    {
        
        PictureBox[] alienBox = new PictureBox[9];

        private int speed = 3;

        public Form1()
        {
            InitializeComponent();

            alienBox[0] = alienImage1;
            alienBox[1] = alienImage2;
            alienBox[2] = alienImage3;
            alienBox[3] = alienImage4;
            alienBox[4] = alienImage5;
            alienBox[5] = alienImage6;
            alienBox[6] = alienImage7;
            alienBox[7] = alienImage8;
            alienBox[8] = alienImage9;

        }

        // Game instance
        Game game = new Game(0, false, true);

        // Defender instance
        Defender defender = new Defender();

        // Defence bricks instances
        DefenceBrick brickLeft = new DefenceBrick();

        DefenceBrick brickRight = new DefenceBrick();

        DefenceBrick brickMiddle = new DefenceBrick();


        // Alien instance
        Alien alien = new Alien(9, "C:/Users/jacka/OneDrive/Desktop/year-4/adv-prog-for-mob/spaceinvader-images/orange_alien.png");

        // Defender bullet instance
        Bullet defenderBullet = new Bullet();

        // Invader bullet instance
        Bullet invaderBullet = new Bullet();

        private void Form1_Load(object sender, EventArgs e)
        {
            // Add images from classes
            Controls.Add(defender.Sprite);

            Controls.Add(brickLeft.BrickSprite);

            Controls.Add(brickRight.BrickSprite);

            Controls.Add(brickMiddle.BrickSprite);

            Controls.Add(defenderBullet.Sprite);

            Controls.Add(invaderBullet.InvaderSprite);

            Controls.Add(game.gameOverText);

            // Creating a loop to asign an image and tag to each picture box
            for (int i = 0; i < alien.numberOf; i++)
            {
                alienBox[i].ImageLocation = alien.image;
                alienBox[i].Tag = "alien";
            }

            // Setting the score
            scoreText.Text = "Score:" + game.score;

            // Locating the score
            scoreText.Location = new Point(75, 580);

            // Setting the location of the defence bricks
            brickLeft.makeBrick(75, 380);

            brickRight.makeBrick(500, 380);

            brickMiddle.makeBrick(290, 380);
        }

        // When the key is held down
        private void keyisdown(object sender, KeyEventArgs e)
        {
            // F5 to start game
            if (e.KeyCode == Keys.F5)
                startGame();

            // Left arrow, move defender left
            if (e.KeyCode == Keys.Left && game.isPlaying) defender.defenderLeft();

            // Right arrow, move defender right
            if (e.KeyCode == Keys.Right && game.isPlaying) defender.defenderRight();

            // Space, create a bullet for the defender
            if (e.KeyCode == Keys.Space && game.isPlaying && !defenderBullet.isFiring)
            {
                // Setting bullet is firing true to negate spamming 
                defenderBullet.isFiring = true;
                //Getting the location of the defender
                int x = defender.Sprite.Left;
                // Getting the width of the defender
                int width = defender.Sprite.Width;
                // Make a defender bullet by passing in the current location of the defender
                defenderBullet.makeBullet(x, width);
            }
        }

        /* Release key, stop defender moving */
        private void keyisup(object sender, KeyEventArgs e)
        {
            // Left arrow released, stop moving defender left
            if (e.KeyCode == Keys.Left) defender.goLeft = false;
            
            // Right arrow released, stop moving defender right
            if (e.KeyCode == Keys.Right) defender.goRight = false;

        }

        // Start game
        private void startGame()
        {
            // Set isPlaying to true
            game.isPlaying = true;
            // Start the timer
            gameTimer.Enabled = true;
            // Remove the start game text
            startGameText.Visible = false;
        }

        // Game timer, called every 25 milliseconds
        private void gameTimer_Tick(object sender, EventArgs e)
        {

            // Move defender bullet
            defenderBullet.bulletUp();

            // Move invader bullet down
            invaderBullet.bulletDown();

            // If the defenders bullet goes off screen
            if (defenderBullet.Sprite.Top <= 0)
            {
                // Set isFiring to false
                defenderBullet.isFiring = false;
            }

            // If the invader bullet hits the defender and the invader bullet is active 
            if (invaderBullet.InvaderSprite.Bounds.IntersectsWith(defender.Sprite.Bounds) && invaderBullet.isActive)
            {
                // Stop the timer
                gameTimer.Enabled = false;
                // Call the gameIsOver function from the game class and pass in the text as a parameter
                game.gameIsOver("Game over! Our planet was destroyed.");
            }

            // If the invaders bullet hits the left defence brick
            if (brickLeft.BrickSprite.Bounds.IntersectsWith(invaderBullet.InvaderSprite.Bounds))
            {
                // Call the remove brick function
                brickLeft.removeBrick();
                // Call the remove bullet function, pass in the invader as a parameter to remove the correct bullet
                invaderBullet.removeBullet("invader");
                // Set bullet is active to false
                invaderBullet.isActive = false;
            }
            // If the invaders bullet hits the middle defence brick
            else if (invaderBullet.InvaderSprite.Bounds.IntersectsWith(brickMiddle.BrickSprite.Bounds))
            {
                brickMiddle.removeBrick();
                invaderBullet.removeBullet("invader");
                invaderBullet.isActive = false;
            } 
            // If the invaders bullet hits the right defence brick
            else if (invaderBullet.InvaderSprite.Bounds.IntersectsWith(brickRight.BrickSprite.Bounds))
            {
                brickRight.removeBrick();
                invaderBullet.removeBullet("invader");
                invaderBullet.isActive = false;
            }

            // If the defenders bullet hits any of the defence bricks
            if (defenderBullet.Sprite.Bounds.IntersectsWith(brickRight.BrickSprite.Bounds) || defenderBullet.Sprite.Bounds.IntersectsWith(brickMiddle.BrickSprite.Bounds) || defenderBullet.Sprite.Bounds.IntersectsWith(brickLeft.BrickSprite.Bounds))
            {
                // Call the removeBullet function and pass the defender in as a parameter
                defenderBullet.removeBullet("defender");
                // Set the defenders bullet to active
                defenderBullet.isActive = false;
            }

            // Movement of aliens
            foreach (Control invaderMove in this.Controls)
            {
                // Setting the the pciture box with the tag of alien to invaderMove within this context
                if (invaderMove is PictureBox && invaderMove.Tag == "alien")
                {
                    // Move invaders across the screen
                    ((PictureBox)invaderMove).Left += speed;

                    // Move invaders down the page 
                    if (((PictureBox)invaderMove).Left > 700)
                    {
                        ((PictureBox)invaderMove).Top += ((PictureBox)invaderMove).Height + 10;

                        ((PictureBox)invaderMove).Left = -50;
                    }
                    
                    // If the invader hits the defender 
                    if (((PictureBox)invaderMove).Bounds.IntersectsWith(defender.Sprite.Bounds))
                    {
                        // Stop game timer
                        gameTimer.Enabled = false;
                        // Call the game is over function and pass the text as a parameter
                        game.gameIsOver("Game over! Our planet was destroyed.");
                    }

                }

                // Bullet hitting emeny
                foreach (Control invader in this.Controls)
                {
                    if (invader is PictureBox && invader.Tag == "alien")
                    {
                        // if the defenders bullet hits the invader and the bullet is active
                        if (invader.Bounds.IntersectsWith(defenderBullet.Sprite.Bounds) && defenderBullet.isActive)
                        {
                            // Remove the invader from the form
                            Controls.Remove(invader);
                            // Increase the score by 1
                            game.score++;
                            // Update the score on the form
                            scoreText.Text = "Score:" + game.score;
                            // Remove the defender bullet and pass in the defender as a parameter
                            defenderBullet.removeBullet("defender");
                            // Set isActive to false
                            defenderBullet.isActive = false;
                        } 
                    }
                }

                // If the games score is greater than the number of aliens
                if (game.score >= alien.numberOf)
                {
                    // Disable the game timer
                    gameTimer.Enabled = false;
                    // Call the gameIsOver function and pass in the relevant text as a parameter
                    game.gameIsOver("Well done, our planet is saved!");
                }
            }
            // End of foreach
        }

        // Call this every two seconds to create alien bullet
        private void alienBulletTimer_Tick(object sender, EventArgs e)
        {
            if (game.isPlaying)
            {
                // New random instance
                Random rnd = new Random();
                // Get random number between 1 and 7
                int index = rnd.Next(1, 7);
                // Get the location of the current invader
                int x = alienBox[index].Left;
                int y = alienBox[index].Top;
                var width = alienBox[index].Width;
                // Call the make invader bullet function and pass the location as a parameter
                invaderBullet.makeInvaderBullet(x, y, width);
                scoreText.Text = "Score:" + game.score;
            }
        }
    }
}
