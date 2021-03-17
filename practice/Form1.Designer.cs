namespace practice
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.startGameText = new System.Windows.Forms.Label();
            this.scoreText = new System.Windows.Forms.Label();
            this.gameOverText = new System.Windows.Forms.Label();
            this.alienBulletTimer = new System.Windows.Forms.Timer(this.components);
            this.livesText = new System.Windows.Forms.Label();
            this.alienImage6 = new System.Windows.Forms.PictureBox();
            this.alienImage3 = new System.Windows.Forms.PictureBox();
            this.alienImage9 = new System.Windows.Forms.PictureBox();
            this.alienImage8 = new System.Windows.Forms.PictureBox();
            this.alienImage1 = new System.Windows.Forms.PictureBox();
            this.alienImage7 = new System.Windows.Forms.PictureBox();
            this.alienImage4 = new System.Windows.Forms.PictureBox();
            this.alienImage5 = new System.Windows.Forms.PictureBox();
            this.alienImage2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.alienImage6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alienImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alienImage9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alienImage8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alienImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alienImage7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alienImage4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alienImage5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alienImage2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 3;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // startGameText
            // 
            this.startGameText.AutoSize = true;
            this.startGameText.Font = new System.Drawing.Font("OCR A Extended", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGameText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.startGameText.Location = new System.Drawing.Point(170, 300);
            this.startGameText.Name = "startGameText";
            this.startGameText.Size = new System.Drawing.Size(489, 30);
            this.startGameText.TabIndex = 14;
            this.startGameText.Text = "Press F5 To Start A New Game";
            this.startGameText.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.scoreText.Location = new System.Drawing.Point(16, 388);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(0, 25);
            this.scoreText.TabIndex = 15;
            // 
            // gameOverText
            // 
            this.gameOverText.AutoSize = true;
            this.gameOverText.Font = new System.Drawing.Font("OCR A Extended", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gameOverText.Location = new System.Drawing.Point(70, 167);
            this.gameOverText.Name = "gameOverText";
            this.gameOverText.Size = new System.Drawing.Size(0, 30);
            this.gameOverText.TabIndex = 16;
            this.gameOverText.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gameOverText.Visible = false;
            // 
            // alienBulletTimer
            // 
            this.alienBulletTimer.Enabled = true;
            this.alienBulletTimer.Interval = 1500;
            this.alienBulletTimer.Tick += new System.EventHandler(this.alienBulletTimer_Tick);
            // 
            // livesText
            // 
            this.livesText.AutoSize = true;
            this.livesText.ForeColor = System.Drawing.SystemColors.Control;
            this.livesText.Location = new System.Drawing.Point(386, 388);
            this.livesText.Name = "livesText";
            this.livesText.Size = new System.Drawing.Size(0, 20);
            this.livesText.TabIndex = 17;
            // 
            // alienImage6
            // 
            this.alienImage6.Location = new System.Drawing.Point(262, 108);
            this.alienImage6.Name = "alienImage6";
            this.alienImage6.Size = new System.Drawing.Size(45, 45);
            this.alienImage6.TabIndex = 21;
            this.alienImage6.TabStop = false;
            // 
            // alienImage3
            // 
            this.alienImage3.Location = new System.Drawing.Point(442, 46);
            this.alienImage3.Name = "alienImage3";
            this.alienImage3.Size = new System.Drawing.Size(45, 45);
            this.alienImage3.TabIndex = 5;
            this.alienImage3.TabStop = false;
            // 
            // alienImage9
            // 
            this.alienImage9.Location = new System.Drawing.Point(75, 46);
            this.alienImage9.Name = "alienImage9";
            this.alienImage9.Size = new System.Drawing.Size(45, 45);
            this.alienImage9.TabIndex = 12;
            this.alienImage9.TabStop = false;
            // 
            // alienImage8
            // 
            this.alienImage8.Location = new System.Drawing.Point(139, 108);
            this.alienImage8.Name = "alienImage8";
            this.alienImage8.Size = new System.Drawing.Size(45, 45);
            this.alienImage8.TabIndex = 24;
            this.alienImage8.TabStop = false;
            // 
            // alienImage1
            // 
            this.alienImage1.Location = new System.Drawing.Point(562, 46);
            this.alienImage1.Name = "alienImage1";
            this.alienImage1.Size = new System.Drawing.Size(45, 45);
            this.alienImage1.TabIndex = 13;
            this.alienImage1.TabStop = false;
            // 
            // alienImage7
            // 
            this.alienImage7.Location = new System.Drawing.Point(200, 46);
            this.alienImage7.Name = "alienImage7";
            this.alienImage7.Size = new System.Drawing.Size(45, 45);
            this.alienImage7.TabIndex = 10;
            this.alienImage7.TabStop = false;
            // 
            // alienImage4
            // 
            this.alienImage4.Location = new System.Drawing.Point(382, 108);
            this.alienImage4.Name = "alienImage4";
            this.alienImage4.Size = new System.Drawing.Size(45, 45);
            this.alienImage4.TabIndex = 19;
            this.alienImage4.TabStop = false;
            // 
            // alienImage5
            // 
            this.alienImage5.Location = new System.Drawing.Point(323, 46);
            this.alienImage5.Name = "alienImage5";
            this.alienImage5.Size = new System.Drawing.Size(45, 45);
            this.alienImage5.TabIndex = 7;
            this.alienImage5.TabStop = false;
            // 
            // alienImage2
            // 
            this.alienImage2.Location = new System.Drawing.Point(502, 108);
            this.alienImage2.Name = "alienImage2";
            this.alienImage2.Size = new System.Drawing.Size(45, 45);
            this.alienImage2.TabIndex = 22;
            this.alienImage2.TabStop = false;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(678, 644);
            this.Controls.Add(this.alienImage8);
            this.Controls.Add(this.alienImage2);
            this.Controls.Add(this.alienImage6);
            this.Controls.Add(this.alienImage4);
            this.Controls.Add(this.livesText);
            this.Controls.Add(this.gameOverText);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.startGameText);
            this.Controls.Add(this.alienImage1);
            this.Controls.Add(this.alienImage9);
            this.Controls.Add(this.alienImage7);
            this.Controls.Add(this.alienImage5);
            this.Controls.Add(this.alienImage3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.alienImage6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alienImage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alienImage9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alienImage8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alienImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alienImage7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alienImage4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alienImage5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alienImage2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label scoreText;
        protected System.Windows.Forms.Label startGameText;
        public System.Windows.Forms.Timer gameTimer;
        protected System.Windows.Forms.Label gameOverText;
        private System.Windows.Forms.Timer alienBulletTimer;
        private System.Windows.Forms.Label livesText;
        private System.Windows.Forms.PictureBox alienImage6;
        private System.Windows.Forms.PictureBox alienImage3;
        private System.Windows.Forms.PictureBox alienImage9;
        private System.Windows.Forms.PictureBox alienImage8;
        private System.Windows.Forms.PictureBox alienImage1;
        private System.Windows.Forms.PictureBox alienImage7;
        private System.Windows.Forms.PictureBox alienImage4;
        private System.Windows.Forms.PictureBox alienImage5;
        private System.Windows.Forms.PictureBox alienImage2;
    }
}

