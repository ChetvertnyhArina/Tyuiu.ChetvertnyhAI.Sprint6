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
            textBoxVarX_CAI = new TextBox();
            groupBoxVar_CAI = new GroupBox();
            textBoxOne_CAI = new TextBox();
            groupBoxResult_CAI = new GroupBox();
            textBoxTwo_CAI = new TextBox();
            textBoxResult_CAI = new TextBox();
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
            groupBoxTask_CAI.Location = new Point(12, 26);
            groupBoxTask_CAI.Name = "groupBoxTask_CAI";
            groupBoxTask_CAI.Size = new Size(776, 242);
            groupBoxTask_CAI.TabIndex = 0;
            groupBoxTask_CAI.TabStop = false;
            groupBoxTask_CAI.Text = "Условие ";
            groupBoxTask_CAI.UseWaitCursor = true;
            groupBoxTask_CAI.Enter += groupBox1_Enter;
            // 
            // pictureBoxFormula
            // 
            pictureBoxFormula.BackColor = SystemColors.ControlLightLight;
            pictureBoxFormula.Image = (Image)resources.GetObject("pictureBoxFormula.Image");
            pictureBoxFormula.Location = new Point(425, 37);
            pictureBoxFormula.Name = "pictureBoxFormula";
            pictureBoxFormula.Size = new Size(325, 67);
            pictureBoxFormula.TabIndex = 6;
            pictureBoxFormula.TabStop = false;
            pictureBoxFormula.UseWaitCursor = true;
            pictureBoxFormula.Click += pictureBoxFormula_Click;
            // 
            // textBoxTask_CAI
            // 
            textBoxTask_CAI.BackColor = SystemColors.Control;
            textBoxTask_CAI.BorderStyle = BorderStyle.None;
            textBoxTask_CAI.Cursor = Cursors.IBeam;
            textBoxTask_CAI.Location = new Point(23, 37);
            textBoxTask_CAI.Multiline = true;
            textBoxTask_CAI.Name = "textBoxTask_CAI";
            textBoxTask_CAI.ReadOnly = true;
            textBoxTask_CAI.Size = new Size(410, 167);
            textBoxTask_CAI.TabIndex = 5;
            textBoxTask_CAI.Text = "Вычислить выражение по формуле";
            textBoxTask_CAI.UseWaitCursor = true;
            // 
            // textBoxVarX_CAI
            // 
            textBoxVarX_CAI.Location = new Point(23, 73);
            textBoxVarX_CAI.Name = "textBoxVarX_CAI";
            textBoxVarX_CAI.Size = new Size(125, 27);
            textBoxVarX_CAI.TabIndex = 1;
            textBoxVarX_CAI.KeyPress += textBoxVarX_KeyPress;
            // 
            // groupBoxVar_CAI
            // 
            groupBoxVar_CAI.Controls.Add(textBoxOne_CAI);
            groupBoxVar_CAI.Controls.Add(textBoxVarX_CAI);
            groupBoxVar_CAI.Location = new Point(12, 274);
            groupBoxVar_CAI.Name = "groupBoxVar_CAI";
            groupBoxVar_CAI.Size = new Size(448, 112);
            groupBoxVar_CAI.TabIndex = 0;
            groupBoxVar_CAI.TabStop = false;
            groupBoxVar_CAI.Text = "Ввод данных";
            // 
            // textBoxOne_CAI
            // 
            textBoxOne_CAI.BackColor = SystemColors.Control;
            textBoxOne_CAI.BorderStyle = BorderStyle.None;
            textBoxOne_CAI.Location = new Point(23, 36);
            textBoxOne_CAI.Name = "textBoxOne_CAI";
            textBoxOne_CAI.Size = new Size(125, 20);
            textBoxOne_CAI.TabIndex = 2;
            textBoxOne_CAI.Text = "Переменная X:";
            textBoxOne_CAI.TextChanged += textBox1_TextChanged;
            // 
            // groupBoxResult_CAI
            // 
            groupBoxResult_CAI.Controls.Add(textBoxTwo_CAI);
            groupBoxResult_CAI.Controls.Add(textBoxResult_CAI);
            groupBoxResult_CAI.Location = new Point(503, 274);
            groupBoxResult_CAI.Name = "groupBoxResult_CAI";
            groupBoxResult_CAI.Size = new Size(285, 112);
            groupBoxResult_CAI.TabIndex = 3;
            groupBoxResult_CAI.TabStop = false;
            groupBoxResult_CAI.Text = "Вывод данных:";
            groupBoxResult_CAI.Enter += groupBoxResult_CAI_Enter;
            // 
            // textBoxTwo_CAI
            // 
            textBoxTwo_CAI.BackColor = SystemColors.Control;
            textBoxTwo_CAI.BorderStyle = BorderStyle.None;
            textBoxTwo_CAI.Location = new Point(23, 36);
            textBoxTwo_CAI.Name = "textBoxTwo_CAI";
            textBoxTwo_CAI.Size = new Size(125, 20);
            textBoxTwo_CAI.TabIndex = 1;
            textBoxTwo_CAI.Text = "Результат:";
            // 
            // textBoxResult_CAI
            // 
            textBoxResult_CAI.BackColor = SystemColors.Window;
            textBoxResult_CAI.Location = new Point(23, 67);
            textBoxResult_CAI.Name = "textBoxResult_CAI";
            textBoxResult_CAI.ReadOnly = true;
            textBoxResult_CAI.Size = new Size(125, 27);
            textBoxResult_CAI.TabIndex = 0;
            textBoxResult_CAI.TextChanged += textBoxResult_CAI_TextChanged;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = SystemColors.Control;
            buttonDone.Location = new Point(616, 392);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(172, 46);
            buttonDone.TabIndex = 4;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Location = new Point(563, 392);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(47, 46);
            buttonHelp.TabIndex = 5;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxResult_CAI);
            Controls.Add(groupBoxTask_CAI);
            Controls.Add(groupBoxVar_CAI);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
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
        private TextBox textBoxVarX_CAI;
        private TextBox textBoxTask_CAI;
        private PictureBox pictureBoxFormula;
        private GroupBox groupBoxVar_CAI;
        private TextBox textBoxOne_CAI;
        private GroupBox groupBoxResult_CAI;
        private TextBox textBoxTwo_CAI;
        private TextBox textBoxResult_CAI;
        private Button buttonDone;
        private Button buttonHelp;
    }
}
