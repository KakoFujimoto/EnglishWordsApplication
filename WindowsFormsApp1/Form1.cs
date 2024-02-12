using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //問題と解答
        string[] quetions = { "りんご", "オレンジ", "レモン", "いちご", "きゅうり" };
        string[] auswers = { "apple", "orange", "lemon", "strawberry", "cucumber" };

        private int questionNumber = 1;
        public Form1()
        {
            InitializeComponent();
        }


        private void NextButton_Click(object sender, EventArgs e)
        {
            if (questionNumber <= 4)
            {
                questionNumber++;

                cntNum.Text = "第" + questionNumber + "問";
            }
        }
        private void PreButton_Click(object sender, EventArgs e)
        {
            if (questionNumber >= 2)
            {
                questionNumber--;
                cntNum.Text = "第" + questionNumber + "問";
            }
        }

    }
}
