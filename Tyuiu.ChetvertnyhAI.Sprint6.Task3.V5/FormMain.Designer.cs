namespace Tyuiu.ChetvertnyhAI.Sprint6.Task3.V5
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
            dataGridViewMatrix_CAI = new DataGridView();
            textBoxTask_CAI = new TextBox();
            groupBoxResult_CAI = new GroupBox();
            dataGridViewResultMatrix_CAI = new DataGridView();
            textBoxResult_CAI = new TextBox();
            buttonDone_CAI = new Button();
            buttonHelp_CAI = new Button();
            groupBoxTask_CAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_CAI).BeginInit();
            groupBoxResult_CAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResultMatrix_CAI).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_CAI
            // 
            groupBoxTask_CAI.Controls.Add(dataGridViewMatrix_CAI);
            groupBoxTask_CAI.Controls.Add(textBoxTask_CAI);
            groupBoxTask_CAI.Location = new Point(12, 12);
            groupBoxTask_CAI.Name = "groupBoxTask_CAI";
            groupBoxTask_CAI.Size = new Size(522, 341);
            groupBoxTask_CAI.TabIndex = 0;
            groupBoxTask_CAI.TabStop = false;
            groupBoxTask_CAI.Text = "Условие";
            // 
            // dataGridViewMatrix_CAI
            // 
            dataGridViewMatrix_CAI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_CAI.ColumnHeadersVisible = false;
            dataGridViewMatrix_CAI.Location = new Point(266, 26);
            dataGridViewMatrix_CAI.Name = "dataGridViewMatrix_CAI";
            dataGridViewMatrix_CAI.RowHeadersVisible = false;
            dataGridViewMatrix_CAI.RowHeadersWidth = 51;
            dataGridViewMatrix_CAI.Size = new Size(243, 213);
            dataGridViewMatrix_CAI.TabIndex = 1;
            // 
            // textBoxTask_CAI
            // 
            textBoxTask_CAI.BackColor = SystemColors.Control;
            textBoxTask_CAI.BorderStyle = BorderStyle.None;
            textBoxTask_CAI.Location = new Point(6, 26);
            textBoxTask_CAI.Multiline = true;
            textBoxTask_CAI.Name = "textBoxTask_CAI";
            textBoxTask_CAI.ReadOnly = true;
            textBoxTask_CAI.Size = new Size(286, 189);
            textBoxTask_CAI.TabIndex = 0;
            textBoxTask_CAI.Text = "Дана матрица 5 на 5\r\n30 -20   7   -8   9\r\n32  17 -14  -7   33\r\n19 -19 -13  14 -20\r\n11  30  -1   26   6\r\n30 -15 -20 -5   15\r\nВыполнить сортировку по возрастанию в третьем столбце.";
            // 
            // groupBoxResult_CAI
            // 
            groupBoxResult_CAI.Controls.Add(dataGridViewResultMatrix_CAI);
            groupBoxResult_CAI.Controls.Add(textBoxResult_CAI);
            groupBoxResult_CAI.Location = new Point(549, 12);
            groupBoxResult_CAI.Name = "groupBoxResult_CAI";
            groupBoxResult_CAI.Size = new Size(267, 267);
            groupBoxResult_CAI.TabIndex = 1;
            groupBoxResult_CAI.TabStop = false;
            groupBoxResult_CAI.Text = "Вывод данных";
            // 
            // dataGridViewResultMatrix_CAI
            // 
            dataGridViewResultMatrix_CAI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResultMatrix_CAI.ColumnHeadersVisible = false;
            dataGridViewResultMatrix_CAI.Location = new Point(6, 49);
            dataGridViewResultMatrix_CAI.Name = "dataGridViewResultMatrix_CAI";
            dataGridViewResultMatrix_CAI.RowHeadersVisible = false;
            dataGridViewResultMatrix_CAI.RowHeadersWidth = 51;
            dataGridViewResultMatrix_CAI.Size = new Size(255, 204);
            dataGridViewResultMatrix_CAI.TabIndex = 1;
            // 
            // textBoxResult_CAI
            // 
            textBoxResult_CAI.BackColor = SystemColors.Control;
            textBoxResult_CAI.BorderStyle = BorderStyle.None;
            textBoxResult_CAI.Location = new Point(6, 23);
            textBoxResult_CAI.Name = "textBoxResult_CAI";
            textBoxResult_CAI.Size = new Size(125, 20);
            textBoxResult_CAI.TabIndex = 0;
            textBoxResult_CAI.Text = "Результат:";
            // 
            // buttonDone_CAI
            // 
            buttonDone_CAI.Location = new Point(693, 308);
            buttonDone_CAI.Name = "buttonDone_CAI";
            buttonDone_CAI.Size = new Size(123, 45);
            buttonDone_CAI.TabIndex = 2;
            buttonDone_CAI.Text = "Выполнить";
            buttonDone_CAI.UseVisualStyleBackColor = true;
            buttonDone_CAI.Click += buttonDone_CAI_Click;
            // 
            // buttonHelp_CAI
            // 
            buttonHelp_CAI.FlatStyle = FlatStyle.Flat;
            buttonHelp_CAI.Location = new Point(638, 308);
            buttonHelp_CAI.Name = "buttonHelp_CAI";
            buttonHelp_CAI.Size = new Size(42, 46);
            buttonHelp_CAI.TabIndex = 3;
            buttonHelp_CAI.Text = "?";
            buttonHelp_CAI.UseVisualStyleBackColor = true;
            buttonHelp_CAI.Click += buttonHelp_CAI_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 365);
            Controls.Add(buttonHelp_CAI);
            Controls.Add(buttonDone_CAI);
            Controls.Add(groupBoxResult_CAI);
            Controls.Add(groupBoxTask_CAI);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 5 | Четвертных А. И.";
            Load += FormMain_Load;
            groupBoxTask_CAI.ResumeLayout(false);
            groupBoxTask_CAI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_CAI).EndInit();
            groupBoxResult_CAI.ResumeLayout(false);
            groupBoxResult_CAI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResultMatrix_CAI).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_CAI;
        private TextBox textBoxTask_CAI;
        private DataGridView dataGridViewMatrix_CAI;
        private GroupBox groupBoxResult_CAI;
        private DataGridView dataGridViewResultMatrix_CAI;
        private TextBox textBoxResult_CAI;
        private Button buttonDone_CAI;
        private Button buttonHelp_CAI;
    }
}
