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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(runButton);
            Name = "Form1";
            Text = "Form1";
            MouseEnter += Form1_MouseEnter;
            ResumeLayout(false);
        }

        #endregion

        private Button runButton;
    }
}
