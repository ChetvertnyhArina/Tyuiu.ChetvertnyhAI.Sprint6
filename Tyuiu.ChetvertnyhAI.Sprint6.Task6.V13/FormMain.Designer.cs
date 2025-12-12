namespace Tyuiu.ChetvertnyhAI.Sprint6.Task6.V13
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
            components = new System.ComponentModel.Container();
            panelTop_CAI = new Panel();
            buttonHelp_CAI = new Button();
            groupBoxTask_CAI = new GroupBox();
            textBox1 = new TextBox();
            buttonDone_CAI = new Button();
            buttonOpenFile_CAI = new Button();
            panelLeft_CAI = new Panel();
            groupBoxIn_CAI = new GroupBox();
            textBoxInFile_CAI = new TextBox();
            splitter1 = new Splitter();
            panelRight_CAI = new Panel();
            groupBoxOut_CAI = new GroupBox();
            textBoxOutFile_CAI = new TextBox();
            openFileDialogTask_CAI = new OpenFileDialog();
            toolTip_CAI = new ToolTip(components);
            panelTop_CAI.SuspendLayout();
            groupBoxTask_CAI.SuspendLayout();
            panelLeft_CAI.SuspendLayout();
            groupBoxIn_CAI.SuspendLayout();
            panelRight_CAI.SuspendLayout();
            groupBoxOut_CAI.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop_CAI
            // 
            panelTop_CAI.Controls.Add(buttonHelp_CAI);
            panelTop_CAI.Controls.Add(groupBoxTask_CAI);
            panelTop_CAI.Controls.Add(buttonDone_CAI);
            panelTop_CAI.Controls.Add(buttonOpenFile_CAI);
            panelTop_CAI.Dock = DockStyle.Top;
            panelTop_CAI.Location = new Point(0, 0);
            panelTop_CAI.Name = "panelTop_CAI";
            panelTop_CAI.Size = new Size(1083, 145);
            panelTop_CAI.TabIndex = 0;
            // 
            // buttonHelp_CAI
            // 
            buttonHelp_CAI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_CAI.FlatStyle = FlatStyle.Flat;
            buttonHelp_CAI.Location = new Point(968, 12);
            buttonHelp_CAI.Name = "buttonHelp_CAI";
            buttonHelp_CAI.Size = new Size(103, 55);
            buttonHelp_CAI.TabIndex = 3;
            buttonHelp_CAI.Text = "?";
            buttonHelp_CAI.UseVisualStyleBackColor = true;
            buttonHelp_CAI.Click += buttonHelp_CAI_Click;
            // 
            // groupBoxTask_CAI
            // 
            groupBoxTask_CAI.Controls.Add(textBox1);
            groupBoxTask_CAI.Location = new Point(3, 61);
            groupBoxTask_CAI.Name = "groupBoxTask_CAI";
            groupBoxTask_CAI.Size = new Size(1077, 84);
            groupBoxTask_CAI.TabIndex = 2;
            groupBoxTask_CAI.TabStop = false;
            groupBoxTask_CAI.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(6, 26);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(1045, 52);
            textBox1.TabIndex = 0;
            textBox1.Text = "Дан файл InPutFileTask6V13.txt. Вывести предпоследнее слово каждой строки в результирующую строку.";
            // 
            // buttonDone_CAI
            // 
            buttonDone_CAI.Location = new Point(172, 12);
            buttonDone_CAI.Name = "buttonDone_CAI";
            buttonDone_CAI.Size = new Size(142, 47);
            buttonDone_CAI.TabIndex = 1;
            buttonDone_CAI.Text = "Выполнить";
            toolTip_CAI.SetToolTip(buttonDone_CAI, "Выводит предпоследнее слово каждой строки в результирующую строку");
            buttonDone_CAI.UseVisualStyleBackColor = true;
            buttonDone_CAI.Click += buttonDone_CAI_Click;
            // 
            // buttonOpenFile_CAI
            // 
            buttonOpenFile_CAI.Location = new Point(12, 12);
            buttonOpenFile_CAI.Name = "buttonOpenFile_CAI";
            buttonOpenFile_CAI.Size = new Size(154, 47);
            buttonOpenFile_CAI.TabIndex = 0;
            buttonOpenFile_CAI.Text = "Открыть файл";
            toolTip_CAI.SetToolTip(buttonOpenFile_CAI, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            buttonOpenFile_CAI.UseVisualStyleBackColor = true;
            buttonOpenFile_CAI.Click += ButtonOpenFile_CAI_Click;
            // 
            // panelLeft_CAI
            // 
            panelLeft_CAI.Controls.Add(groupBoxIn_CAI);
            panelLeft_CAI.Controls.Add(splitter1);
            panelLeft_CAI.Dock = DockStyle.Left;
            panelLeft_CAI.Location = new Point(0, 145);
            panelLeft_CAI.Name = "panelLeft_CAI";
            panelLeft_CAI.Size = new Size(532, 394);
            panelLeft_CAI.TabIndex = 1;
            // 
            // groupBoxIn_CAI
            // 
            groupBoxIn_CAI.Controls.Add(textBoxInFile_CAI);
            groupBoxIn_CAI.Dock = DockStyle.Fill;
            groupBoxIn_CAI.Location = new Point(4, 0);
            groupBoxIn_CAI.Name = "groupBoxIn_CAI";
            groupBoxIn_CAI.Size = new Size(528, 394);
            groupBoxIn_CAI.TabIndex = 1;
            groupBoxIn_CAI.TabStop = false;
            groupBoxIn_CAI.Text = "Ввод";
            // 
            // textBoxInFile_CAI
            // 
            textBoxInFile_CAI.BackColor = SystemColors.Window;
            textBoxInFile_CAI.Dock = DockStyle.Fill;
            textBoxInFile_CAI.Location = new Point(3, 23);
            textBoxInFile_CAI.Multiline = true;
            textBoxInFile_CAI.Name = "textBoxInFile_CAI";
            textBoxInFile_CAI.ReadOnly = true;
            textBoxInFile_CAI.ScrollBars = ScrollBars.Vertical;
            textBoxInFile_CAI.Size = new Size(522, 368);
            textBoxInFile_CAI.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 394);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // panelRight_CAI
            // 
            panelRight_CAI.Controls.Add(groupBoxOut_CAI);
            panelRight_CAI.Dock = DockStyle.Fill;
            panelRight_CAI.Location = new Point(532, 145);
            panelRight_CAI.Name = "panelRight_CAI";
            panelRight_CAI.Size = new Size(551, 394);
            panelRight_CAI.TabIndex = 2;
            // 
            // groupBoxOut_CAI
            // 
            groupBoxOut_CAI.Controls.Add(textBoxOutFile_CAI);
            groupBoxOut_CAI.Dock = DockStyle.Fill;
            groupBoxOut_CAI.Location = new Point(0, 0);
            groupBoxOut_CAI.Name = "groupBoxOut_CAI";
            groupBoxOut_CAI.Size = new Size(551, 394);
            groupBoxOut_CAI.TabIndex = 0;
            groupBoxOut_CAI.TabStop = false;
            groupBoxOut_CAI.Text = "Вывод";
            // 
            // textBoxOutFile_CAI
            // 
            textBoxOutFile_CAI.BackColor = SystemColors.Window;
            textBoxOutFile_CAI.Dock = DockStyle.Fill;
            textBoxOutFile_CAI.Location = new Point(3, 23);
            textBoxOutFile_CAI.Multiline = true;
            textBoxOutFile_CAI.Name = "textBoxOutFile_CAI";
            textBoxOutFile_CAI.ReadOnly = true;
            textBoxOutFile_CAI.ScrollBars = ScrollBars.Vertical;
            textBoxOutFile_CAI.Size = new Size(545, 368);
            textBoxOutFile_CAI.TabIndex = 0;
            // 
            // openFileDialogTask_CAI
            // 
            openFileDialogTask_CAI.FileName = "openFileDialog1";
            // 
            // toolTip_CAI
            // 
            toolTip_CAI.ToolTipIcon = ToolTipIcon.Info;
            toolTip_CAI.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 539);
            Controls.Add(panelRight_CAI);
            Controls.Add(panelLeft_CAI);
            Controls.Add(panelTop_CAI);
            MinimumSize = new Size(800, 450);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 13 | Четвертных А. И.";
            panelTop_CAI.ResumeLayout(false);
            groupBoxTask_CAI.ResumeLayout(false);
            groupBoxTask_CAI.PerformLayout();
            panelLeft_CAI.ResumeLayout(false);
            groupBoxIn_CAI.ResumeLayout(false);
            groupBoxIn_CAI.PerformLayout();
            panelRight_CAI.ResumeLayout(false);
            groupBoxOut_CAI.ResumeLayout(false);
            groupBoxOut_CAI.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_CAI;
        private Panel panelLeft_CAI;
        private Splitter splitter1;
        private Panel panelRight_CAI;
        private Button buttonOpenFile_CAI;
        private ToolTip toolTip_CAI;
        private OpenFileDialog openFileDialogTask_CAI;
        private Button buttonDone_CAI;
        private GroupBox groupBoxTask_CAI;
        private TextBox textBox1;
        private GroupBox groupBoxIn_CAI;
        private TextBox textBoxInFile_CAI;
        private GroupBox groupBoxOut_CAI;
        private TextBox textBoxOutFile_CAI;
        private Button buttonHelp_CAI;
    }
}
