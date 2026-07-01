namespace TypingTrainer
{
    public partial class MainForm : Form
    {
        enum Levels { RussianTextOnly = 0, RussianPunctuation, English }
        public MainForm()
        {
            InitializeComponent();
            LoadItemsToComboBox();
            SetupNumericUpDown();
        }

        /// <summary> Заполняет выпадающий список доступными языковыми режимами </summary>
        private void LoadItemsToComboBox()
        {
            comboBoxTextSelection.Items.Add("Русский (только текст)");
            comboBoxTextSelection.Items.Add("Русский (пунктуация)");
            comboBoxTextSelection.Items.Add("Английский");
            comboBoxTextSelection.SelectedIndex = 0;
        }

        /// <summary> Настраивает минимальные, максимальные и начальные значения для выбора длины текста </summary>
        private void SetupNumericUpDown()
        {
            numericUpDownLength.Minimum   = 5;
            numericUpDownLength.Maximum   = 50;
            numericUpDownLength.Value     = 20;
            numericUpDownLength.Increment = 5;
        }

        /// <summary> Обрабатывает нажатие кнопки старта: генерирует текст и запускает игровую форму </summary>
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            int  _targetLength = (int)numericUpDownLength.Value;
            int _selectedIndex = comboBoxTextSelection.SelectedIndex;
            string targetText = TextGenerator.Generate(_selectedIndex, _targetLength);
            GameForm gameForm = new GameForm(targetText);

            this.Hide();
            gameForm.ShowDialog();
            this.Show();
        }
    }
}
