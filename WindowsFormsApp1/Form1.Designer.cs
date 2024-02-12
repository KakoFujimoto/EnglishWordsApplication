namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.cntNum = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.preButton = new System.Windows.Forms.Button();
            this.Question = new System.Windows.Forms.Label();
            this.Answer = new System.Windows.Forms.TextBox();
            this.Answer_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cntNum
            // 
            this.cntNum.AutoSize = true;
            this.cntNum.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cntNum.Location = new System.Drawing.Point(29, 28);
            this.cntNum.Name = "cntNum";
            this.cntNum.Size = new System.Drawing.Size(68, 22);
            this.cntNum.TabIndex = 0;
            this.cntNum.Text = "第1問";
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nextButton.Location = new System.Drawing.Point(222, 164);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(124, 42);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "次の問題";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // preButton
            // 
            this.preButton.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.preButton.Location = new System.Drawing.Point(46, 164);
            this.preButton.Name = "preButton";
            this.preButton.Size = new System.Drawing.Size(124, 42);
            this.preButton.TabIndex = 2;
            this.preButton.Text = "前の問題";
            this.preButton.UseVisualStyleBackColor = true;
            this.preButton.Click += new System.EventHandler(this.PreButton_Click);
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Question.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Question.Location = new System.Drawing.Point(42, 92);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(55, 19);
            this.Question.TabIndex = 4;
            this.Question.Text = "りんご";
            // 
            // Answer
            // 
            this.Answer.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Answer.Location = new System.Drawing.Point(191, 85);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(177, 26);
            this.Answer.TabIndex = 5;
            // 
            // Answer_label
            // 
            this.Answer_label.AutoSize = true;
            this.Answer_label.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Answer_label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Answer_label.Location = new System.Drawing.Point(149, 95);
            this.Answer_label.Name = "Answer_label";
            this.Answer_label.Size = new System.Drawing.Size(36, 16);
            this.Answer_label.TabIndex = 6;
            this.Answer_label.Text = "答え";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Answer_label);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.preButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.cntNum);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cntNum;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button preButton;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.TextBox Answer;
        private System.Windows.Forms.Label Answer_label;
    }
}

