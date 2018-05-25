namespace magicEightBall
{
    partial class magicBallForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(magicBallForm));
            this.answerButton = new System.Windows.Forms.Button();
            this.sheevModeCheck = new System.Windows.Forms.CheckBox();
            this.answerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // answerButton
            // 
            this.answerButton.AutoSize = true;
            this.answerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerButton.Location = new System.Drawing.Point(12, 524);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(157, 39);
            this.answerButton.TabIndex = 0;
            this.answerButton.Text = "Give Me An Answer";
            this.answerButton.UseVisualStyleBackColor = true;
            this.answerButton.Click += new System.EventHandler(this.answerButton_Click);
            // 
            // sheevModeCheck
            // 
            this.sheevModeCheck.AutoSize = true;
            this.sheevModeCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sheevModeCheck.Location = new System.Drawing.Point(458, 536);
            this.sheevModeCheck.Name = "sheevModeCheck";
            this.sheevModeCheck.Size = new System.Drawing.Size(104, 20);
            this.sheevModeCheck.TabIndex = 1;
            this.sheevModeCheck.Text = "Sheev Mode";
            this.sheevModeCheck.UseVisualStyleBackColor = true;
            // 
            // answerLabel
            // 
            this.answerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerLabel.Location = new System.Drawing.Point(224, 429);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(176, 36);
            this.answerLabel.TabIndex = 2;
            this.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // magicBallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(613, 575);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.sheevModeCheck);
            this.Controls.Add(this.answerButton);
            this.DoubleBuffered = true;
            this.Name = "magicBallForm";
            this.Text = "Magic 8 Ball";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button answerButton;
        private System.Windows.Forms.CheckBox sheevModeCheck;
        private System.Windows.Forms.Label answerLabel;
    }
}

