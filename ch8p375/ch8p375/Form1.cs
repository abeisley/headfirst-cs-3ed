using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch8p375
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < 13; j++)
                {
                    // add a card to the deck
                }
            }
        }

        List<Card> deck = new List<Card>();
        // TODO: Add a shuffle method

        private void draw1_Click(object sender, EventArgs e)
        {
            Card topCard = deck[0];
            deck.RemoveAt(0);
            textBox1.Text = topCard.Name;
        }
    }
}
