namespace FlappyBird
{
    partial class backGround
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
            this.ground = new System.Windows.Forms.PictureBox();
            this.upperPipe = new System.Windows.Forms.PictureBox();
            this.lowerPipe = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.txtScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.SkyBlue;
            this.ground.Image = global::FlappyBird.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-5, 522);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(719, 180);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            // 
            // upperPipe
            // 
            this.upperPipe.BackColor = System.Drawing.Color.SkyBlue;
            this.upperPipe.Image = global::FlappyBird.Properties.Resources.pipedown;
            this.upperPipe.Location = new System.Drawing.Point(388, -1);
            this.upperPipe.Name = "upperPipe";
            this.upperPipe.Size = new System.Drawing.Size(107, 147);
            this.upperPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.upperPipe.TabIndex = 1;
            this.upperPipe.TabStop = false;
            // 
            // lowerPipe
            // 
            this.lowerPipe.BackColor = System.Drawing.Color.SkyBlue;
            this.lowerPipe.Image = global::FlappyBird.Properties.Resources.pipe;
            this.lowerPipe.Location = new System.Drawing.Point(388, 335);
            this.lowerPipe.Name = "lowerPipe";
            this.lowerPipe.Size = new System.Drawing.Size(107, 190);
            this.lowerPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lowerPipe.TabIndex = 2;
            this.lowerPipe.TabStop = false;
            // 
            // flappyBird
            // 
            this.flappyBird.Image = global::FlappyBird.Properties.Resources.bird;
            this.flappyBird.Location = new System.Drawing.Point(16, 204);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(86, 72);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 3;
            this.flappyBird.TabStop = false;
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(14, 563);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(88, 24);
            this.txtScore.TabIndex = 4;
            this.txtScore.Text = "Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // backGround
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(622, 607);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.lowerPipe);
            this.Controls.Add(this.upperPipe);
            this.Name = "backGround";
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox upperPipe;
        private System.Windows.Forms.PictureBox lowerPipe;
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Timer gameTimer;
    }
}

