namespace PHF {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.rockButton = new System.Windows.Forms.Button();
            this.paperButton = new System.Windows.Forms.Button();
            this.scissorButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.humanScoreLabel = new System.Windows.Forms.Label();
            this.computerScoreLabel = new System.Windows.Forms.Label();
            this.outcomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // rockButton
            // 
            this.rockButton.BackgroundImage = global::PHF.Properties.Resources.Rock;
            this.rockButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rockButton.Location = new System.Drawing.Point(55, 12);
            this.rockButton.Name = "rockButton";
            this.rockButton.Size = new System.Drawing.Size(116, 60);
            this.rockButton.TabIndex = 0;
            this.rockButton.UseVisualStyleBackColor = true;
            this.rockButton.Click += new System.EventHandler(this.rockButton_Click);
            // 
            // paperButton
            // 
            this.paperButton.BackgroundImage = global::PHF.Properties.Resources.Paper;
            this.paperButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.paperButton.Location = new System.Drawing.Point(252, 12);
            this.paperButton.Name = "paperButton";
            this.paperButton.Size = new System.Drawing.Size(124, 60);
            this.paperButton.TabIndex = 1;
            this.paperButton.UseVisualStyleBackColor = true;
            this.paperButton.Click += new System.EventHandler(this.paperButton_Click);
            // 
            // scissorButton
            // 
            this.scissorButton.BackgroundImage = global::PHF.Properties.Resources.Scissors;
            this.scissorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.scissorButton.Location = new System.Drawing.Point(452, 12);
            this.scissorButton.Name = "scissorButton";
            this.scissorButton.Size = new System.Drawing.Size(136, 60);
            this.scissorButton.TabIndex = 2;
            this.scissorButton.UseVisualStyleBackColor = true;
            this.scissorButton.Click += new System.EventHandler(this.scissorButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PHF.Properties.Resources.Rock;
            this.pictureBox1.Location = new System.Drawing.Point(22, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PHF.Properties.Resources.Rock;
            this.pictureBox2.Location = new System.Drawing.Point(400, 124);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(272, 252);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(508, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Computer";
            // 
            // humanScoreLabel
            // 
            this.humanScoreLabel.AutoSize = true;
            this.humanScoreLabel.Location = new System.Drawing.Point(19, 390);
            this.humanScoreLabel.Name = "humanScoreLabel";
            this.humanScoreLabel.Size = new System.Drawing.Size(35, 13);
            this.humanScoreLabel.TabIndex = 7;
            this.humanScoreLabel.Text = "Score";
            this.humanScoreLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // computerScoreLabel
            // 
            this.computerScoreLabel.AutoSize = true;
            this.computerScoreLabel.Location = new System.Drawing.Point(620, 390);
            this.computerScoreLabel.Name = "computerScoreLabel";
            this.computerScoreLabel.Size = new System.Drawing.Size(35, 13);
            this.computerScoreLabel.TabIndex = 8;
            this.computerScoreLabel.Text = "Score";
            // 
            // outcomeLabel
            // 
            this.outcomeLabel.AutoSize = true;
            this.outcomeLabel.Location = new System.Drawing.Point(328, 390);
            this.outcomeLabel.Name = "outcomeLabel";
            this.outcomeLabel.Size = new System.Drawing.Size(25, 13);
            this.outcomeLabel.TabIndex = 9;
            this.outcomeLabel.Text = "Info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 451);
            this.Controls.Add(this.outcomeLabel);
            this.Controls.Add(this.computerScoreLabel);
            this.Controls.Add(this.humanScoreLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.scissorButton);
            this.Controls.Add(this.paperButton);
            this.Controls.Add(this.rockButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rockButton;
        private System.Windows.Forms.Button paperButton;
        private System.Windows.Forms.Button scissorButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label humanScoreLabel;
        private System.Windows.Forms.Label computerScoreLabel;
        private System.Windows.Forms.Label outcomeLabel;
    }
}

