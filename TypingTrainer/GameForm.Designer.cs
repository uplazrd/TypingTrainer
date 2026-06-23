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
            richTextBoxTargetText = new RichTextBox();
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
            label1.Location = new Point(299, 22);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(218, 32);
            label1.TabIndex = 0;
            label1.Text = "Тренажёр печати";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(36, 76);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(239, 15);
            label2.TabIndex = 1;
            label2.Text = "Начните вводить следующий текст в поле";
            // 
            // buttonRestart
            // 
            buttonRestart.BackColor = Color.FromArgb(30, 30, 30);
            buttonRestart.FlatStyle = FlatStyle.Flat;
            buttonRestart.Font = new Font("Segoe UI", 11F);
            buttonRestart.ForeColor = SystemColors.ButtonFace;
            buttonRestart.Location = new Point(573, 318);
            buttonRestart.Margin = new Padding(2);
            buttonRestart.Name = "buttonRestart";
            buttonRestart.Size = new Size(239, 62);
            buttonRestart.TabIndex = 3;
            buttonRestart.Text = "Заново";
            buttonRestart.UseVisualStyleBackColor = false;
            buttonRestart.Click += ButtonRestart_Click;
            // 
            // richTextBoxTargetText
            // 
            richTextBoxTargetText.BackColor = Color.FromArgb(45, 45, 45);
            richTextBoxTargetText.BorderStyle = BorderStyle.None;
            richTextBoxTargetText.Font = new Font("Consolas", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBoxTargetText.ForeColor = SystemColors.ScrollBar;
            richTextBoxTargetText.Location = new Point(36, 101);
            richTextBoxTargetText.Name = "richTextBoxTargetText";
            richTextBoxTargetText.ReadOnly = true;
            richTextBoxTargetText.Size = new Size(775, 136);
            richTextBoxTargetText.TabIndex = 99;
            richTextBoxTargetText.Text = resources.GetString("richTextBoxTargetText.Text");
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
            groupBox1.Location = new Point(36, 307);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(512, 139);
            groupBox1.TabIndex = 101;
            groupBox1.TabStop = false;
            groupBox1.Text = "Статистика";
            // 
            // labelRemainChars
            // 
            labelRemainChars.AutoSize = true;
            labelRemainChars.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelRemainChars.ForeColor = Color.WhiteSmoke;
            labelRemainChars.Location = new Point(262, 31);
            labelRemainChars.Name = "labelRemainChars";
            labelRemainChars.Size = new Size(109, 21);
            labelRemainChars.TabIndex = 107;
            labelRemainChars.Text = "Осталось: 99";
            // 
            // labelTimeCount
            // 
            labelTimeCount.AutoSize = true;
            labelTimeCount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTimeCount.ForeColor = Color.White;
            labelTimeCount.Location = new Point(29, 64);
            labelTimeCount.Name = "labelTimeCount";
            labelTimeCount.Size = new Size(169, 21);
            labelTimeCount.TabIndex = 106;
            labelTimeCount.Text = "Длительность: 00:00";
            // 
            // labelInputChars
            // 
            labelInputChars.AutoSize = true;
            labelInputChars.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelInputChars.ForeColor = Color.WhiteSmoke;
            labelInputChars.Location = new Point(29, 31);
            labelInputChars.Name = "labelInputChars";
            labelInputChars.Size = new Size(177, 21);
            labelInputChars.TabIndex = 105;
            labelInputChars.Text = "Символов введено: 0";
            // 
            // labelMistakes
            // 
            labelMistakes.AutoSize = true;
            labelMistakes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelMistakes.ForeColor = Color.Red;
            labelMistakes.Location = new Point(29, 98);
            labelMistakes.Name = "labelMistakes";
            labelMistakes.Size = new Size(93, 21);
            labelMistakes.TabIndex = 104;
            labelMistakes.Text = "Ошибок: 0";
            // 
            // labelSpeed
            // 
            labelSpeed.AutoSize = true;
            labelSpeed.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelSpeed.ForeColor = Color.FromArgb(46, 204, 113);
            labelSpeed.Location = new Point(262, 64);
            labelSpeed.Name = "labelSpeed";
            labelSpeed.Size = new Size(182, 21);
            labelSpeed.TabIndex = 103;
            labelSpeed.Text = "Скорость: 0 симв/мин";
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.FromArgb(30, 30, 30);
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Segoe UI", 11F);
            buttonExit.ForeColor = SystemColors.ButtonFace;
            buttonExit.Location = new Point(573, 398);
            buttonExit.Margin = new Padding(2);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(239, 47);
            buttonExit.TabIndex = 102;
            buttonExit.Text = "Стоп";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += ButtonExit_Click;
            // 
            // richTextBoxUserInput
            // 
            richTextBoxUserInput.BackColor = Color.FromArgb(45, 45, 48);
            richTextBoxUserInput.BorderStyle = BorderStyle.FixedSingle;
            richTextBoxUserInput.Font = new Font("Consolas", 15F);
            richTextBoxUserInput.ForeColor = Color.White;
            richTextBoxUserInput.Location = new Point(36, 260);
            richTextBoxUserInput.Name = "richTextBoxUserInput";
            richTextBoxUserInput.ScrollBars = RichTextBoxScrollBars.None;
            richTextBoxUserInput.ShortcutsEnabled = false;
            richTextBoxUserInput.Size = new Size(777, 28);
            richTextBoxUserInput.TabIndex = 100;
            richTextBoxUserInput.Text = "";
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(853, 479);
            Controls.Add(richTextBoxUserInput);
            Controls.Add(buttonExit);
            Controls.Add(groupBox1);
            Controls.Add(richTextBoxTargetText);
            Controls.Add(buttonRestart);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ButtonFace;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
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
        private RichTextBox richTextBoxTargetText;
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