namespace Tyuiu.ChetvertnyhAI.Sprint6.Task5.V3
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
            panelTop_CAI = new Panel();
            buttonHelp_CAI = new Button();
            buttonOpen_CAI = new Button();
            buttonDone_CAI = new Button();
            groupBoxTask_CAI = new GroupBox();
            textBox1 = new TextBox();
            panelLeft_CAI = new Panel();
            groupBoxResult_CAI = new GroupBox();
            dataGridViewResult_CAI = new DataGridView();
            panelFill_CAI = new Panel();
            chartFunction_CAI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter1 = new Splitter();
            panelTop_CAI.SuspendLayout();
            groupBoxTask_CAI.SuspendLayout();
            panelLeft_CAI.SuspendLayout();
            groupBoxResult_CAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_CAI).BeginInit();
            panelFill_CAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_CAI).BeginInit();
            SuspendLayout();
            // 
            // panelTop_CAI
            // 
            panelTop_CAI.Controls.Add(buttonHelp_CAI);
            panelTop_CAI.Controls.Add(buttonOpen_CAI);
            panelTop_CAI.Controls.Add(buttonDone_CAI);
            panelTop_CAI.Controls.Add(groupBoxTask_CAI);
            panelTop_CAI.Dock = DockStyle.Top;
            panelTop_CAI.Location = new Point(0, 0);
            panelTop_CAI.Name = "panelTop_CAI";
            panelTop_CAI.Size = new Size(861, 103);
            panelTop_CAI.TabIndex = 0;
            // 
            // buttonHelp_CAI
            // 
            buttonHelp_CAI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_CAI.Location = new Point(745, 12);
            buttonHelp_CAI.Name = "buttonHelp_CAI";
            buttonHelp_CAI.Size = new Size(104, 52);
            buttonHelp_CAI.TabIndex = 3;
            buttonHelp_CAI.Text = "Справка";
            buttonHelp_CAI.UseVisualStyleBackColor = true;
            buttonHelp_CAI.Click += buttonHelp_CAI_Click;
            // 
            // buttonOpen_CAI
            // 
            buttonOpen_CAI.Location = new Point(638, 12);
            buttonOpen_CAI.Name = "buttonOpen_CAI";
            buttonOpen_CAI.Size = new Size(101, 52);
            buttonOpen_CAI.TabIndex = 2;
            buttonOpen_CAI.Text = "Открыть файл";
            buttonOpen_CAI.UseVisualStyleBackColor = true;
            buttonOpen_CAI.Click += buttonOpen_CAI_Click;
            // 
            // buttonDone_CAI
            // 
            buttonDone_CAI.Location = new Point(452, 12);
            buttonDone_CAI.Name = "buttonDone_CAI";
            buttonDone_CAI.Size = new Size(180, 47);
            buttonDone_CAI.TabIndex = 1;
            buttonDone_CAI.Text = "Выполнить";
            buttonDone_CAI.UseVisualStyleBackColor = true;
            buttonDone_CAI.Click += buttonDone_CAI_Click;
            // 
            // groupBoxTask_CAI
            // 
            groupBoxTask_CAI.Controls.Add(textBox1);
            groupBoxTask_CAI.Location = new Point(3, 3);
            groupBoxTask_CAI.Name = "groupBoxTask_CAI";
            groupBoxTask_CAI.Size = new Size(443, 90);
            groupBoxTask_CAI.TabIndex = 0;
            groupBoxTask_CAI.TabStop = false;
            groupBoxTask_CAI.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(6, 20);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(428, 64);
            textBox1.TabIndex = 0;
            textBox1.Text = "Прочитать данные из файла InPutFileTask5V3.txt. Вывести в dataGridView вещественные значения и построить диаграмму по этим значениям.";
            // 
            // panelLeft_CAI
            // 
            panelLeft_CAI.Controls.Add(groupBoxResult_CAI);
            panelLeft_CAI.Dock = DockStyle.Left;
            panelLeft_CAI.Location = new Point(0, 103);
            panelLeft_CAI.Name = "panelLeft_CAI";
            panelLeft_CAI.Size = new Size(250, 300);
            panelLeft_CAI.TabIndex = 1;
            // 
            // groupBoxResult_CAI
            // 
            groupBoxResult_CAI.Controls.Add(dataGridViewResult_CAI);
            groupBoxResult_CAI.Dock = DockStyle.Fill;
            groupBoxResult_CAI.Location = new Point(0, 0);
            groupBoxResult_CAI.Name = "groupBoxResult_CAI";
            groupBoxResult_CAI.Size = new Size(250, 300);
            groupBoxResult_CAI.TabIndex = 1;
            groupBoxResult_CAI.TabStop = false;
            groupBoxResult_CAI.Text = "Вывод данных";
            // 
            // dataGridViewResult_CAI
            // 
            dataGridViewResult_CAI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_CAI.ColumnHeadersVisible = false;
            dataGridViewResult_CAI.Location = new Point(3, 26);
            dataGridViewResult_CAI.Name = "dataGridViewResult_CAI";
            dataGridViewResult_CAI.RowHeadersVisible = false;
            dataGridViewResult_CAI.RowHeadersWidth = 51;
            dataGridViewResult_CAI.ScrollBars = ScrollBars.Vertical;
            dataGridViewResult_CAI.Size = new Size(244, 262);
            dataGridViewResult_CAI.TabIndex = 1;
            // 
            // panelFill_CAI
            // 
            panelFill_CAI.Controls.Add(chartFunction_CAI);
            panelFill_CAI.Controls.Add(splitter1);
            panelFill_CAI.Dock = DockStyle.Fill;
            panelFill_CAI.Location = new Point(250, 103);
            panelFill_CAI.Name = "panelFill_CAI";
            panelFill_CAI.Size = new Size(611, 300);
            panelFill_CAI.TabIndex = 2;
            // 
            // chartFunction_CAI
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_CAI.ChartAreas.Add(chartArea1);
            chartFunction_CAI.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartFunction_CAI.Legends.Add(legend1);
            chartFunction_CAI.Location = new Point(4, 0);
            chartFunction_CAI.Name = "chartFunction_CAI";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_CAI.Series.Add(series1);
            chartFunction_CAI.Size = new Size(607, 300);
            chartFunction_CAI.TabIndex = 1;
            chartFunction_CAI.Text = "chart1";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 300);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 403);
            Controls.Add(panelFill_CAI);
            Controls.Add(panelLeft_CAI);
            Controls.Add(panelTop_CAI);
            MinimumSize = new Size(800, 450);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 5 | Вариант 3 | Четвертных А. И.";
            panelTop_CAI.ResumeLayout(false);
            groupBoxTask_CAI.ResumeLayout(false);
            groupBoxTask_CAI.PerformLayout();
            panelLeft_CAI.ResumeLayout(false);
            groupBoxResult_CAI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_CAI).EndInit();
            panelFill_CAI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_CAI).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_CAI;
        private GroupBox groupBoxTask_CAI;
        private TextBox textBox1;
        private Panel panelLeft_CAI;
        private GroupBox groupBoxResult_CAI;
        private DataGridView dataGridViewResult_CAI;
        private Panel panelFill_CAI;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_CAI;
        private Splitter splitter1;
        private Button buttonHelp_CAI;
        private Button buttonOpen_CAI;
        private Button buttonDone_CAI;
    }
}
