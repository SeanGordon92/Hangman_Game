using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;
using System.Media;

namespace Hangman_Game
{
    public delegate void CheckLetter(string letter);
    public partial class Hangman : Form
    {

        private int counter = 30;//Base number for timer

        const int BaseLife = 6;//Base number for tries
        event CheckLetter Check;//Checks if the chosen letter is in the word
        string input;//This is used when we choose a letter
        string missedLetters = "";

        //A word which is to find
        string wordToFind = "";

        Random Picker = new Random();

        //Current status of the found letters in the word
        string wordToDisplay = "";

        //Character array of word
        char[] wordToFindArray;
        int[] wordToFindLettersPosition;
        bool WasLetterFound = false;

        int missedLetterCount = 0;

        int Wins, Lose, Streak, StreakMax;//win lose counters
        public Hangman()
        {
            InitializeComponent();
            //Subscribe the event
            this.Check += new CheckLetter(Checker);

            //Create a word list
            WordBank();

            //Start a new game
            Reset();


        }
        private string WordBank()
        {
            string UnsortedWords = "API,Command,Null,Bug,Class,Code,Laptop,Browser,Computer,Program,Algorithm,Array,Assembly,Block,Compilation,Debug,Event,Function,Method,GitHub,HTML,Invalid,Instance,Java,Loop,Language,Operator,Overflow,Parse,Python,Socket,Machine,Source,Value,Void";
            List<string> SortedWords = UnsortedWords.Split(',').ToList();

            int index = Picker.Next(SortedWords.Count);
            index = index % SortedWords.Count;

            string HiddenWord = SortedWords[index];
            return HiddenWord;
        }

