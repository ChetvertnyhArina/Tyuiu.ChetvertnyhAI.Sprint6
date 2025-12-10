namespace Tyuiu.ChetvertnyhAI.Sprint6.Task2.V6
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask_CAI = new GroupBox();
            textBoxTask_CAI = new TextBox();
            groupBoxVarV_CAI = new GroupBox();
            textBoxStop_CAI = new TextBox();
            textBoxStart_CAI = new TextBox();
            textBoxTwo_CAI = new TextBox();
            textBoxOne_CAI = new TextBox();
            groupBoxResult_CAI = new GroupBox();
            chartFunction_CAI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewFunction_CAI = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            textBoxThree_CAI = new TextBox();
            buttonDone_CAI = new Button();
            buttonHelp_CAI = new Button();
            groupBoxTask_CAI.SuspendLayout();
            groupBoxVarV_CAI.SuspendLayout();
            groupBoxResult_CAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_CAI).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_CAI).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_CAI
            // 
            groupBoxTask_CAI.Controls.Add(textBoxTask_CAI);
            groupBoxTask_CAI.Location = new Point(12, 12);
            groupBoxTask_CAI.Name = "groupBoxTask_CAI";
            groupBoxTask_CAI.Size = new Size(541, 288);
            groupBoxTask_CAI.TabIndex = 0;
            groupBoxTask_CAI.TabStop = false;
            groupBoxTask_CAI.Text = "Условие";
            // 
            // textBoxTask_CAI
            // 
            textBoxTask_CAI.BackColor = SystemColors.Control;
            textBoxTask_CAI.BorderStyle = BorderStyle.None;
            textBoxTask_CAI.Location = new Point(6, 26);
            textBoxTask_CAI.Multiline = true;
            textBoxTask_CAI.Name = "textBoxTask_CAI";
            textBoxTask_CAI.ReadOnly = true;
            textBoxTask_CAI.Size = new Size(529, 85);
            textBoxTask_CAI.TabIndex = 0;
            textBoxTask_CAI.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в DataGridView и построить график функции.";
            // 
            // groupBoxVarV_CAI
            // 
            groupBoxVarV_CAI.Controls.Add(textBoxStop_CAI);
            groupBoxVarV_CAI.Controls.Add(textBoxStart_CAI);
            groupBoxVarV_CAI.Controls.Add(textBoxTwo_CAI);
            groupBoxVarV_CAI.Controls.Add(textBoxOne_CAI);
            groupBoxVarV_CAI.Location = new Point(12, 306);
            groupBoxVarV_CAI.Name = "groupBoxVarV_CAI";
            groupBoxVarV_CAI.Size = new Size(317, 134);
            groupBoxVarV_CAI.TabIndex = 1;
            groupBoxVarV_CAI.TabStop = false;
            groupBoxVarV_CAI.Text = "Ввод данных";
            // 
            // textBoxStop_CAI
            // 
            textBoxStop_CAI.Location = new Point(172, 62);
            textBoxStop_CAI.Name = "textBoxStop_CAI";
            textBoxStop_CAI.Size = new Size(125, 27);
            textBoxStop_CAI.TabIndex = 2;
            // 
            // textBoxStart_CAI
            // 
            textBoxStart_CAI.Location = new Point(15, 62);
            textBoxStart_CAI.Name = "textBoxStart_CAI";
            textBoxStart_CAI.Size = new Size(125, 27);
            textBoxStart_CAI.TabIndex = 2;
            // 
            // textBoxTwo_CAI
            // 
            textBoxTwo_CAI.BackColor = SystemColors.Control;
            textBoxTwo_CAI.BorderStyle = BorderStyle.None;
            textBoxTwo_CAI.Location = new Point(172, 36);
            textBoxTwo_CAI.Name = "textBoxTwo_CAI";
            textBoxTwo_CAI.Size = new Size(125, 20);
            textBoxTwo_CAI.TabIndex = 2;
            textBoxTwo_CAI.Text = "Конец шага:";
            // 
            // textBoxOne_CAI
            // 
            textBoxOne_CAI.BackColor = SystemColors.Control;
            textBoxOne_CAI.BorderStyle = BorderStyle.None;
            textBoxOne_CAI.Location = new Point(15, 36);
            textBoxOne_CAI.Name = "textBoxOne_CAI";
            textBoxOne_CAI.Size = new Size(125, 20);
            textBoxOne_CAI.TabIndex = 3;
            textBoxOne_CAI.Text = "Старт шага:";
            // 
            // groupBoxResult_CAI
            // 
            groupBoxResult_CAI.Controls.Add(chartFunction_CAI);
            groupBoxResult_CAI.Controls.Add(dataGridViewFunction_CAI);
            groupBoxResult_CAI.Controls.Add(textBoxThree_CAI);
            groupBoxResult_CAI.Location = new Point(559, 12);
            groupBoxResult_CAI.Name = "groupBoxResult_CAI";
            groupBoxResult_CAI.Size = new Size(690, 428);
            groupBoxResult_CAI.TabIndex = 2;
            groupBoxResult_CAI.TabStop = false;
            groupBoxResult_CAI.Text = "Вывод данных";
            // 
            // chartFunction_CAI
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_CAI.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_CAI.Legends.Add(legend1);
            chartFunction_CAI.Location = new Point(209, 49);
            chartFunction_CAI.Name = "chartFunction_CAI";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_CAI.Series.Add(series1);
            chartFunction_CAI.Size = new Size(475, 373);
            chartFunction_CAI.TabIndex = 2;
            chartFunction_CAI.Text = "chart1";
            // 
            // dataGridViewFunction_CAI
            // 
            dataGridViewFunction_CAI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_CAI.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewFunction_CAI.Location = new Point(6, 49);
            dataGridViewFunction_CAI.Name = "dataGridViewFunction_CAI";
            dataGridViewFunction_CAI.RowHeadersVisible = false;
            dataGridViewFunction_CAI.RowHeadersWidth = 51;
            dataGridViewFunction_CAI.Size = new Size(197, 373);
            dataGridViewFunction_CAI.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "X";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "F(X)";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 50;
            // 
            // textBoxThree_CAI
            // 
            textBoxThree_CAI.BackColor = SystemColors.Control;
            textBoxThree_CAI.BorderStyle = BorderStyle.None;
            textBoxThree_CAI.Location = new Point(6, 23);
            textBoxThree_CAI.Name = "textBoxThree_CAI";
            textBoxThree_CAI.Size = new Size(125, 20);
            textBoxThree_CAI.TabIndex = 0;
            textBoxThree_CAI.Text = "Результат:";
            // 
            // buttonDone_CAI
            // 
            buttonDone_CAI.BackColor = Color.LightSteelBlue;
            buttonDone_CAI.Location = new Point(346, 391);
            buttonDone_CAI.Name = "buttonDone_CAI";
            buttonDone_CAI.Size = new Size(207, 49);
            buttonDone_CAI.TabIndex = 3;
            buttonDone_CAI.Text = "Выполнить";
            buttonDone_CAI.UseVisualStyleBackColor = false;
            buttonDone_CAI.Click += buttonDone_CAI_Click;
            // 
            // buttonHelp_CAI
            // 
            buttonHelp_CAI.BackColor = Color.BlanchedAlmond;
            buttonHelp_CAI.FlatStyle = FlatStyle.Flat;
            buttonHelp_CAI.Location = new Point(346, 323);
            buttonHelp_CAI.Name = "buttonHelp_CAI";
            buttonHelp_CAI.Size = new Size(122, 62);
            buttonHelp_CAI.TabIndex = 4;
            buttonHelp_CAI.Text = "Справка";
            buttonHelp_CAI.UseVisualStyleBackColor = false;
            buttonHelp_CAI.Click += buttonHelp_CAI_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1261, 452);
            Controls.Add(buttonHelp_CAI);
            Controls.Add(buttonDone_CAI);
            Controls.Add(groupBoxResult_CAI);
            Controls.Add(groupBoxVarV_CAI);
            Controls.Add(groupBoxTask_CAI);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 6 | Четвертных А. И.";
            Load += FormMain_Load;
            groupBoxTask_CAI.ResumeLayout(false);
            groupBoxTask_CAI.PerformLayout();
            groupBoxVarV_CAI.ResumeLayout(false);
            groupBoxVarV_CAI.PerformLayout();
            groupBoxResult_CAI.ResumeLayout(false);
            groupBoxResult_CAI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_CAI).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_CAI).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_CAI;
        private TextBox textBoxTask_CAI;
        private GroupBox groupBoxVarV_CAI;
        private TextBox textBoxStop_CAI;
        private TextBox textBoxStart_CAI;
        private TextBox textBoxTwo_CAI;
        private TextBox textBoxOne_CAI;
        private GroupBox groupBoxResult_CAI;
        private Button buttonDone_CAI;
        private Button buttonHelp_CAI;
        private TextBox textBoxThree_CAI;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_CAI;
        private DataGridView dataGridViewFunction_CAI;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}
