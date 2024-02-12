using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // 問題と解答
        string[] questions = { "りんご", "オレンジ", "レモン", "いちご", "きゅうり" };
        string[] answers = { "apple", "orange", "lemon", "strawberry", "cucumber" };

        private int questionNumber = 0;

        public Form1()
        {
            InitializeComponent();
            DisplayQuestion();
        }

        private void DisplayQuestion()
        {
            if (questionNumber >= 0 && questionNumber < questions.Length)
            {
                Question.Text = questions[questionNumber];
                cntNum.Text = "第" + (questionNumber + 1) + "問";
            }
            else
            {
                // インデックスが範囲外の場合、エラーを表示
                Question.Text = "問題が見つかりません";
                cntNum.Text = "";
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (questionNumber < questions.Length - 1)
            {
                questionNumber++;
                DisplayQuestion();
            }
        }

        private void PreButton_Click(object sender, EventArgs e)
        {
            if (questionNumber > 0)
            {
                questionNumber--;
                DisplayQuestion();
            }
        }
    }
}
