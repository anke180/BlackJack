using Blackjack.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class BlackJack : Form
    {
        Card twoOfHearts = new Card(Suits.HEARTS, FaceValues.TWO);

        public BlackJack()
        {
            InitializeComponent();
            twoOfHearts.Suit = Suits.HEARTS;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("It works!");
        }
    }
}