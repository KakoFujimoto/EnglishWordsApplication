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
        private void chkBtn_Click(object sender, EventArgs e)
        {
            string userAnswer = Answer.Text.ToLower(); // ユーザーの回答を取得し、小文字に変換
            string correctAnswer = answers[questionNumber].ToLower(); // 正解を取得し、小文字に変換

            if (userAnswer == correctAnswer)
            {
                MessageBox.Show("正解です！", "結果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("不正解です！", "結果", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Answer.Clear(); // 回答フィールドをクリア
            Answer.Focus(); // 回答フィールドにフォーカスを戻す
        }
    }

}
