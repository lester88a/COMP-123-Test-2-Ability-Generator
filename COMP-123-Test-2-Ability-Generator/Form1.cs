using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Student Name: LI XU
 * Student ID: 300735072
 * COMP-123-TEST2 Ability Generator
 * Date: March 25, 2015
 */
namespace COMP_123_Test_2_Ability_Generator
{
    public partial class AbilityForm : Form
    {
        public AbilityForm()
        {
            InitializeComponent();
        }

        private void RollButton_Click(object sender, EventArgs e)
        {
            //declear the random number between 1 to 100
            Random rnd = new Random();
            int rndNumber1 = rnd.Next(1, 101);
            int rndNumber2 = rnd.Next(1, 101);
            int rndNumber3 = rnd.Next(1, 101);
            int rndNumber4 = rnd.Next(1, 101);
            int rndNumber5 = rnd.Next(1, 101);
            int rndNumber6 = rnd.Next(1, 101);
            int rndNumber7 = rnd.Next(1, 101);

            //call randomNumber generator if the textbox has nothing
            if (FightingTextBox.Text=="")
            {
                RandomNumber(rndNumber1, rndNumber2, rndNumber3, rndNumber4, rndNumber5, rndNumber6, rndNumber7);
            }
            //call randomNumber generator if the textbox has numbers
            else if (FightingTextBox.Text.Length>=1)
            {
                RandomNumber(rndNumber1, rndNumber2, rndNumber3, rndNumber4, rndNumber5, rndNumber6, rndNumber7);
            }
          
        }

        //PRIVATE METHOD++++++++++++++++++++++++++++++++++++++
        //generates random number method
        private void RandomNumber(int rndNumber1, int rndNumber2, int rndNumber3, int rndNumber4, int rndNumber5, int rndNumber6, int rndNumber7)
        {
            FightingTextBox.Text = Convert.ToString(rndNumber1);
            AgilityTextBox.Text = Convert.ToString(rndNumber2);
            StrengthTextBox.Text = Convert.ToString(rndNumber3);
            EnduranceTextBox.Text = Convert.ToString(rndNumber4);
            ReasonTextBox.Text = Convert.ToString(rndNumber5);
            IntuitionTextBox.Text = Convert.ToString(rndNumber6);
            PsycheTextBox.Text = Convert.ToString(rndNumber7);
        }
    }
}
