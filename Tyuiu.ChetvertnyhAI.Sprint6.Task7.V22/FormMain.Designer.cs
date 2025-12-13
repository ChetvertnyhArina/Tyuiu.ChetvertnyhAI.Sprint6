namespace Tyuiu.ChetvertnyhAI.Sprint6.Task7.V22
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelTop_CAI = new Panel();
            buttonHelp_CAI = new Button();
            buttonSaveFile_CAI = new Button();
            buttonDone_CAI = new Button();
            groupBoxTask_CAI = new GroupBox();
            textBox1 = new TextBox();
            splitterTop = new Splitter();
            buttonOpenFile_CAI = new Button();
            panelLeft_CAI = new Panel();
            groupBoxInFile_CAI = new GroupBox();
            dataGridViewInFile_CAI = new DataGridView();
            splitterBottom = new Splitter();
            panelRight_CAI = new Panel();
            groupBoxResult_CAI = new GroupBox();
            dataGridViewOutFile_CAI = new DataGridView();
            openFileDialogTask_CAI = new OpenFileDialog();
            toolTipButton = new ToolTip(components);
            saveFileDialogTask_CAI = new SaveFileDialog();
            saveFileDialogMatrix_CAI = new SaveFileDialog();
            panelTop_CAI.SuspendLayout();
            groupBoxTask_CAI.SuspendLayout();
            panelLeft_CAI.SuspendLayout();
            groupBoxInFile_CAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInFile_CAI).BeginInit();
            panelRight_CAI.SuspendLayout();
            groupBoxResult_CAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutFile_CAI).BeginInit();
            SuspendLayout();
            // 
            // panelTop_CAI
            // 
            panelTop_CAI.Controls.Add(buttonHelp_CAI);
            panelTop_CAI.Controls.Add(buttonSaveFile_CAI);
            panelTop_CAI.Controls.Add(buttonDone_CAI);
            panelTop_CAI.Controls.Add(groupBoxTask_CAI);
            panelTop_CAI.Controls.Add(splitterTop);
            panelTop_CAI.Controls.Add(buttonOpenFile_CAI);
            panelTop_CAI.Dock = DockStyle.Top;
            panelTop_CAI.Location = new Point(0, 0);
            panelTop_CAI.Name = "panelTop_CAI";
            panelTop_CAI.Size = new Size(1058, 209);
            panelTop_CAI.TabIndex = 0;
            // 
            // buttonHelp_CAI
            // 
            buttonHelp_CAI.FlatStyle = FlatStyle.Flat;
            buttonHelp_CAI.Image = (Image)resources.GetObject("buttonHelp_CAI.Image");
            buttonHelp_CAI.Location = new Point(949, 18);
            buttonHelp_CAI.Name = "buttonHelp_CAI";
            buttonHelp_CAI.Size = new Size(88, 72);
            buttonHelp_CAI.TabIndex = 5;
            toolTipButton.SetToolTip(buttonHelp_CAI, "Сведение о программе");
            buttonHelp_CAI.UseVisualStyleBackColor = true;
            buttonHelp_CAI.Click += buttonHelp_CAI_Click;
            buttonHelp_CAI.MouseEnter += buttonHelp_CAI_MouseEnter;
            // 
            // buttonSaveFile_CAI
            // 
            buttonSaveFile_CAI.Enabled = false;
            buttonSaveFile_CAI.FlatStyle = FlatStyle.Flat;
            buttonSaveFile_CAI.Image = (Image)resources.GetObject("buttonSaveFile_CAI.Image");
            buttonSaveFile_CAI.Location = new Point(271, 12);
            buttonSaveFile_CAI.Name = "buttonSaveFile_CAI";
            buttonSaveFile_CAI.Size = new Size(124, 78);
            buttonSaveFile_CAI.TabIndex = 4;
            toolTipButton.SetToolTip(buttonSaveFile_CAI, "Сохранить обработанные данные в формате CVS");
            buttonSaveFile_CAI.UseVisualStyleBackColor = true;
            buttonSaveFile_CAI.Click += buttonSaveFile_CAI_Click;
            buttonSaveFile_CAI.MouseEnter += buttonSaveFile_CAI_MouseEnter;
            // 
            // buttonDone_CAI
            // 
            buttonDone_CAI.Enabled = false;
            buttonDone_CAI.FlatStyle = FlatStyle.Flat;
            buttonDone_CAI.Image = (Image)resources.GetObject("buttonDone_CAI.Image");
            buttonDone_CAI.Location = new Point(142, 12);
            buttonDone_CAI.Name = "buttonDone_CAI";
            buttonDone_CAI.Size = new Size(123, 78);
            buttonDone_CAI.TabIndex = 3;
            toolTipButton.SetToolTip(buttonDone_CAI, "Выполнить обработку данных");
            buttonDone_CAI.UseVisualStyleBackColor = true;
            buttonDone_CAI.Click += buttonDone_CAI_Click;
            buttonDone_CAI.MouseEnter += buttonDone_CAI_MouseEnter;
            // 
            // groupBoxTask_CAI
            // 
            groupBoxTask_CAI.Controls.Add(textBox1);
            groupBoxTask_CAI.Dock = DockStyle.Bottom;
            groupBoxTask_CAI.Location = new Point(4, 109);
            groupBoxTask_CAI.Name = "groupBoxTask_CAI";
            groupBoxTask_CAI.Size = new Size(1054, 100);
            groupBoxTask_CAI.TabIndex = 2;
            groupBoxTask_CAI.TabStop = false;
            groupBoxTask_CAI.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(9, 26);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(1033, 68);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // splitterTop
            // 
            splitterTop.Location = new Point(0, 0);
            splitterTop.Name = "splitterTop";
            splitterTop.Size = new Size(4, 209);
            splitterTop.TabIndex = 1;
            splitterTop.TabStop = false;
            // 
            // buttonOpenFile_CAI
            // 
            buttonOpenFile_CAI.Image = (Image)resources.GetObject("buttonOpenFile_CAI.Image");
            buttonOpenFile_CAI.Location = new Point(13, 12);
            buttonOpenFile_CAI.Name = "buttonOpenFile_CAI";
            buttonOpenFile_CAI.Size = new Size(123, 78);
            buttonOpenFile_CAI.TabIndex = 0;
            toolTipButton.SetToolTip(buttonOpenFile_CAI, "Открыть  файл для обработки данных в формате cvs\r\n\r\n\r\n");
            buttonOpenFile_CAI.UseVisualStyleBackColor = true;
            buttonOpenFile_CAI.Click += buttonOpenFile_CAI_Click;
            buttonOpenFile_CAI.MouseEnter += buttonOpenFile_CAI_MouseEnter;
            // 
            // panelLeft_CAI
            // 
            panelLeft_CAI.Controls.Add(groupBoxInFile_CAI);
            panelLeft_CAI.Controls.Add(splitterBottom);
            panelLeft_CAI.Dock = DockStyle.Left;
            panelLeft_CAI.Location = new Point(0, 209);
            panelLeft_CAI.Name = "panelLeft_CAI";
            panelLeft_CAI.Padding = new Padding(5);
            panelLeft_CAI.Size = new Size(502, 403);
            panelLeft_CAI.TabIndex = 1;
            // 
            // groupBoxInFile_CAI
            // 
            groupBoxInFile_CAI.Controls.Add(dataGridViewInFile_CAI);
            groupBoxInFile_CAI.Dock = DockStyle.Fill;
            groupBoxInFile_CAI.Location = new Point(13, 5);
            groupBoxInFile_CAI.Name = "groupBoxInFile_CAI";
            groupBoxInFile_CAI.Padding = new Padding(5);
            groupBoxInFile_CAI.Size = new Size(484, 393);
            groupBoxInFile_CAI.TabIndex = 0;
            groupBoxInFile_CAI.TabStop = false;
            groupBoxInFile_CAI.Text = "Ввод";
            // 
            // dataGridViewInFile_CAI
            // 
            dataGridViewInFile_CAI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInFile_CAI.ColumnHeadersVisible = false;
            dataGridViewInFile_CAI.Dock = DockStyle.Fill;
            dataGridViewInFile_CAI.Location = new Point(5, 25);
            dataGridViewInFile_CAI.Name = "dataGridViewInFile_CAI";
            dataGridViewInFile_CAI.RowHeadersVisible = false;
            dataGridViewInFile_CAI.RowHeadersWidth = 51;
            dataGridViewInFile_CAI.Size = new Size(474, 363);
            dataGridViewInFile_CAI.TabIndex = 0;
            // 
            // splitterBottom
            // 
            splitterBottom.Location = new Point(5, 5);
            splitterBottom.Name = "splitterBottom";
            splitterBottom.Size = new Size(8, 393);
            splitterBottom.TabIndex = 0;
            splitterBottom.TabStop = false;
            // 
            // panelRight_CAI
            // 
            panelRight_CAI.Controls.Add(groupBoxResult_CAI);
            panelRight_CAI.Dock = DockStyle.Fill;
            panelRight_CAI.Location = new Point(502, 209);
            panelRight_CAI.Name = "panelRight_CAI";
            panelRight_CAI.Padding = new Padding(5);
            panelRight_CAI.Size = new Size(556, 403);
            panelRight_CAI.TabIndex = 2;
            // 
            // groupBoxResult_CAI
            // 
            groupBoxResult_CAI.Controls.Add(dataGridViewOutFile_CAI);
            groupBoxResult_CAI.Dock = DockStyle.Fill;
            groupBoxResult_CAI.Location = new Point(5, 5);
            groupBoxResult_CAI.Name = "groupBoxResult_CAI";
            groupBoxResult_CAI.Padding = new Padding(5);
            groupBoxResult_CAI.Size = new Size(546, 393);
            groupBoxResult_CAI.TabIndex = 1;
            groupBoxResult_CAI.TabStop = false;
            groupBoxResult_CAI.Text = "Вывод";
            // 
            // dataGridViewOutFile_CAI
            // 
            dataGridViewOutFile_CAI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutFile_CAI.ColumnHeadersVisible = false;
            dataGridViewOutFile_CAI.Dock = DockStyle.Fill;
            dataGridViewOutFile_CAI.Location = new Point(5, 25);
            dataGridViewOutFile_CAI.Name = "dataGridViewOutFile_CAI";
            dataGridViewOutFile_CAI.RowHeadersVisible = false;
            dataGridViewOutFile_CAI.RowHeadersWidth = 51;
            dataGridViewOutFile_CAI.Size = new Size(536, 363);
            dataGridViewOutFile_CAI.TabIndex = 0;
            // 
            // openFileDialogTask_CAI
            // 
            openFileDialogTask_CAI.FileName = "openFileDialog1";
            // 
            // toolTipButton
            // 
            toolTipButton.IsBalloon = true;
            toolTipButton.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 612);
            Controls.Add(panelRight_CAI);
            Controls.Add(panelLeft_CAI);
            Controls.Add(panelTop_CAI);
            MinimumSize = new Size(800, 450);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 22 | Четвертных А. И.";
            panelTop_CAI.ResumeLayout(false);
            groupBoxTask_CAI.ResumeLayout(false);
            groupBoxTask_CAI.PerformLayout();
            panelLeft_CAI.ResumeLayout(false);
            groupBoxInFile_CAI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInFile_CAI).EndInit();
            panelRight_CAI.ResumeLayout(false);
            groupBoxResult_CAI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutFile_CAI).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_CAI;
        private Button buttonOpenFile_CAI;
        private Panel panelLeft_CAI;
        private Panel panelRight_CAI;
        private GroupBox groupBoxInFile_CAI;
        private GroupBox groupBoxResult_CAI;
        private DataGridView dataGridViewInFile_CAI;
        private DataGridView dataGridViewOutFile_CAI;
        private Splitter splitterTop;
        private Splitter splitterBottom;
        private GroupBox groupBoxTask_CAI;
        private TextBox textBox1;
        private Button buttonDone_CAI;
        private Button buttonHelp_CAI;
        private Button buttonSaveFile_CAI;
        private OpenFileDialog openFileDialogTask_CAI;
        private ToolTip toolTipButton;
        private SaveFileDialog saveFileDialogTask_CAI;
        private SaveFileDialog saveFileDialogMatrix_CAI;
    }
}
