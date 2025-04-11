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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkNatural = new System.Windows.Forms.Button();
            this.checkNaturalPlayer1 = new System.Windows.Forms.Button();
            this.checkNaturalPlayer2 = new System.Windows.Forms.Button();
            this.checkNaturalDealer = new System.Windows.Forms.Button();
            this.dealerPoints = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.dealingCard.Location = new System.Drawing.Point(440, 180);
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
            this.card1Player1.Size = new System.Drawing.Size(112, 16);
            this.card1Player1.TabIndex = 4;
            this.card1Player1.Text = "<Player 1 Card 1>";
            // 
            // card1Player2
            // 
            this.card1Player2.AutoSize = true;
            this.card1Player2.Location = new System.Drawing.Point(695, 64);
            this.card1Player2.Name = "card1Player2";
            this.card1Player2.Size = new System.Drawing.Size(112, 16);
            this.card1Player2.TabIndex = 5;
            this.card1Player2.Text = "<Player 2 Card 1>";
            // 
            // firstCardDealer
            // 
            this.firstCardDealer.AutoSize = true;
            this.firstCardDealer.Location = new System.Drawing.Point(593, 193);
            this.firstCardDealer.Name = "firstCardDealer";
            this.firstCardDealer.Size = new System.Drawing.Size(104, 16);
            this.firstCardDealer.TabIndex = 6;
            this.firstCardDealer.Text = "<Dealer Card 1>";
            // 
            // card2Player1
            // 
            this.card2Player1.AutoSize = true;
            this.card2Player1.Location = new System.Drawing.Point(492, 94);
            this.card2Player1.Name = "card2Player1";
            this.card2Player1.Size = new System.Drawing.Size(119, 16);
            this.card2Player1.TabIndex = 7;
            this.card2Player1.Text = "<Placyer 1 Card 2>";
            // 
            // card2Player2
            // 
            this.card2Player2.AutoSize = true;
            this.card2Player2.Location = new System.Drawing.Point(695, 94);
            this.card2Player2.Name = "card2Player2";
            this.card2Player2.Size = new System.Drawing.Size(112, 16);
            this.card2Player2.TabIndex = 8;
            this.card2Player2.Text = "<Player 2 Card 2>";
            // 
            // secondCardDealer
            // 
            this.secondCardDealer.AutoSize = true;
            this.secondCardDealer.Location = new System.Drawing.Point(593, 218);
            this.secondCardDealer.Name = "secondCardDealer";
            this.secondCardDealer.Size = new System.Drawing.Size(104, 16);
            this.secondCardDealer.TabIndex = 9;
            this.secondCardDealer.Text = "<Dealer Card 2>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(505, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Player 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(715, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Player 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(612, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Dealer";
            // 
            // checkNatural
            // 
            this.checkNatural.Location = new System.Drawing.Point(0, 0);
            this.checkNatural.Name = "checkNatural";
            this.checkNatural.Size = new System.Drawing.Size(75, 23);
            this.checkNatural.TabIndex = 0;
            // 
            // checkNaturalPlayer1
            // 
            this.checkNaturalPlayer1.Location = new System.Drawing.Point(88, 218);
            this.checkNaturalPlayer1.Name = "checkNaturalPlayer1";
            this.checkNaturalPlayer1.Size = new System.Drawing.Size(116, 59);
            this.checkNaturalPlayer1.TabIndex = 13;
            this.checkNaturalPlayer1.Text = "Check for Natural Player 1";
            this.checkNaturalPlayer1.UseVisualStyleBackColor = true;
            this.checkNaturalPlayer1.Click += new System.EventHandler(this.checkNaturalPlayer1_Click);
            // 
            // checkNaturalPlayer2
            // 
            this.checkNaturalPlayer2.Location = new System.Drawing.Point(88, 283);
            this.checkNaturalPlayer2.Name = "checkNaturalPlayer2";
            this.checkNaturalPlayer2.Size = new System.Drawing.Size(116, 59);
            this.checkNaturalPlayer2.TabIndex = 14;
            this.checkNaturalPlayer2.Text = "Check for Natural Player 2";
            this.checkNaturalPlayer2.UseVisualStyleBackColor = true;
            this.checkNaturalPlayer2.Click += new System.EventHandler(this.checkNaturalPlayer2_Click);
            // 
            // checkNaturalDealer
            // 
            this.checkNaturalDealer.Location = new System.Drawing.Point(88, 348);
            this.checkNaturalDealer.Name = "checkNaturalDealer";
            this.checkNaturalDealer.Size = new System.Drawing.Size(116, 59);
            this.checkNaturalDealer.TabIndex = 15;
            this.checkNaturalDealer.Text = "Check Natural Dealer";
            this.checkNaturalDealer.UseVisualStyleBackColor = true;
            this.checkNaturalDealer.Click += new System.EventHandler(this.checkNaturalDealer_Click);
            // 
            // dealerPoints
            // 
            this.dealerPoints.AutoSize = true;
            this.dealerPoints.Location = new System.Drawing.Point(724, 369);
            this.dealerPoints.Name = "dealerPoints";
            this.dealerPoints.Size = new System.Drawing.Size(177, 16);
            this.dealerPoints.TabIndex = 16;
            this.dealerPoints.Text = "<Placeholder points Dealer>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(603, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Dealer total points";
            // 
            // BlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 496);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dealerPoints);
            this.Controls.Add(this.checkNaturalDealer);
            this.Controls.Add(this.checkNaturalPlayer2);
            this.Controls.Add(this.checkNaturalPlayer1);
            this.Controls.Add(this.checkNatural);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button checkNatural;
        private System.Windows.Forms.Button checkNaturalPlayer1;
        private System.Windows.Forms.Button checkNaturalPlayer2;
        private System.Windows.Forms.Button checkNaturalDealer;
        private System.Windows.Forms.Label dealerPoints;
        private System.Windows.Forms.Label label4;
    }
}

