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
            this.dealingCard = new System.Windows.Forms.Button();
            this.card1Player1 = new System.Windows.Forms.Label();
            this.card1Player2 = new System.Windows.Forms.Label();
            this.firstCardDealer = new System.Windows.Forms.Label();
            this.card2Player1 = new System.Windows.Forms.Label();
            this.card2Player2 = new System.Windows.Forms.Label();
            this.secondCardDealer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Shuffle
            // 
            this.Shuffle.Location = new System.Drawing.Point(60, 31);
            this.Shuffle.Name = "Shuffle";
            this.Shuffle.Size = new System.Drawing.Size(94, 65);
            this.Shuffle.TabIndex = 0;
            this.Shuffle.Text = "Shuffle";
            this.Shuffle.UseVisualStyleBackColor = true;
            this.Shuffle.Click += new System.EventHandler(this.shuffleButton_Click);
            // 
            // drawnCard
            // 
            this.drawnCard.Location = new System.Drawing.Point(60, 116);
            this.drawnCard.Name = "drawnCard";
            this.drawnCard.Size = new System.Drawing.Size(121, 65);
            this.drawnCard.TabIndex = 1;
            this.drawnCard.Text = "Draw Card";
            this.drawnCard.UseVisualStyleBackColor = true;
            this.drawnCard.Click += new System.EventHandler(this.drawCards_Click);
            // 
            // textDrawnCard
            // 
            this.textDrawnCard.AutoSize = true;
            this.textDrawnCard.Location = new System.Drawing.Point(212, 140);
            this.textDrawnCard.Name = "textDrawnCard";
            this.textDrawnCard.Size = new System.Drawing.Size(117, 16);
            this.textDrawnCard.TabIndex = 2;
            this.textDrawnCard.Text = "<Placeholder text>";
            // 
            // dealingCard
            // 
            this.dealingCard.Location = new System.Drawing.Point(442, 192);
            this.dealingCard.Name = "dealingCard";
            this.dealingCard.Size = new System.Drawing.Size(109, 69);
            this.dealingCard.TabIndex = 3;
            this.dealingCard.Text = "Dealing Cards";
            this.dealingCard.UseVisualStyleBackColor = true;
            this.dealingCard.Click += new System.EventHandler(this.dealingCard_Click);
            // 
            // card1Player1
            // 
            this.card1Player1.AutoSize = true;
            this.card1Player1.Location = new System.Drawing.Point(492, 64);
            this.card1Player1.Name = "card1Player1";
            this.card1Player1.Size = new System.Drawing.Size(136, 16);
            this.card1Player1.TabIndex = 4;
            this.card1Player1.Text = "<Placeholder Card 1>";
            // 
            // card1Player2
            // 
            this.card1Player2.AutoSize = true;
            this.card1Player2.Location = new System.Drawing.Point(647, 64);
            this.card1Player2.Name = "card1Player2";
            this.card1Player2.Size = new System.Drawing.Size(136, 16);
            this.card1Player2.TabIndex = 5;
            this.card1Player2.Text = "<Placeholder Card 1>";
            // 
            // firstCardDealer
            // 
            this.firstCardDealer.AutoSize = true;
            this.firstCardDealer.Location = new System.Drawing.Point(593, 193);
            this.firstCardDealer.Name = "firstCardDealer";
            this.firstCardDealer.Size = new System.Drawing.Size(136, 16);
            this.firstCardDealer.TabIndex = 6;
            this.firstCardDealer.Text = "<Placeholder Card 1>";
            // 
            // card2Player1
            // 
            this.card2Player1.AutoSize = true;
            this.card2Player1.Location = new System.Drawing.Point(492, 94);
            this.card2Player1.Name = "card2Player1";
            this.card2Player1.Size = new System.Drawing.Size(136, 16);
            this.card2Player1.TabIndex = 7;
            this.card2Player1.Text = "<Placeholder Card 2>";
            // 
            // card2Player2
            // 
            this.card2Player2.AutoSize = true;
            this.card2Player2.Location = new System.Drawing.Point(647, 94);
            this.card2Player2.Name = "card2Player2";
            this.card2Player2.Size = new System.Drawing.Size(136, 16);
            this.card2Player2.TabIndex = 8;
            this.card2Player2.Text = "<Placeholder Card 2>";
            // 
            // secondCardDealer
            // 
            this.secondCardDealer.AutoSize = true;
            this.secondCardDealer.Location = new System.Drawing.Point(593, 218);
            this.secondCardDealer.Name = "secondCardDealer";
            this.secondCardDealer.Size = new System.Drawing.Size(136, 16);
            this.secondCardDealer.TabIndex = 9;
            this.secondCardDealer.Text = "<Placeholder Card 2>";
            // 
            // BlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 376);
            this.Controls.Add(this.secondCardDealer);
            this.Controls.Add(this.card2Player2);
            this.Controls.Add(this.card2Player1);
            this.Controls.Add(this.firstCardDealer);
            this.Controls.Add(this.card1Player2);
            this.Controls.Add(this.card1Player1);
            this.Controls.Add(this.dealingCard);
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
        private System.Windows.Forms.Button dealingCard;
        private System.Windows.Forms.Label card1Player1;
        private System.Windows.Forms.Label card1Player2;
        private System.Windows.Forms.Label firstCardDealer;
        private System.Windows.Forms.Label card2Player1;
        private System.Windows.Forms.Label card2Player2;
        private System.Windows.Forms.Label secondCardDealer;
    }
}

