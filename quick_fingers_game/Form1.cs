using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quick_fingers_game
{
    struct Expression
    {
        public string expression;
        public string result;

        public Expression(string e, string r)
        {
            this.expression = e;
            this.result = r;
        }
    }

    public partial class Form1 : Form
    {
        private const int secondsPerGame = 180;
        private const int expressionsCount = 30;
        private int currentExpressionNumber;
        private DateTime endTime;
        TimeSpan ts;
        private int correctGuesses = 0;
        private int incorrectGuesses = 0;
        private string currentGuess = "";
        Expression[] exps = new Expression[expressionsCount];

        public string CurrentGuess 
        { 
            get => currentGuess;
            set
            {
                currentGuess = value;
                textbox_guess.Text = currentGuess;
            }
        }

        public Form1()
        {
            InitializeComponent();
            initializeExpressions();
        }

        private void initializeExpressions()
        {
            exps[0] = new Expression("2+3*1/1+4*5", "25");
            exps[1] = new Expression("7*8+6*9-27", "83");
            exps[2] = new Expression("0*7/1+9*9", "81");
            exps[3] = new Expression("14*2*2-17+3*2", "45");
            exps[4] = new Expression("5*6*2-5*3*4", "0");
            exps[5] = new Expression("5/2+2*2+2", "8.5");
            exps[6] = new Expression("6/4-2+3*3", "8.5");
            exps[7] = new Expression("-10+11*2-1/4", "11.75");
            exps[8] = new Expression("9*7-6*10/2", "1.5");
            exps[9] = new Expression("17*2-10/2+4", "33");
            exps[10] = new Expression("7/2+3.5*2", "10.5");
            exps[11] = new Expression("19*0+12/6+8", "10");
            exps[12] = new Expression("19+9-2*12", "4");
            exps[13] = new Expression("0.25+0.13*3", "0.64");
            exps[14] = new Expression("0.19+1.78*2", "3.75");
            exps[15] = new Expression("9/3+3.3*3+0.1", "13");
            exps[16] = new Expression("7*7-7+7", "49");
            exps[17] = new Expression("24-24*0+0.24*1/1", "24.24");
            exps[18] = new Expression("8/5+1.6-5+6", "4.2");
            exps[19] = new Expression("1.2+6.9-0.5*3", "6.6");
            exps[20] = new Expression("50/5+1/5*10", "12");
            exps[21] = new Expression("4.1+0.5-0.7*3+6.2", "8.7");
            exps[22] = new Expression("17+5-19+3", "6");
            exps[23] = new Expression("2/4+0.5*7+7", "11");
            exps[24] = new Expression("3*3*3-19", "8");
            exps[25] = new Expression("0/2+9*2+10-17", "11");
            exps[26] = new Expression("5*4*0.2+0.67", "4.67");
            exps[27] = new Expression("11+2*4/2", "15");
            exps[28] = new Expression("1/8+0.4+1/8", "0.65");
            exps[29] = new Expression("17-2*6+0.17", "5.17");
        }

        private void unlockButtons()
        {
            button_confirm_guess.Enabled = true;
            button_0.Enabled = true;
            button_1.Enabled = true;
            button_2.Enabled = true;
            button_3.Enabled = true;
            button_4.Enabled = true;
            button_5.Enabled = true;
            button_6.Enabled = true;
            button_7.Enabled = true;
            button_8.Enabled = true;
            button_9.Enabled = true;
            button_backspace.Enabled = true;
            button_dot.Enabled = true;
        }

        private void lockButtons()
        {
            button_confirm_guess.Enabled = false;
            button_0.Enabled = false;
            button_1.Enabled = false;
            button_2.Enabled = false;
            button_3.Enabled = false;
            button_4.Enabled = false;
            button_5.Enabled = false;
            button_6.Enabled = false;
            button_7.Enabled = false;
            button_8.Enabled = false;
            button_9.Enabled = false;
            button_backspace.Enabled = false;
            button_dot.Enabled = false;
        }

        private void resetData()
        {
            correctGuesses = 0;
            incorrectGuesses = 0;
            CurrentGuess = "";
            label_correct_guesses.Text = correctGuesses.ToString();
            label_incorrect_guesses.Text = incorrectGuesses.ToString();
            textbox_guess.Text = CurrentGuess;
        }

        private void drawExpression()
        {
            Random rng = new Random();
            int prev = currentExpressionNumber;
            while (prev == currentExpressionNumber)
            {
                currentExpressionNumber = rng.Next(0, expressionsCount);
            } 
            textbox_expression.Text = exps[currentExpressionNumber].expression;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ts = endTime.Subtract(DateTime.Now);
            label_remaining_time.Text = ts.ToString("m':'ss");
            if (ts.Minutes == 0 && ts.Seconds == 0)
            {
                timer1.Stop();
                MessageBox.Show("Game Over");
                lockButtons();
            }
        }

        private void button_start_new_game_Click(object sender, EventArgs e)
        {
            endTime = DateTime.Now.AddSeconds(secondsPerGame);
            unlockButtons();
            timer1.Start();
            resetData();
            drawExpression();
        }

        private void button_confirm_guess_Click(object sender, EventArgs e)
        {
            CurrentGuess = textbox_guess.Text;
            if (CurrentGuess == exps[currentExpressionNumber].result)
            {
                correctGuesses++;
                label_correct_guesses.Text = correctGuesses.ToString();
            }
            else
            {
                incorrectGuesses++;
                label_incorrect_guesses.Text = incorrectGuesses.ToString();
            }
            CurrentGuess = "";
            drawExpression();
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            CurrentGuess += "1";
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            CurrentGuess += "2";
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            CurrentGuess += "3";
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            CurrentGuess += "4";
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            CurrentGuess += "5";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_6_Click(object sender, EventArgs e)
        {
            CurrentGuess += "6";
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            CurrentGuess += "7";
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            CurrentGuess += "8";
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            CurrentGuess += "9";
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            CurrentGuess += "0";
        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            CurrentGuess += ".";
        }

        private void button_backspace_Click(object sender, EventArgs e)
        {
            if (CurrentGuess.Length != 0)
            {
                CurrentGuess = CurrentGuess.Remove(CurrentGuess.Length - 1);
            }
        }
    }
}
