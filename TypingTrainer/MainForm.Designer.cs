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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(90, 62);
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
            label2.Location = new Point(61, 158);
            label2.Name = "label2";
            label2.Size = new Size(156, 25);
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
            comboBoxTextSelection.Location = new Point(61, 188);
            comboBoxTextSelection.Margin = new Padding(4, 5, 4, 5);
            comboBoxTextSelection.Name = "comboBoxTextSelection";
            comboBoxTextSelection.Size = new Size(391, 38);
            comboBoxTextSelection.TabIndex = 2;
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.FromArgb(35, 35, 35);
            buttonStart.FlatStyle = FlatStyle.Flat;
            buttonStart.Font = new Font("Segoe UI", 11F);
            buttonStart.ForeColor = SystemColors.ButtonFace;
            buttonStart.Location = new Point(61, 292);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(391, 78);
            buttonStart.TabIndex = 3;
            buttonStart.Text = "Начать";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += ButtonStart_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(494, 420);
            Controls.Add(buttonStart);
            Controls.Add(comboBoxTextSelection);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ButtonFace;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Тренажёр печати - Меню";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBoxTextSelection;
        private Button buttonStart;
    }
}