using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRoller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Btn_Roll_Dice_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            Graphics gfx = CreateGraphics();
            gfx.Clear(DefaultBackColor);

            int diceRollOne = rand.Next(1, 7);
            string diceRollPathOne = Application.StartupPath + @"\DICE" + diceRollOne + ".gif";
            Image diceOne = Image.FromFile(diceRollPathOne);
            gfx.DrawImage(diceOne,(ClientRectangle.Width / 2) - (diceOne.Width / 8), ClientRectangle.Height / 2 - (diceOne.Width / 8), diceOne.Width / 8, diceOne.Height / 8);

            int diceRollTwo = rand.Next(1, 7);
            string diceRollPathTwo = Application.StartupPath + @"\DICE" + diceRollTwo + ".gif";
            Image diceTwo = Image.FromFile(diceRollPathTwo);
            gfx.DrawImage(diceTwo, (ClientRectangle.Width / 2) + 10, ClientRectangle.Height / 2 - (diceTwo.Width / 8), diceTwo.Width / 8, diceTwo.Height / 8);

            int diceRollSum = diceRollOne + diceRollTwo;
            Lbl_Roll_Sum.Text = "Dice Total: " + diceRollSum;


        }



    }
}
