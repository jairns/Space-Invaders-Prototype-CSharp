using System.Drawing;
using System.Windows.Forms;

namespace practice
{
    class Game
    {

        public int score;
        public bool isPlaying;
        public bool gameOver;

        // Set gameOverText equal as a label
        public Label gameOverText { get; private set; }

        // Generate constructor so the variables can be set elsewhere
        public Game(int scoreArgs, bool isPlayingArgs, bool gameOverArgs)
        {
            score = scoreArgs;
            isPlaying = isPlayingArgs;
            gameOver = gameOverArgs;
        
            gameOverText = new Label();
        }

        // gameIsOver function
        public void gameIsOver(string message)
        {
            isPlaying = false;
            gameOverText.ForeColor = Color.White;
            // Set the parameters value as the text
            gameOverText.Text = message;
            gameOverText.Font = new Font("OCR A Extended", 14);
            gameOverText.Location = new Point(140, 300);
            gameOverText.Size = new Size(489, 30);
            gameOverText.BringToFront();
        }
    }
}
