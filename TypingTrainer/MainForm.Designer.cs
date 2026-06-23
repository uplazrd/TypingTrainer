namespace TypingTrainer
{
    partial class MainForm
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
            label1 = new Label();
            label2 = new Label();
            comboBoxTextSelection = new ComboBox();
            buttonStart = new Button();
            label3 = new Label();
            numericUpDownLength = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLength).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(63, 37);
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
            label2.Location = new Point(43, 95);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 1;
            label2.Text = "Выберите режим:";
            // 
            // comboBoxTextSelection
            // 
            comboBoxTextSelection.BackColor = Color.FromArgb(45, 45, 45);
            comboBoxTextSelection.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTextSelection.FlatStyle = FlatStyle.Flat;
            comboBoxTextSelection.Font = new Font("Segoe UI", 11F);
            comboBoxTextSelection.ForeColor = SystemColors.ButtonFace;
            comboBoxTextSelection.FormattingEnabled = true;
            comboBoxTextSelection.Location = new Point(43, 113);
            comboBoxTextSelection.Name = "comboBoxTextSelection";
            comboBoxTextSelection.Size = new Size(275, 28);
            comboBoxTextSelection.TabIndex = 2;
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.FromArgb(35, 35, 35);
            buttonStart.FlatStyle = FlatStyle.Flat;
            buttonStart.Font = new Font("Segoe UI", 11F);
            buttonStart.ForeColor = SystemColors.ButtonFace;
            buttonStart.Location = new Point(43, 225);
            buttonStart.Margin = new Padding(2);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(274, 47);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "Начать";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += ButtonStart_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 156);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 4;
            label3.Text = "Количество слов:";
            // 
            // numericUpDownLength
            // 
            numericUpDownLength.BackColor = Color.FromArgb(45, 45, 45);
            numericUpDownLength.Font = new Font("Segoe UI", 11F);
            numericUpDownLength.ForeColor = SystemColors.ButtonFace;
            numericUpDownLength.Location = new Point(43, 174);
            numericUpDownLength.Name = "numericUpDownLength";
            numericUpDownLength.Size = new Size(274, 27);
            numericUpDownLength.TabIndex = 6;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(356, 312);
            Controls.Add(numericUpDownLength);
            Controls.Add(label3);
            Controls.Add(buttonStart);
            Controls.Add(comboBoxTextSelection);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ButtonFace;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Тренажёр печати - Меню";
            ((System.ComponentModel.ISupportInitialize)numericUpDownLength).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBoxTextSelection;
        private Button buttonStart;
        private Label label3;
        private NumericUpDown numericUpDownLength;
    }
}