        private void Reset()//After we start or restart the game it will reset everything
        {
            lbl_StreakCount.Text = Streak.ToString();
            lbl_StreakMaxCount.Text = StreakMax.ToString();
            //start and enable a new timer 
            lbl_Timer.Text = "00:40";
            counter = 40;
            timer3 = new System.Windows.Forms.Timer();
            timer3.Interval = 1000;
            timer3.Tick += new EventHandler(aTimer);
            timer3.Enabled = true;
            lbl_Message.Text = "Good Luck!";
            Key_Enabler();//Enable all disabled keys
            lbl_Timer.Text = counter.ToString();//shows 30 seconds on the clock
            //hides the body from view
            pic_Head.Visible = false;
            pic_Body.Visible = false;
            pic_Right_Hand.Visible = false;
            pic_Left_Hand.Visible = false;
            pic_Right_Leg.Visible = false;
            pic_Left_Leg.Visible = false;

            try
            {
                wordToFind = WordBank();//Retrives a new words from the bank
                wordToFind = wordToFind.ToUpper();
                wordToFindArray = wordToFind.ToCharArray();
                wordToFindLettersPosition = new int[wordToFind.Length];

                //Resetting other counters and variables
                input = "";
                wordToDisplay = "";
                for (int i = 0; i < wordToFind.Length; i++)
                {
                    wordToDisplay += "-";
                }
                missedLetters = "";
                missedLetterCount = 0;

                lbl_Word.Text = wordToDisplay.ToUpper();
                lbl_WrongPicked.Text = missedLetters;
                lbl_LifeValue.Text = BaseLife.ToString();
                Application.DoEvents();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void Checker(string currentInputletter)//After we click on a letter, it will check each one to see if it available in the word
        {
            try
            {
                if (missedLetterCount < BaseLife)
                {
                    WasLetterFound = false;
                    for (int i = 0; i < wordToFindArray.Length; i++)//If we found the letter we continue and it shows the letter in the form
                    {
                        if (currentInputletter[0] == wordToFindArray[i])
                        {
                            lbl_Message.Text = "Awesome!👍";
                            wordToFindLettersPosition[i] = 1;
                            SoundPlayer spWin = new SoundPlayer(Properties.Resources.Guess_Correct);
                            spWin.Play();
                            WasLetterFound = true;
                        }
                    }

                    if (WasLetterFound == false)//If we were wrong it subtracts the total amount of tries by 1
                    {
                        missedLetters += currentInputletter + ", ";
                        missedLetterCount++;
                        lbl_LifeValue.Text = (BaseLife - missedLetterCount).ToString();
                        lbl_Message.Text = "Oops👎";
                        SoundPlayer spWrong = new SoundPlayer(Properties.Resources.Guess_Wrong);
                        spWrong.Play();
                        //Each time we make a mistake a new body part is shown
                        if (missedLetterCount == 1)
                        {
                            pic_Head.Visible = true;
                        }
                        if (missedLetterCount == 2)
                        {
                            pic_Body.Visible = true;
                        }
                        if (missedLetterCount == 3)
                        {
                            pic_Right_Hand.Visible = true;
                        }
                        if (missedLetterCount == 4)
                        {
                            pic_Left_Hand.Visible = true;
                        }
                        if (missedLetterCount == 5)
                        {
                            pic_Right_Leg.Visible = true;
                        }
                        if (missedLetterCount == 6)//If we made 6 mistakes it will shows the last part and give the failed message
                        {
                            Lose++;
                            Streak = 0;
                            pic_Left_Leg.Visible = true;
                            timer3.Stop();
                            timer3.Enabled = false;
                            lbl_Timer.Text = "00:00";
                            SoundPlayer spLose = new SoundPlayer(Properties.Resources.Lose);
                            spLose.Play();
                            string message = ($"Sorry, you lost the game. The correct word was: { wordToFind}\nWould you like to try again?");
                            string title = "☠️Oops";
                            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                            DialogResult result = MessageBox.Show(message, title, buttons);
                            if (result == DialogResult.OK)
                            {
                                this.Reset();
                            }
                            else
                            {
                                this.ShutDown();
                            }
                        }
                    }

                    wordToDisplay = "";//Displays - based on the number of characters in the hidden word
                    for (int i = 0; i < wordToFindArray.Length; i++)
                    {
                        if (wordToFindLettersPosition[i] == 1)
                        {
                            wordToDisplay += wordToFindArray[i].ToString();
                        }
                        else
                        {
                            wordToDisplay += "-";
                        }
                    }

                    lbl_Word.Text = wordToDisplay.ToUpper();
                    lbl_WrongPicked.Text = missedLetters;

                    if (wordToFindLettersPosition.All(e => e == 1))//If we guessed the word we get a winning message
                    {
                        Wins++;
                        Streak++;
                        if (Streak > StreakMax)
                        {
                            StreakMax = Streak;
                        }
                        timer3.Enabled = false;
                        lbl_Timer.Text = "00:00";
                        string message = ($"Congratulations you found the word, and with {lbl_LifeValue.Text} tries left!\nWould you like to play again?");
                        string title = "Great!";
                        SoundPlayer spWin = new SoundPlayer(Properties.Resources.Win);
                        spWin.Play();
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttons);
                        if (result == DialogResult.Yes)
                        {
                            this.Reset();
                        }
                        else
                        {
                            this.ShutDown();
                        }
                    }
                }
                Application.DoEvents();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        //All the keys on our keypad
        private void btn_A_Click(object sender, EventArgs e)
        {
            input = "A";
            btn_A.Enabled = false;
            Check(input);
        }
        private void btn_B_Click(object sender, EventArgs e)
        {
            input = "B";
            btn_B.Enabled = false;
            Check(input);
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            input = "C";
            btn_C.Enabled = false;
            Check(input);
        }
        private void btn_D_Click(object sender, EventArgs e)
        {
            input = "D";
            btn_D.Enabled = false;
            Check(input);
        }
        private void btn_E_Click(object sender, EventArgs e)
        {
            input = "E";
            btn_E.Enabled = false;

            Check(input);
        }
        private void btn_F_Click(object sender, EventArgs e)
        {
            input = "F";
            btn_F.Enabled = false;
            Check(input);
        }

        private void btn_G_Click(object sender, EventArgs e)
        {
            input = "G";
            btn_G.Enabled = false;
            Check(input);
        }

        private void btn_H_Click(object sender, EventArgs e)
        {
            input = "H";
            btn_H.Enabled = false;
            Check(input);
        }

        private void btn_I_Click(object sender, EventArgs e)
        {
            input = "I";
            btn_I.Enabled = false;
            Check(input);
        }

        private void btn_J_Click(object sender, EventArgs e)
        {
            input = "J";
            btn_J.Enabled = false;
            Check(input);
        }

        private void btn_K_Click(object sender, EventArgs e)
        {
            input = "K";
            btn_K.Enabled = false;
            Check(input);
        }

        private void btn_L_Click(object sender, EventArgs e)
        {
            input = "L";
            btn_L.Enabled = false;
            Check(input);
        }

        private void btn_M_Click(object sender, EventArgs e)
        {
            input = "M";
            btn_M.Enabled = false;
            Check(input);
        }

        private void btn_N_Click(object sender, EventArgs e)
        {
            input = "N";
            btn_N.Enabled = false;
            Check(input);
        }

        private void btn_O_Click(object sender, EventArgs e)
        {
            input = "O";
            btn_O.Enabled = false;
            Check(input);
        }

        private void btn_P_Click(object sender, EventArgs e)
        {
            input = "P";
            btn_P.Enabled = false;
            Check(input);
        }

        private void btn_Q_Click(object sender, EventArgs e)
        {
            input = "Q";
            btn_Q.Enabled = false;
            Check(input);
        }

        private void btn_R_Click(object sender, EventArgs e)
        {
            input = "R";
            btn_R.Enabled = false;
            Check(input);
        }
        private void btn_S_Click(object sender, EventArgs e)
        {
            input = "S";
            btn_S.Enabled = false;
            Check(input);
        }

        private void btn_T_Click(object sender, EventArgs e)
        {
            input = "T";
            btn_T.Enabled = false;
            Check(input);
        }

        private void btn_U_Click(object sender, EventArgs e)
        {
            input = "U";
            btn_U.Enabled = false;
            Check(input);
        }

        private void btn_V_Click(object sender, EventArgs e)
        {
            input = "V";
            btn_Y.Enabled = false;
            Check(input);
        }

        private void btn_W_Click(object sender, EventArgs e)
        {
            input = "W";
            btn_W.Enabled = false;
            Check(input);
        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            input = "X";
            btn_X.Enabled = false;
            Check(input);
        }

        private void btn_Y_Click(object sender, EventArgs e)
        {
            input = "Y";
            btn_Y.Enabled = false;
            Check(input);
        }

        private void btn_Z_Click(object sender, EventArgs e)
        {
            input = "Z";
            btn_Z.Enabled = false;
            Check(input);
        }

        private void btnPlay_Click(object sender, EventArgs e)//When we press the pay key it will reset the timer and the game
        {
            timer3.Enabled = false;
            Reset();
        }
        private void aTimer(object sender, EventArgs e)//Timer
        {
            counter--;
            lbl_Timer.Text = counter / 60 + ":" + ((counter % 60) >= 10 ? (counter % 60).ToString() : "0" + (counter % 60));
            if (counter <= 0)//If timer reaches 0 we get the timeout message
            {
                Lose++;
                Streak = 0;
                timer3.Enabled = false;
                lbl_Timer.Text = "00:00";
                string message = "Sorry, you are out of time and lost the game. Would you like to try again?";
                string title = "Oops";
                SoundPlayer spLose = new SoundPlayer(Properties.Resources.Lose);
                spLose.Play();
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    this.Reset();
                }
                else
                {
                    this.ShutDown();
                }
            }
        }
        private void lbl_Char3_Click(object sender, EventArgs e)
        {

        }

        private void lblLivesLeft_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Char1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtLives_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCharChoose_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Hangman_Load(object sender, EventArgs e)
        {

        }

        private void lbl_Word_Click(object sender, EventArgs e)
        {

        }

        private void txt_Wrongs_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btn_Finish_Click(object sender, EventArgs e)
        {
            this.ShutDown();
        }

        private void btn_Info_Click(object sender, EventArgs e)
        {
            timer3.Stop();
            string message = "Your objective is to find the missing word. All words are related to the world of programming, so it should be challanging";
            string title = "Info/Pause";

            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            timer3.Start();
        }

        private void lbl_Timer_Click(object sender, EventArgs e)
        {
        
        }
        private void Key_Enabler()//When we start a new game we enable all the disabled keys 
        {
            btn_A.Enabled = true;
            btn_B.Enabled = true;
            btn_C.Enabled = true;
            btn_D.Enabled = true;
            btn_E.Enabled = true;
            btn_F.Enabled = true;
            btn_G.Enabled = true;
            btn_H.Enabled = true;
            btn_I.Enabled = true;
            btn_J.Enabled = true;
            btn_K.Enabled = true;
            btn_L.Enabled = true;
            btn_M.Enabled = true;
            btn_N.Enabled = true;
            btn_O.Enabled = true;
            btn_P.Enabled = true;
            btn_Q.Enabled = true;
            btn_R.Enabled = true;
            btn_S.Enabled = true;
            btn_T.Enabled = true;
            btn_U.Enabled = true;
            btn_V.Enabled = true;
            btn_W.Enabled = true;
            btn_X.Enabled = true;
            btn_Y.Enabled = true;
            btn_Z.Enabled = true;
        }
        void ShutDown()//Closing the program, giving a goodbye message with sound
        {
            string message = "You Thank you very much for playing!!🤩\nYour highest win streak is: ";
            string title = "Goodbye👋";
            string Score= "Better luck next time";//Depending on the highest  streak number, the playing will get a different response 
            if (StreakMax == 0)
                Score = "Better luck next time!";
            if (StreakMax == 1)
                Score = "Nice!";
            if (StreakMax == 2)
                Score = "Hey that's pretty good!";
            if (StreakMax == 3)
                Score = "WOW";
            if (StreakMax >= 4)
                Score = "Amazing you are really good at this!";
            SoundPlayer spBye = new SoundPlayer(Properties.Resources.End_Clear);
            spBye.Play();
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message + StreakMax + Environment.NewLine + Score, title, buttons);
            this.Close();
        }
    }
}