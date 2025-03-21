namespace Blackjack
{
    partial class BlackJack
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
            this.Shuffle = new System.Windows.Forms.Button();
            this.drawnCard = new System.Windows.Forms.Button();
            this.textDrawnCard = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Shuffle
            // 
            this.Shuffle.Location = new System.Drawing.Point(210, 104);
            this.Shuffle.Name = "Shuffle";
            this.Shuffle.Size = new System.Drawing.Size(94, 65);
            this.Shuffle.TabIndex = 0;
            this.Shuffle.Text = "Shuffle";
            this.Shuffle.UseVisualStyleBackColor = true;
            this.Shuffle.Click += new System.EventHandler(this.shuffleButton_Click);
            // 
            // drawnCard
            // 
            this.drawnCard.Location = new System.Drawing.Point(465, 123);
            this.drawnCard.Name = "drawnCard";
            this.drawnCard.Size = new System.Drawing.Size(121, 65);
            this.drawnCard.TabIndex = 1;
            this.drawnCard.Text = "Draw Card";
            this.drawnCard.UseVisualStyleBackColor = true;
            this.drawnCard.Click += new System.EventHandler(this.button1_Click);
            // 
            // textDrawnCard
            // 
            this.textDrawnCard.AutoSize = true;
            this.textDrawnCard.Location = new System.Drawing.Point(643, 153);
            this.textDrawnCard.Name = "textDrawnCard";
            this.textDrawnCard.Size = new System.Drawing.Size(117, 16);
            this.textDrawnCard.TabIndex = 2;
            this.textDrawnCard.Text = "<Placeholder text>";
            // 
            // BlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 376);
            this.Controls.Add(this.textDrawnCard);
            this.Controls.Add(this.drawnCard);
            this.Controls.Add(this.Shuffle);
            this.Name = "BlackJack";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Shuffle;
        private System.Windows.Forms.Button drawnCard;
        private System.Windows.Forms.Label textDrawnCard;
    }
}

