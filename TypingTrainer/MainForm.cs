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

        private void LoadItemsToComboBox()
        {
            comboBoxTextSelection.Items.Add("Русский (только текст)");
            comboBoxTextSelection.Items.Add("Русский (пунктуация)");
            comboBoxTextSelection.Items.Add("Английский");
            comboBoxTextSelection.SelectedIndex = 0;
        }
        private void SetupNumericUpDown()
        {
            numericUpDownLength.Minimum   = 5;
            numericUpDownLength.Maximum   = 50;
            numericUpDownLength.Value     = 20;
            numericUpDownLength.Increment = 5;
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            int  _targetLength = (int)numericUpDownLength.Value;
            int _selectedIndex = comboBoxTextSelection.SelectedIndex;

            //string targetText = TextGenerator.Generate(_selectedIndex, _targetLength);
            string targetText = "Это пример текста, который нужно ввести";
            GameForm gameForm = new GameForm(targetText);

            this.Hide();
            gameForm.ShowDialog();
            this.Show();
        }
    }
}
