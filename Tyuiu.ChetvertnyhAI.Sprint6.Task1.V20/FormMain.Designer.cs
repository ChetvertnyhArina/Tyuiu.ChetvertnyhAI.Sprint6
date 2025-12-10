namespace Tyuiu.ChetvertnyhAI.Sprint6.Task1.V20
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxTask_CAI = new GroupBox();
            textBoxTaskU_CAI = new TextBox();
            groupBoxVarU_CAI = new GroupBox();
            textBoxStopV_CAI = new TextBox();
            textBoxStartV_CAI = new TextBox();
            textBoxTwo_CAI = new TextBox();
            textBoxOne_CAI = new TextBox();
            groupBoxResult_CAI = new GroupBox();
            textBoxResult_CAI = new TextBox();
            textBoxThree_CAI = new TextBox();
            buttonDone = new Button();
            buttonHelp = new Button();
            groupBoxTask_CAI.SuspendLayout();
            groupBoxVarU_CAI.SuspendLayout();
            groupBoxResult_CAI.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_CAI
            // 
            groupBoxTask_CAI.Controls.Add(textBoxTaskU_CAI);
            groupBoxTask_CAI.Location = new Point(12, 12);
            groupBoxTask_CAI.Name = "groupBoxTask_CAI";
            groupBoxTask_CAI.Size = new Size(470, 260);
            groupBoxTask_CAI.TabIndex = 0;
            groupBoxTask_CAI.TabStop = false;
            groupBoxTask_CAI.Text = "Условие";
            // 
            // textBoxTaskU_CAI
            // 
            textBoxTaskU_CAI.BackColor = SystemColors.Control;
            textBoxTaskU_CAI.BorderStyle = BorderStyle.None;
            textBoxTaskU_CAI.Location = new Point(6, 26);
            textBoxTaskU_CAI.Multiline = true;
            textBoxTaskU_CAI.Name = "textBoxTaskU_CAI";
            textBoxTaskU_CAI.ReadOnly = true;
            textBoxTaskU_CAI.Size = new Size(433, 61);
            textBoxTaskU_CAI.TabIndex = 0;
            textBoxTaskU_CAI.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в виде таблицы.";
            // 
            // groupBoxVarU_CAI
            // 
            groupBoxVarU_CAI.Controls.Add(textBoxStopV_CAI);
            groupBoxVarU_CAI.Controls.Add(textBoxStartV_CAI);
            groupBoxVarU_CAI.Controls.Add(textBoxTwo_CAI);
            groupBoxVarU_CAI.Controls.Add(textBoxOne_CAI);
            groupBoxVarU_CAI.Location = new Point(12, 278);
            groupBoxVarU_CAI.Name = "groupBoxVarU_CAI";
            groupBoxVarU_CAI.Size = new Size(309, 160);
            groupBoxVarU_CAI.TabIndex = 1;
            groupBoxVarU_CAI.TabStop = false;
            groupBoxVarU_CAI.Text = "Ввод данных";
            // 
            // textBoxStopV_CAI
            // 
            textBoxStopV_CAI.Location = new Point(167, 83);
            textBoxStopV_CAI.Name = "textBoxStopV_CAI";
            textBoxStopV_CAI.Size = new Size(125, 27);
            textBoxStopV_CAI.TabIndex = 2;
            // 
            // textBoxStartV_CAI
            // 
            textBoxStartV_CAI.Location = new Point(16, 83);
            textBoxStartV_CAI.Name = "textBoxStartV_CAI";
            textBoxStartV_CAI.Size = new Size(125, 27);
            textBoxStartV_CAI.TabIndex = 2;
            // 
            // textBoxTwo_CAI
            // 
            textBoxTwo_CAI.BackColor = SystemColors.Control;
            textBoxTwo_CAI.BorderStyle = BorderStyle.None;
            textBoxTwo_CAI.Location = new Point(167, 39);
            textBoxTwo_CAI.Name = "textBoxTwo_CAI";
            textBoxTwo_CAI.Size = new Size(125, 20);
            textBoxTwo_CAI.TabIndex = 2;
            textBoxTwo_CAI.Text = "Конец шага:";
            // 
            // textBoxOne_CAI
            // 
            textBoxOne_CAI.BackColor = SystemColors.Control;
            textBoxOne_CAI.BorderStyle = BorderStyle.None;
            textBoxOne_CAI.Location = new Point(16, 39);
            textBoxOne_CAI.Name = "textBoxOne_CAI";
            textBoxOne_CAI.Size = new Size(125, 20);
            textBoxOne_CAI.TabIndex = 2;
            textBoxOne_CAI.Text = "Старт шага:";
            // 
            // groupBoxResult_CAI
            // 
            groupBoxResult_CAI.Controls.Add(textBoxResult_CAI);
            groupBoxResult_CAI.Controls.Add(textBoxThree_CAI);
            groupBoxResult_CAI.Location = new Point(488, 12);
            groupBoxResult_CAI.Name = "groupBoxResult_CAI";
            groupBoxResult_CAI.Size = new Size(314, 376);
            groupBoxResult_CAI.TabIndex = 2;
            groupBoxResult_CAI.TabStop = false;
            groupBoxResult_CAI.Text = "Вывод данных";
            // 
            // textBoxResult_CAI
            // 
            textBoxResult_CAI.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_CAI.Location = new Point(6, 60);
            textBoxResult_CAI.Multiline = true;
            textBoxResult_CAI.Name = "textBoxResult_CAI";
            textBoxResult_CAI.ReadOnly = true;
            textBoxResult_CAI.ScrollBars = ScrollBars.Vertical;
            textBoxResult_CAI.Size = new Size(294, 310);
            textBoxResult_CAI.TabIndex = 1;
            // 
            // textBoxThree_CAI
            // 
            textBoxThree_CAI.BackColor = SystemColors.Control;
            textBoxThree_CAI.BorderStyle = BorderStyle.None;
            textBoxThree_CAI.Location = new Point(6, 26);
            textBoxThree_CAI.Name = "textBoxThree_CAI";
            textBoxThree_CAI.Size = new Size(125, 20);
            textBoxThree_CAI.TabIndex = 0;
            textBoxThree_CAI.Text = "Результат";
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.LightBlue;
            buttonDone.Location = new Point(488, 395);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(300, 43);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_CAI_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.Pink;
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Location = new Point(349, 395);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(124, 43);
            buttonHelp.TabIndex = 4;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_CAI_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxResult_CAI);
            Controls.Add(groupBoxVarU_CAI);
            Controls.Add(groupBoxTask_CAI);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 20 | Четвертных А. И.";
            Load += FormMain_Load;
            groupBoxTask_CAI.ResumeLayout(false);
            groupBoxTask_CAI.PerformLayout();
            groupBoxVarU_CAI.ResumeLayout(false);
            groupBoxVarU_CAI.PerformLayout();
            groupBoxResult_CAI.ResumeLayout(false);
            groupBoxResult_CAI.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_CAI;
        private TextBox textBoxTaskU_CAI;
        private GroupBox groupBoxVarU_CAI;
        private TextBox textBoxStopV_CAI;
        private TextBox textBoxStartV_CAI;
        private TextBox textBoxTwo_CAI;
        private TextBox textBoxOne_CAI;
        private GroupBox groupBoxResult_CAI;
        private TextBox textBoxResult_CAI;
        private TextBox textBoxThree_CAI;
        private Button buttonDone;
        private Button buttonHelp;
    }
}
