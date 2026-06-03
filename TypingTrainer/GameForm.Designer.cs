namespace TypingTrainer
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            label1 = new Label();
            label2 = new Label();
            buttonRestart = new Button();
            richTextBoxSampleText = new RichTextBox();
            groupBox1 = new GroupBox();
            labelRemainChars = new Label();
            labelTimeCount = new Label();
            labelInputChars = new Label();
            labelMistakes = new Label();
            labelSpeed = new Label();
            buttonExit = new Button();
            richTextBoxUserInput = new RichTextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(427, 37);
            label1.Name = "label1";
            label1.Size = new Size(323, 48);
            label1.TabIndex = 0;
            label1.Text = "Тренажёр печати";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(51, 127);
            label2.Name = "label2";
            label2.Size = new Size(356, 25);
            label2.TabIndex = 1;
            label2.Text = "Начните вводить следующий текст в поле";
            // 
            // buttonRestart
            // 
            buttonRestart.BackColor = Color.FromArgb(30, 30, 30);
            buttonRestart.FlatStyle = FlatStyle.Flat;
            buttonRestart.Font = new Font("Segoe UI", 11F);
            buttonRestart.ForeColor = SystemColors.ButtonFace;
            buttonRestart.Location = new Point(819, 530);
            buttonRestart.Name = "buttonRestart";
            buttonRestart.Size = new Size(341, 103);
            buttonRestart.TabIndex = 3;
            buttonRestart.Text = "Заново";
            buttonRestart.UseVisualStyleBackColor = false;
            buttonRestart.Click += ButtonRestart_Click;
            // 
            // richTextBoxSampleText
            // 
            richTextBoxSampleText.BackColor = Color.FromArgb(45, 45, 45);
            richTextBoxSampleText.BorderStyle = BorderStyle.None;
            richTextBoxSampleText.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBoxSampleText.ForeColor = SystemColors.ScrollBar;
            richTextBoxSampleText.Location = new Point(51, 168);
            richTextBoxSampleText.Margin = new Padding(4, 5, 4, 5);
            richTextBoxSampleText.Name = "richTextBoxSampleText";
            richTextBoxSampleText.ReadOnly = true;
            richTextBoxSampleText.Size = new Size(1107, 227);
            richTextBoxSampleText.TabIndex = 99;
            richTextBoxSampleText.Text = resources.GetString("richTextBoxSampleText.Text");
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelRemainChars);
            groupBox1.Controls.Add(labelTimeCount);
            groupBox1.Controls.Add(labelInputChars);
            groupBox1.Controls.Add(labelMistakes);
            groupBox1.Controls.Add(labelSpeed);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(51, 512);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(731, 232);
            groupBox1.TabIndex = 101;
            groupBox1.TabStop = false;
            groupBox1.Text = "Статистика";
            // 
            // labelRemainChars
            // 
            labelRemainChars.AutoSize = true;
            labelRemainChars.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelRemainChars.ForeColor = Color.WhiteSmoke;
            labelRemainChars.Location = new Point(374, 52);
            labelRemainChars.Margin = new Padding(4, 0, 4, 0);
            labelRemainChars.Name = "labelRemainChars";
            labelRemainChars.Size = new Size(164, 32);
            labelRemainChars.TabIndex = 107;
            labelRemainChars.Text = "Осталось: 99";
            // 
            // labelTimeCount
            // 
            labelTimeCount.AutoSize = true;
            labelTimeCount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTimeCount.ForeColor = Color.White;
            labelTimeCount.Location = new Point(41, 107);
            labelTimeCount.Margin = new Padding(4, 0, 4, 0);
            labelTimeCount.Name = "labelTimeCount";
            labelTimeCount.Size = new Size(256, 32);
            labelTimeCount.TabIndex = 106;
            labelTimeCount.Text = "Длительность: 00:00";
            // 
            // labelInputChars
            // 
            labelInputChars.AutoSize = true;
            labelInputChars.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelInputChars.ForeColor = Color.WhiteSmoke;
            labelInputChars.Location = new Point(41, 52);
            labelInputChars.Margin = new Padding(4, 0, 4, 0);
            labelInputChars.Name = "labelInputChars";
            labelInputChars.Size = new Size(269, 32);
            labelInputChars.TabIndex = 105;
            labelInputChars.Text = "Символов введено: 0";
            // 
            // labelMistakes
            // 
            labelMistakes.AutoSize = true;
            labelMistakes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelMistakes.ForeColor = Color.Red;
            labelMistakes.Location = new Point(41, 163);
            labelMistakes.Margin = new Padding(4, 0, 4, 0);
            labelMistakes.Name = "labelMistakes";
            labelMistakes.Size = new Size(140, 32);
            labelMistakes.TabIndex = 104;
            labelMistakes.Text = "Ошибок: 0";
            // 
            // labelSpeed
            // 
            labelSpeed.AutoSize = true;
            labelSpeed.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelSpeed.ForeColor = Color.FromArgb(46, 204, 113);
            labelSpeed.Location = new Point(374, 107);
            labelSpeed.Margin = new Padding(4, 0, 4, 0);
            labelSpeed.Name = "labelSpeed";
            labelSpeed.Size = new Size(278, 32);
            labelSpeed.TabIndex = 103;
            labelSpeed.Text = "Скорость: 0 симв/мин";
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.FromArgb(30, 30, 30);
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Segoe UI", 11F);
            buttonExit.ForeColor = SystemColors.ButtonFace;
            buttonExit.Location = new Point(819, 663);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(341, 78);
            buttonExit.TabIndex = 102;
            buttonExit.Text = "Стоп";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += ButtonExit_Click;
            // 
            // richTextBoxUserInput
            // 
            richTextBoxUserInput.BackColor = Color.FromArgb(45, 45, 48);
            richTextBoxUserInput.BorderStyle = BorderStyle.FixedSingle;
            richTextBoxUserInput.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBoxUserInput.ForeColor = Color.White;
            richTextBoxUserInput.Location = new Point(51, 433);
            richTextBoxUserInput.Margin = new Padding(4, 5, 4, 5);
            richTextBoxUserInput.Name = "richTextBoxUserInput";
            richTextBoxUserInput.ScrollBars = RichTextBoxScrollBars.None;
            richTextBoxUserInput.ShortcutsEnabled = false;
            richTextBoxUserInput.Size = new Size(1108, 40);
            richTextBoxUserInput.TabIndex = 100;
            richTextBoxUserInput.Text = "";
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1219, 798);
            Controls.Add(richTextBoxUserInput);
            Controls.Add(buttonExit);
            Controls.Add(groupBox1);
            Controls.Add(richTextBoxSampleText);
            Controls.Add(buttonRestart);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ButtonFace;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "GameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Тренажёр печати - Меню";
            Shown += GameForm_Shown;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button buttonRestart;
        private RichTextBox richTextBoxSampleText;
        private GroupBox groupBox1;
        private Button buttonExit;
        private Label labelMistakes;
        private Label labelSpeed;
        private Label labelInputChars;
        private Label labelTimeCount;
        private Label labelRemainChars;
        private RichTextBox richTextBoxUserInput;
    }
}