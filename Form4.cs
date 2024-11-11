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
    public partial class Form4 : Form
    {
        private List<string> questions = new List<string>
        {
            "What is the capital city of France?",
            "Which planet is known as the \"Red Planet\"?",
            "Who wrote the play \"Romeo and Juliet\"?",
            "What is the largest ocean on Earth?",
            "Which element has the chemical symbol \"O\"?"
        };

        private List<string> answers = new List<string>
        {
            "Paris",
            "Mars",
            "William Shakespeare",
            "Pacific Ocean",
            "Oxygen"
        };

        private int now_question = 0;
        private int grade = 0;

        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Reset the quiz
            grade = 0;
            now_question = 0;
            rt_answer.Clear(); // Clear answer box
            rt_question.Text = questions[now_question]; // Show the first question
            now_question++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (now_question < questions.Count)
            {
                if (rt_answer.Text == answers[now_question - 1])
                {
                    grade++;
                }
                rt_answer.Clear();
                rt_question.Text = questions[now_question];
                now_question++;
            }
            else
            {
                string yourGrade = "Grade: " + grade.ToString();
                MessageBox.Show(yourGrade);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (now_question < questions.Count)
            {
                string Grade = "Grade: " + grade.ToString();
                MessageBox.Show(Grade + ". You answered " + now_question + " question(s). Please play again to improve your score.");
            }
            else
            {
                MessageBox.Show("You have completed all questions. Final Grade: " + grade.ToString());
            }
        }
    }
}

      

