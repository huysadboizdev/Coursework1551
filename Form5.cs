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
    public partial class Form5 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;


        public Form5()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 5;
        }

        private void checkAnswer(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {
                // work out the percentage
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show
                    (
                    "Quiz Ended!" + Environment.NewLine +
                    "You have answered " + score + "question correctly " + Environment.NewLine +
                    "Your total percentage is " + percentage + " %" + Environment.NewLine +
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
                    question.Text = "The Amazon River is the longest river in the world";
                    button1.Text = "True";
                    button2.Text = "False";
                    correctAnswer = 2;
                    break;

                case 2:
                    question.Text = "The human body has 206 bones.";
                    button1.Text = "False";
                    button2.Text = "True";
                    correctAnswer = 1;
                    break;

                case 3:
                    question.Text = "Lightning never strikes the same place twice.";
                    button1.Text = "True";
                    button2.Text = "False";
                    correctAnswer = 2;
                    break;

                case 4:
                    question.Text = "The capital of Australia is Sydney.";
                    button1.Text = "False";
                    button2.Text = "True";
                    correctAnswer = 1;
                    break;

                case 5:
                    question.Text = "The sun is a star.";
                    button1.Text = "True";
                    button2.Text = "False";
                    correctAnswer = 1;
                    break;
            }
        }
    }
}
