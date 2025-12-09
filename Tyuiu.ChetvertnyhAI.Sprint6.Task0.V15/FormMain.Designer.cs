namespace Tyuiu.ChetvertnyhAI.Sprint6.Task0.V15
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxTask_CAI = new GroupBox();
            pictureBoxFormula = new PictureBox();
            textBoxTask_CAI = new TextBox();
            groupBoxVar_CAI = new GroupBox();
            textBoxVarX_CAI = new TextBox();
            textBoxOne_CAI = new TextBox();
            groupBoxResult_CAI = new GroupBox();
            textBoxResult_CAI = new TextBox();
            textBoxTwo_CAI = new TextBox();
            buttonDone = new Button();
            buttonHelp = new Button();
            groupBoxTask_CAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).BeginInit();
            groupBoxVar_CAI.SuspendLayout();
            groupBoxResult_CAI.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_CAI
            // 
            groupBoxTask_CAI.Controls.Add(pictureBoxFormula);
            groupBoxTask_CAI.Controls.Add(textBoxTask_CAI);
            groupBoxTask_CAI.Location = new Point(12, 12);
            groupBoxTask_CAI.Name = "groupBoxTask_CAI";
            groupBoxTask_CAI.Size = new Size(776, 158);
            groupBoxTask_CAI.TabIndex = 0;
            groupBoxTask_CAI.TabStop = false;
            groupBoxTask_CAI.Text = "Условие";
            // 
            // pictureBoxFormula
            // 
            pictureBoxFormula.BackColor = SystemColors.Window;
            pictureBoxFormula.Image = (Image)resources.GetObject("pictureBoxFormula.Image");
            pictureBoxFormula.Location = new Point(435, 26);
            pictureBoxFormula.Name = "pictureBoxFormula";
            pictureBoxFormula.Size = new Size(319, 47);
            pictureBoxFormula.TabIndex = 1;
            pictureBoxFormula.TabStop = false;
            // 
            // textBoxTask_CAI
            // 
            textBoxTask_CAI.BackColor = SystemColors.Control;
            textBoxTask_CAI.BorderStyle = BorderStyle.None;
            textBoxTask_CAI.Location = new Point(6, 27);
            textBoxTask_CAI.Multiline = true;
            textBoxTask_CAI.Name = "textBoxTask_CAI";
            textBoxTask_CAI.Size = new Size(413, 46);
            textBoxTask_CAI.TabIndex = 0;
            textBoxTask_CAI.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxVar_CAI
            // 
            groupBoxVar_CAI.Controls.Add(textBoxVarX_CAI);
            groupBoxVar_CAI.Controls.Add(textBoxOne_CAI);
            groupBoxVar_CAI.Location = new Point(12, 176);
            groupBoxVar_CAI.Name = "groupBoxVar_CAI";
            groupBoxVar_CAI.Size = new Size(334, 119);
            groupBoxVar_CAI.TabIndex = 1;
            groupBoxVar_CAI.TabStop = false;
            groupBoxVar_CAI.Text = "Ввод данных";
            // 
            // textBoxVarX_CAI
            // 
            textBoxVarX_CAI.Location = new Point(15, 68);
            textBoxVarX_CAI.Name = "textBoxVarX_CAI";
            textBoxVarX_CAI.Size = new Size(125, 27);
            textBoxVarX_CAI.TabIndex = 2;
            textBoxVarX_CAI.KeyPress += textBoxVarX_CAI_KeyPress;
            // 
            // textBoxOne_CAI
            // 
            textBoxOne_CAI.BackColor = SystemColors.Control;
            textBoxOne_CAI.BorderStyle = BorderStyle.None;
            textBoxOne_CAI.Location = new Point(15, 42);
            textBoxOne_CAI.Name = "textBoxOne_CAI";
            textBoxOne_CAI.Size = new Size(125, 20);
            textBoxOne_CAI.TabIndex = 2;
            textBoxOne_CAI.Text = "Переменная X:";
            // 
            // groupBoxResult_CAI
            // 
            groupBoxResult_CAI.Controls.Add(textBoxResult_CAI);
            groupBoxResult_CAI.Controls.Add(textBoxTwo_CAI);
            groupBoxResult_CAI.Location = new Point(381, 176);
            groupBoxResult_CAI.Name = "groupBoxResult_CAI";
            groupBoxResult_CAI.Size = new Size(407, 119);
            groupBoxResult_CAI.TabIndex = 2;
            groupBoxResult_CAI.TabStop = false;
            groupBoxResult_CAI.Text = "Вывод данных";
            // 
            // textBoxResult_CAI
            // 
            textBoxResult_CAI.BackColor = SystemColors.Window;
            textBoxResult_CAI.Location = new Point(17, 68);
            textBoxResult_CAI.Name = "textBoxResult_CAI";
            textBoxResult_CAI.ReadOnly = true;
            textBoxResult_CAI.Size = new Size(125, 27);
            textBoxResult_CAI.TabIndex = 1;
            // 
            // textBoxTwo_CAI
            // 
            textBoxTwo_CAI.BackColor = SystemColors.Control;
            textBoxTwo_CAI.BorderStyle = BorderStyle.None;
            textBoxTwo_CAI.Location = new Point(17, 42);
            textBoxTwo_CAI.Name = "textBoxTwo_CAI";
            textBoxTwo_CAI.Size = new Size(125, 20);
            textBoxTwo_CAI.TabIndex = 0;
            textBoxTwo_CAI.Text = "Результат:";
            // 
            // buttonDone
            // 
            buttonDone.BackColor = SystemColors.Window;
            buttonDone.Location = new Point(585, 376);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(192, 51);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_CAI_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Location = new Point(516, 376);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(46, 51);
            buttonHelp.TabIndex = 4;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
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
            Controls.Add(groupBoxVar_CAI);
            Controls.Add(groupBoxTask_CAI);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 15 | Четвертных А. И.";
            Load += FormMain_Load;
            groupBoxTask_CAI.ResumeLayout(false);
            groupBoxTask_CAI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).EndInit();
            groupBoxVar_CAI.ResumeLayout(false);
            groupBoxVar_CAI.PerformLayout();
            groupBoxResult_CAI.ResumeLayout(false);
            groupBoxResult_CAI.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_CAI;
        private PictureBox pictureBoxFormula;
        private TextBox textBoxTask_CAI;
        private GroupBox groupBoxVar_CAI;
        private TextBox textBoxOne_CAI;
        private TextBox textBoxVarX_CAI;
        private GroupBox groupBoxResult_CAI;
        private TextBox textBoxTwo_CAI;
        private TextBox textBoxResult_CAI;
        private Button buttonDone;
        private Button buttonHelp;
    }
}
