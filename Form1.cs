using System.Media;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;

namespace CatchButton
{
    public partial class Form1 : Form
    {
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {

            // 난수 생성기 준비
            Random rd = new Random();

            // 난수 최대치 지정
            int maxX = this.ClientSize.Width - runButton.Size.Width; // 여백의 크기 - 버튼의 크기
            int maxY = this.ClientSize.Height - runButton.Size.Height;

            // 난수 생성
            int x = rd.Next(0, maxX);
            int y = rd.Next(0, maxY);

            // 버튼 위치 변경
            runButton.Location = new Point(x, y);

            // 폼 제목에 버튼 위치 표시
            this.Text = $"현재 버튼위치: ({x}, {y})";
            scoreBox.Text = $"현재 점수: {score}";
        }

        private void runButton_MouseClick(object sender, MouseEventArgs e)
        {
            SystemSounds.Beep.Play();
            MessageBox.Show("버튼을 잡았다!");
            score += 100;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            SystemSounds.Beep.Play();
            scoreBox.Text = $"현재 점수: {score}";
            score -= 10;
        }
    }
}
