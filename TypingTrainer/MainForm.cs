namespace TypingTrainer
{
    public partial class MainForm : Form
    {
        enum Levels { RussianTextOnly = 0, RussianPunctuation, RussianMix, EnglishTextOnly }
        private int _selectedIndex;

        List<string> sampleTexts = new List<string>()
        {
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper, leo non sollicitudin gravida, elit neque mattis neque, et tempus neque urna at nulla.",
            "Fusce pulvinar metus dolor, et posuere sem lobortis lobortis. Fusce dapibus nunc vel lorem sagittis luctus. Duis interdum justo non massa suscipit, ut condimentum turpis dapibus.",
            "Vivamus eget sollicitudin mauris. Sed egestas, enim vel porta hendrerit, orci ante laoreet dui, eget commodo ex sem congue ligula.",
            "Nunc eu justo nec erat rhoncus congue. Duis consectetur pellentesque tortor ut fermentum. Vestibulum hendrerit eget nunc eu placerat."
        }; // В будущем заменить на автогенерируемый текст Цепями Маркова

        public MainForm()
        {
            InitializeComponent();
            LoadItemsToComboBox();
        }

        private void LoadItemsToComboBox()
        {
            comboBoxTextSelection.Items.Add("Русский (только текст)");
            comboBoxTextSelection.Items.Add("Русский (пунктуация)");
            comboBoxTextSelection.Items.Add("Русский + Английский (микс)");
            comboBoxTextSelection.Items.Add("Английский (только текст)");
            comboBoxTextSelection.SelectedIndex = 0;
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            _selectedIndex = comboBoxTextSelection.SelectedIndex;
            string sampleText = sampleTexts[_selectedIndex];
            //GameForm gameForm = new GameForm(sampleText);

            //this.Hide();
            //gameForm.ShowDialog();
            //this.Show();
        }
    }
}
