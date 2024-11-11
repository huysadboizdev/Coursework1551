using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework1551
{
    public partial class Form3 : Form
    {
        // quiz game variables
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        public Form3()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 5;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkAnswer(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++; 
            }

            if(questionNumber == totalQuestions)
            {
                // work out the percentage
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show
                    (
                    "Quiz Ended!" +  Environment.NewLine+
                    "You have answered " + score + "question correctly " + Environment.NewLine +
                    "Your total percentage is " + percentage + " %" +  Environment.NewLine +
                    "Click OK to pkay again"
                    );
                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);        
            }



            questionNumber++;
            askQuestion(questionNumber);


        }
        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.question;
                    question.Text = "What is this animal?";
                    button1.Text = "Cat";
                    button2.Text = "Dog";
                    button3.Text = "Cow";
                    button4.Text = "Snake";

                    correctAnswer = 1;
                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.pink;
                    question.Text = "What color is this?";
                    button1.Text = "Blue";
                    button2.Text = "Red";
                    button3.Text = "Pink";
                    button4.Text = "Black";

                    correctAnswer = 3;
                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.apple;
                    question.Text = "What fruit is this?";
                    button1.Text = "Orange";
                    button2.Text = "Banana";
                    button3.Text = "Ball";
                    button4.Text = "Apple";

                    correctAnswer = 4;
                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.pizza;
                    question.Text = "What is the name of this dish?";
                    button1.Text = "Hamburger";
                    button2.Text = "Steak";
                    button3.Text = "Hotpot";
                    button4.Text = "Pizza";

                    correctAnswer = 4;
                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.police;
                    question.Text = "How many people are in the picture?";
                    button1.Text = "1";
                    button2.Text = "2";
                    button3.Text = "4";
                    button4.Text = "3";

                    correctAnswer = 2;
                    break;
            }
        }
    }
}
