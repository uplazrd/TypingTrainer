using Timer = System.Windows.Forms.Timer;

namespace TypingTrainer
{
    public partial class GameForm : Form
    {
        private static int _secondsCounter = 0;
        private Timer _timer = new Timer();

        public GameForm(string sampleText)
        {
            InitializeComponent();
            InitializeTimer();
            richTextBoxSampleText.Text = sampleText;
        }

        private void InitializeTimer()
        {
            _timer.Interval = 1000;
            _timer.Tick += SecondsTimer_Tick;
            _timer.Start();
        }

        private void SecondsTimer_Tick(object? sender, EventArgs e)
        {
            _secondsCounter++;
            UpdateStats();
        }


        private void UpdateStats()
        {
            //labelInputChars.Text = ;   // Введённые символы
            //labelRemainChars.Text = ;  // Осталось символов
            //labelMistakes.Text = ;     // количество ошибок
            //labelSpeed.Text = ;        // Скорость символы (правильные) в минуту
            labelTimeCount.Text = $"Прошло {_secondsCounter} сек.";
        }

        private void GameForm_Load(object sender, EventArgs e) => textBoxUserInput.Focus();
        private void ButtonExit_Click(object sender, EventArgs e) => this.Close();
        private void ButtonRestart_Click(object sender, EventArgs e) => this.Close(); //

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _timer.Stop();
            _secondsCounter = 0;
            _timer.Dispose();
            base.OnFormClosing(e);
        }
    }
}
