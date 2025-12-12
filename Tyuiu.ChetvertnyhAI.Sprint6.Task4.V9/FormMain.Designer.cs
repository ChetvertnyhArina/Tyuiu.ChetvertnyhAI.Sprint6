namespace Tyuiu.ChetvertnyhAI.Sprint6.Task4.V9
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            panelTop_CAI = new Panel();
            buttonHelp_CAI = new Button();
            buttonSave_CAI = new Button();
            groupBoxVar_CAI = new GroupBox();
            textBoxStopV_CAI = new TextBox();
            textBoxStartV_CAI = new TextBox();
            textBoxTwo_CAI = new TextBox();
            textBoxOne_CAI = new TextBox();
            groupBoxTask_CAI = new GroupBox();
            textBoxTask_CAI = new TextBox();
            buttonDone_CAI = new Button();
            panelLeft_CAI = new Panel();
            groupBoxResult_CAI = new GroupBox();
            textBoxResult_CAI = new TextBox();
            panelRight_CAI = new Panel();
            chartFunction_CAI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter1 = new Splitter();
            panelTop_CAI.SuspendLayout();
            groupBoxVar_CAI.SuspendLayout();
            groupBoxTask_CAI.SuspendLayout();
            panelLeft_CAI.SuspendLayout();
            groupBoxResult_CAI.SuspendLayout();
            panelRight_CAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_CAI).BeginInit();
            SuspendLayout();
            // 
            // panelTop_CAI
            // 
            panelTop_CAI.Controls.Add(buttonHelp_CAI);
            panelTop_CAI.Controls.Add(buttonSave_CAI);
            panelTop_CAI.Controls.Add(groupBoxVar_CAI);
            panelTop_CAI.Controls.Add(groupBoxTask_CAI);
            panelTop_CAI.Controls.Add(buttonDone_CAI);
            panelTop_CAI.Dock = DockStyle.Top;
            panelTop_CAI.Location = new Point(0, 0);
            panelTop_CAI.Name = "panelTop_CAI";
            panelTop_CAI.Size = new Size(1264, 108);
            panelTop_CAI.TabIndex = 0;
            // 
            // buttonHelp_CAI
            // 
            buttonHelp_CAI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_CAI.Location = new Point(1122, 12);
            buttonHelp_CAI.Name = "buttonHelp_CAI";
            buttonHelp_CAI.Size = new Size(104, 52);
            buttonHelp_CAI.TabIndex = 4;
            buttonHelp_CAI.Text = "Справка";
            buttonHelp_CAI.UseVisualStyleBackColor = true;
            buttonHelp_CAI.Click += buttonHelp_CAI_Click;
            // 
            // buttonSave_CAI
            // 
            buttonSave_CAI.Location = new Point(1012, 13);
            buttonSave_CAI.Name = "buttonSave_CAI";
            buttonSave_CAI.Size = new Size(104, 52);
            buttonSave_CAI.TabIndex = 3;
            buttonSave_CAI.Text = "Сохранить";
            buttonSave_CAI.UseVisualStyleBackColor = true;
            buttonSave_CAI.Click += buttonSave_CAI_Click;
            // 
            // groupBoxVar_CAI
            // 
            groupBoxVar_CAI.Controls.Add(textBoxStopV_CAI);
            groupBoxVar_CAI.Controls.Add(textBoxStartV_CAI);
            groupBoxVar_CAI.Controls.Add(textBoxTwo_CAI);
            groupBoxVar_CAI.Controls.Add(textBoxOne_CAI);
            groupBoxVar_CAI.Location = new Point(538, 3);
            groupBoxVar_CAI.Name = "groupBoxVar_CAI";
            groupBoxVar_CAI.Size = new Size(285, 99);
            groupBoxVar_CAI.TabIndex = 2;
            groupBoxVar_CAI.TabStop = false;
            groupBoxVar_CAI.Text = "Ввод данных";
            // 
            // textBoxStopV_CAI
            // 
            textBoxStopV_CAI.Location = new Point(154, 52);
            textBoxStopV_CAI.Name = "textBoxStopV_CAI";
            textBoxStopV_CAI.Size = new Size(125, 27);
            textBoxStopV_CAI.TabIndex = 3;
            // 
            // textBoxStartV_CAI
            // 
            textBoxStartV_CAI.Location = new Point(6, 52);
            textBoxStartV_CAI.Name = "textBoxStartV_CAI";
            textBoxStartV_CAI.Size = new Size(125, 27);
            textBoxStartV_CAI.TabIndex = 2;
            // 
            // textBoxTwo_CAI
            // 
            textBoxTwo_CAI.BackColor = SystemColors.Control;
            textBoxTwo_CAI.BorderStyle = BorderStyle.None;
            textBoxTwo_CAI.Location = new Point(154, 26);
            textBoxTwo_CAI.Name = "textBoxTwo_CAI";
            textBoxTwo_CAI.Size = new Size(125, 20);
            textBoxTwo_CAI.TabIndex = 1;
            textBoxTwo_CAI.Text = "Конец шага:";
            // 
            // textBoxOne_CAI
            // 
            textBoxOne_CAI.BackColor = SystemColors.Control;
            textBoxOne_CAI.BorderStyle = BorderStyle.None;
            textBoxOne_CAI.Location = new Point(6, 26);
            textBoxOne_CAI.Name = "textBoxOne_CAI";
            textBoxOne_CAI.Size = new Size(125, 20);
            textBoxOne_CAI.TabIndex = 0;
            textBoxOne_CAI.Text = "Старт шага:";
            // 
            // groupBoxTask_CAI
            // 
            groupBoxTask_CAI.Controls.Add(textBoxTask_CAI);
            groupBoxTask_CAI.Location = new Point(3, 3);
            groupBoxTask_CAI.Name = "groupBoxTask_CAI";
            groupBoxTask_CAI.Size = new Size(533, 99);
            groupBoxTask_CAI.TabIndex = 1;
            groupBoxTask_CAI.TabStop = false;
            groupBoxTask_CAI.Text = "Условие";
            // 
            // textBoxTask_CAI
            // 
            textBoxTask_CAI.BackColor = SystemColors.Control;
            textBoxTask_CAI.BorderStyle = BorderStyle.None;
            textBoxTask_CAI.Location = new Point(2, 19);
            textBoxTask_CAI.Multiline = true;
            textBoxTask_CAI.Name = "textBoxTask_CAI";
            textBoxTask_CAI.ReadOnly = true;
            textBoxTask_CAI.Size = new Size(527, 74);
            textBoxTask_CAI.TabIndex = 1;
            textBoxTask_CAI.Text = "Протабулировать функцию на заданном диапазоне от -5 до 5.\r\nРезультат вывести в textBox. Построить график функции и сохранить файл \r\nOutPutFileTask4.txt по нажатию кнопки.";
            // 
            // buttonDone_CAI
            // 
            buttonDone_CAI.Location = new Point(839, 12);
            buttonDone_CAI.Name = "buttonDone_CAI";
            buttonDone_CAI.Size = new Size(167, 70);
            buttonDone_CAI.TabIndex = 0;
            buttonDone_CAI.Text = "Выполнить";
            buttonDone_CAI.UseVisualStyleBackColor = true;
            buttonDone_CAI.Click += buttonDone_CAI_Click;
            // 
            // panelLeft_CAI
            // 
            panelLeft_CAI.Controls.Add(groupBoxResult_CAI);
            panelLeft_CAI.Dock = DockStyle.Left;
            panelLeft_CAI.Location = new Point(0, 108);
            panelLeft_CAI.Name = "panelLeft_CAI";
            panelLeft_CAI.Padding = new Padding(5);
            panelLeft_CAI.Size = new Size(264, 498);
            panelLeft_CAI.TabIndex = 1;
            // 
            // groupBoxResult_CAI
            // 
            groupBoxResult_CAI.Controls.Add(textBoxResult_CAI);
            groupBoxResult_CAI.Dock = DockStyle.Fill;
            groupBoxResult_CAI.Location = new Point(5, 5);
            groupBoxResult_CAI.Name = "groupBoxResult_CAI";
            groupBoxResult_CAI.Size = new Size(254, 488);
            groupBoxResult_CAI.TabIndex = 1;
            groupBoxResult_CAI.TabStop = false;
            groupBoxResult_CAI.Text = "Вывод";
            // 
            // textBoxResult_CAI
            // 
            textBoxResult_CAI.Dock = DockStyle.Fill;
            textBoxResult_CAI.Location = new Point(3, 23);
            textBoxResult_CAI.Multiline = true;
            textBoxResult_CAI.Name = "textBoxResult_CAI";
            textBoxResult_CAI.ScrollBars = ScrollBars.Vertical;
            textBoxResult_CAI.Size = new Size(248, 462);
            textBoxResult_CAI.TabIndex = 1;
            // 
            // panelRight_CAI
            // 
            panelRight_CAI.Controls.Add(chartFunction_CAI);
            panelRight_CAI.Controls.Add(splitter1);
            panelRight_CAI.Dock = DockStyle.Fill;
            panelRight_CAI.Location = new Point(264, 108);
            panelRight_CAI.Name = "panelRight_CAI";
            panelRight_CAI.Size = new Size(1000, 498);
            panelRight_CAI.TabIndex = 2;
            // 
            // chartFunction_CAI
            // 
            chartArea2.Name = "ChartArea1";
            chartFunction_CAI.ChartAreas.Add(chartArea2);
            chartFunction_CAI.Dock = DockStyle.Fill;
            legend2.Name = "Legend1";
            chartFunction_CAI.Legends.Add(legend2);
            chartFunction_CAI.Location = new Point(4, 0);
            chartFunction_CAI.Name = "chartFunction_CAI";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartFunction_CAI.Series.Add(series2);
            chartFunction_CAI.Size = new Size(996, 498);
            chartFunction_CAI.TabIndex = 1;
            chartFunction_CAI.Text = "chart1";
            title2.Name = "Function";
            title2.Text = "График функции";
            chartFunction_CAI.Titles.Add(title2);
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 498);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 606);
            Controls.Add(panelRight_CAI);
            Controls.Add(panelLeft_CAI);
            Controls.Add(panelTop_CAI);
            MinimumSize = new Size(800, 450);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 9 | Четвертных А. И.";
            panelTop_CAI.ResumeLayout(false);
            groupBoxVar_CAI.ResumeLayout(false);
            groupBoxVar_CAI.PerformLayout();
            groupBoxTask_CAI.ResumeLayout(false);
            groupBoxTask_CAI.PerformLayout();
            panelLeft_CAI.ResumeLayout(false);
            groupBoxResult_CAI.ResumeLayout(false);
            groupBoxResult_CAI.PerformLayout();
            panelRight_CAI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_CAI).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_CAI;
        private Panel panelLeft_CAI;
        private Panel panelRight_CAI;
        private Button buttonDone_CAI;
        private GroupBox groupBoxResult_CAI;
        private TextBox textBoxResult_CAI;
        private Splitter splitter1;
        private GroupBox groupBoxTask_CAI;
        private TextBox textBoxTask_CAI;
        private GroupBox groupBoxVar_CAI;
        private TextBox textBoxTwo_CAI;
        private TextBox textBoxOne_CAI;
        private TextBox textBoxStopV_CAI;
        private TextBox textBoxStartV_CAI;
        private Button buttonHelp_CAI;
        private Button buttonSave_CAI;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_CAI;
    }
}
