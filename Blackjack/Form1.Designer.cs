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
            this.SuspendLayout();
            // 
            // Shuffle
            // 
            this.Shuffle.Location = new System.Drawing.Point(284, 166);
            this.Shuffle.Name = "Shuffle";
            this.Shuffle.Size = new System.Drawing.Size(94, 65);
            this.Shuffle.TabIndex = 0;
            this.Shuffle.Text = "Shuffle";
            this.Shuffle.UseVisualStyleBackColor = true;
            this.Shuffle.Click += new System.EventHandler(this.shuffleButton_Click);
            // 
            // BlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 405);
            this.Controls.Add(this.Shuffle);
            this.Name = "BlackJack";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Shuffle;
    }
}

