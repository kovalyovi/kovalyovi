using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class Form1 : Form
    {
        // Create a Random object called randomizer 
        // to generate random numbers.
        Random randomizer = new Random();

        // These integer variables store the numbers 
        // for the addition problem. 
        int addend1;
        int addend2;

        // These integer variables store the numbers 
        // for the subtraction problem. 
        int minuend;
        int subtrahend;

        // These integer variables store the numbers 
        // for the subtraction problem. 
        int multend1;
        int multend2;

        // These integer variables store the numbers 
        // for the subtraction problem. 
        int divend1;
        int divend2;
        
        // This integer variable keeps track of the 
        // remaining time.
        int timeLeft;

        /// <summary>
        /// Start the quiz by filling in all of the problems
        /// and starting the timer.
        /// </summary>
        public void StartTheQuiz()
        {
            // Fill in the addition problem.
            // Generate two random numbers to add.
            // Store the values in the variables 'addend1' and 'addend2'.
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);
            do
            {
                minuend = randomizer.Next(101);
                subtrahend = randomizer.Next(101);
            } while (minuend < subtrahend);

            multend1 = randomizer.Next(3, 11);
            multend2 = randomizer.Next(3, 11);

            do
            {
                divend1 = randomizer.Next(2, 101);
                divend2 = randomizer.Next(2, 21);
            } while (divend1 % divend2 != 0
                  || divend1 / divend2 == 1);

            // Convert the two randomly generated numbers
            // into strings so that they can be displayed
            // in the label controls.
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            timesLeftLabel.Text = multend1.ToString();
            timesRightLabel.Text = multend2.ToString();
            dividedLeftLabel.Text = divend1.ToString();
            dividedRightLabel.Text = divend2.ToString();
            

            // 'sum' is the name of the NumericUpDown control.
            // This step makes sure its value is zero before
            // adding any values to it.
            sum.Value = 0;
            minus.Value = 0;
            product.Value = 0;
            quotient.Value = 0;

            timeLabel.BackColor = SystemColors.Control;
            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
        }

        private bool CheckTheAnswer()
        {
            return ((addend1 + addend2 == sum.Value) &&
                    (minuend - subtrahend == minus.Value) &&
                    (multend1 * multend2 == product.Value) &&
                    (divend1 / divend2 == quotient.Value));
        }

        public Form1()
        {
            InitializeComponent();
            dateLabel.Text = DateTime.Now.ToString("MM-dd-yyyy");
        }


        private void StartButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                timer1.Stop();
                timeLabel.BackColor = Color.Green;
                SoundPlayer simpleSound = new SoundPlayer();
                simpleSound.Play();

                MessageBox.Show("You got all the answers right!",
                            "Congratulations!");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                timeLeft --;
                timeLabel.Text = timeLeft + " seconds";
                if (timeLeft < 6)
                {
                    timeLabel.BackColor = Color.Red;
                }
            }
            else
            { 
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                sum.Value = addend1 + addend2;
                minus.Value = minuend - subtrahend;
                product.Value = multend1 * multend2;
                quotient.Value = divend1 / divend2;
                startButton.Enabled = true;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpDown control.
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }
    }
}
