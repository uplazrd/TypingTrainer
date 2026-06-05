using System.Runtime.InteropServices;
using Timer = System.Windows.Forms.Timer;


namespace TypingTrainer
{
    public partial class GameForm : Form
    {
        private int _secondsCounter = 0;
        private Timer _timer = new();

        private string _targetText = "";
        private int _mistakesCount = 0;

        // убирает синее мерцание текста
        private const int WM_SETREDRAW = 0x000B;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);


        public GameForm(string targetText)
        {
            InitializeComponent();
            InitializeTimer();
            UpdateStats();

            _targetText = targetText;
            richTextBoxTargetText.Text = _targetText;

            richTextBoxUserInput.TextChanged += RichTextBoxUserInput_TextChanged;
        }

        private void RichTextBoxUserInput_TextChanged(object? sender, EventArgs e)
        {
            SendMessage(richTextBoxUserInput.Handle, WM_SETREDRAW, IntPtr.Zero, IntPtr.Zero);

            string userText = richTextBoxUserInput.Text;
            _mistakesCount = 0;
            int selectionStart = richTextBoxUserInput.SelectionStart;
            //int selectionLength = richTextBoxUserInput.SelectionLength;

            for (int i = 0; i < userText.Length; i++)
            {
                richTextBoxUserInput.Select(i, 1);

                if (i >= _targetText.Length || userText[i] != _targetText[i])
                {
                    _mistakesCount++;
                    richTextBoxUserInput.SelectionColor = Color.Red;
                }
                else
                {
                    richTextBoxUserInput.SelectionColor = Color.White; 
                }
            }

            richTextBoxUserInput.SelectionStart = selectionStart;
            richTextBoxUserInput.SelectionLength = 0;
            richTextBoxUserInput.SelectionColor = Color.White;

            SendMessage(richTextBoxUserInput.Handle, WM_SETREDRAW, new IntPtr(1), IntPtr.Zero);
            richTextBoxUserInput.Refresh();

            UpdateStats();

            if (userText.Length >= _targetText.Length)
                FinishGame();
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
            int inputLength = richTextBoxUserInput.Text.Length;
            int remainChars = _targetText.Length - inputLength;
            if (remainChars < 0) remainChars = 0;

            int correctChars = inputLength - _mistakesCount;
            if (correctChars < 0) correctChars = 0;

            int speed = _secondsCounter > 0
                ? (int)((correctChars / (double)_secondsCounter) * 60)
                : 0;


            labelInputChars.Text  = $"Введено символов: {inputLength}";
            labelRemainChars.Text = $"Осталось символов: {remainChars}";
            labelMistakes.Text    = $"Ошибок: {_mistakesCount}";
            labelSpeed.Text       = $"Скорость: {speed} зн./мин";
            labelTimeCount.Text   = $"Прошло {_secondsCounter} сек.";
        }

        private void GameForm_Shown(object sender, EventArgs e) => richTextBoxUserInput.Focus();
        private void ButtonExit_Click(object sender, EventArgs e) => this.Close();
        private void ButtonRestart_Click(object sender, EventArgs e) => RestartGame();

        private void RestartGame()
        {
            _timer.Stop();
            _secondsCounter = 0;
            _mistakesCount = 0;
            richTextBoxUserInput.Clear();
            UpdateStats();
            _timer.Start();
            richTextBoxUserInput.Focus();
        }

        private void FinishGame()
        {
            _timer.Stop();

            double mistakePercentage = _targetText.Length > 0
                ? ((double)_mistakesCount / _targetText.Length) * 100
                : 0;

            string verdict = mistakePercentage switch
            {
                0 => "Прекрасно! Ни одной ошибки!",
                <= 5 => "Хорошо! Достойно.",
                <= 20 => "Бро, тебе нужно тренироваться!",
                _ => "Даже моя бабка лучше печатает"
            };

            string summary = $"{verdict}\n\n" +
                             $"Ошибок на финише: {_mistakesCount} из {_targetText.Length}\n" +
                             $"Процент ошибок: {mistakePercentage:F1}%\n" +
                             $"Прошло времени: {_secondsCounter} сек.\n" +
                             $"{labelSpeed.Text}";

            var btn = MessageBox.Show(summary, "Финиш", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (btn == DialogResult.OK)
                RestartGame();
        }
    }
}
