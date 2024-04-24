using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad1
{
    struct Question                  
    {
        public string QuestionText;
        public string AnswerA;
        public string AnswerB;
        public string AnswerC;
        public string AnswerD;
        public int CorrectAnswer;
    }


    public partial class Form1 : Form
    {
        private Question[] array_of_question = new Question[10];
        private int currentQuestionIndex = 0;
        private int correctAnswers = 0;
        public Form1()
        {
            array_of_question[0] = new Question {
                QuestionText = "What color is snow?",
                AnswerA = "Red",
                AnswerB = "Yellow",
                AnswerC = "White",
                AnswerD = "Green",
                CorrectAnswer = 2
            };
            array_of_question[1] = new Question
            {
                QuestionText = "What is the capital of Bulgaria?",
                AnswerA = "Sofia",
                AnswerB = "Paris",
                AnswerC = "London",
                AnswerD = "Varna",
                CorrectAnswer = 0
            };

            InitializeComponent();
        }
        private void DisplayQuestion()
        {
            if (currentQuestionIndex < array_of_question.Length)
            {
                groupBox1.Text = $"Въпрос {currentQuestionIndex + 1}";
                label1.Text = array_of_question[currentQuestionIndex].QuestionText;

                radioButton1.Text = array_of_question[currentQuestionIndex].AnswerA;
                radioButton2.Text = array_of_question[currentQuestionIndex].AnswerB;
                radioButton3.Text = array_of_question[currentQuestionIndex].AnswerC;
                radioButton4.Text = array_of_question[currentQuestionIndex].AnswerD;

                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
            }
            else
            {
                MessageBox.Show($"Тестът приключи! Вашият брой правилни отговори: {correctAnswers}", "Край на теста");
                
            }
        }

        private void CheckAnswer()
        {
            if (currentQuestionIndex < array_of_question.Length)
            {
                int userAnswerIndex = GetUserAnswer();
                int correctAnswerIndex = array_of_question[currentQuestionIndex].CorrectAnswer;
                string correctAnswerText = GetCorrectAnswerText(array_of_question[currentQuestionIndex]);

                if (userAnswerIndex == correctAnswerIndex)
                {
                    correctAnswers += 2; 
                    textBox1.Text = correctAnswers.ToString();
                    MessageBox.Show("Правилен отговор!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Грешен отговор! Правилният отговор е: {correctAnswerText}", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private string GetCorrectAnswerText(Question question)
        {
            switch (question.CorrectAnswer)
            {
                case 0:
                    return question.AnswerA;
                case 1:
                    return question.AnswerB;
                case 2:
                    return question.AnswerC;
                case 3:
                    return question.AnswerD;
                default:
                    return "Невалиден отговор";
            }
        }
        private int GetUserAnswer()
        {
            if (radioButton1.Checked) return 0;
            if (radioButton2.Checked) return 1;
            if (radioButton3.Checked) return 2;
            if (radioButton4.Checked) return 3;

            return -1; 
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckAnswer();
            currentQuestionIndex++;
            DisplayQuestion();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayQuestion();
        }
    }
}
