namespace CatchButton
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            runButton = new Button();
            scoreBox = new TextBox();
            lifeBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // runButton
            // 
            runButton.BackColor = SystemColors.ActiveCaption;
            runButton.Font = new Font("맑은 고딕", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            runButton.ForeColor = SystemColors.Desktop;
            runButton.Location = new Point(270, 154);
            runButton.Name = "runButton";
            runButton.Size = new Size(271, 121);
            runButton.TabIndex = 0;
            runButton.Text = "나를 잡아봐";
            runButton.UseVisualStyleBackColor = false;
            runButton.MouseClick += runButton_MouseClick;
            runButton.MouseEnter += Form1_MouseEnter;
            // 
            // scoreBox
            // 
            scoreBox.Location = new Point(699, -1);
            scoreBox.Name = "scoreBox";
            scoreBox.Size = new Size(100, 23);
            scoreBox.TabIndex = 1;
            scoreBox.Text = "현재 점수 : 0";
            // 
            // lifeBox
            // 
            lifeBox.Location = new Point(0, -1);
            lifeBox.Name = "lifeBox";
            lifeBox.Size = new Size(100, 23);
            lifeBox.TabIndex = 2;
            lifeBox.Text = "남은 생명 : 20";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.Location = new Point(0, 420);
            button1.Name = "button1";
            button1.Size = new Size(82, 30);
            button1.TabIndex = 3;
            button1.Text = "다시 시작";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(lifeBox);
            Controls.Add(scoreBox);
            Controls.Add(runButton);
            Name = "Form1";
            Text = "Form1";
            MouseClick += Form1_MouseClick;
            MouseEnter += Form1_MouseEnter;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button runButton;
        private TextBox scoreBox;
        private TextBox lifeBox;
        private Button button1;
    }
}
