namespace Tyuiu.ChetvertnyhAI.Sprint6.Task7.V22
{
    partial class FormAboutTask_CAI
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
            textBoxInfo_CAI = new TextBox();
            buttonOK_CAI = new Button();
            SuspendLayout();
            // 
            // textBoxInfo_CAI
            // 
            textBoxInfo_CAI.BorderStyle = BorderStyle.None;
            textBoxInfo_CAI.Location = new Point(12, 30);
            textBoxInfo_CAI.Multiline = true;
            textBoxInfo_CAI.Name = "textBoxInfo_CAI";
            textBoxInfo_CAI.ReadOnly = true;
            textBoxInfo_CAI.Size = new Size(597, 52);
            textBoxInfo_CAI.TabIndex = 0;
            textBoxInfo_CAI.Text = " Таск 7 выполнила студентка группы ИСТНб-25-1 Четвертных Арина Игоревна";
            // 
            // buttonOK_CAI
            // 
            buttonOK_CAI.Location = new Point(483, 152);
            buttonOK_CAI.Name = "buttonOK_CAI";
            buttonOK_CAI.Size = new Size(115, 37);
            buttonOK_CAI.TabIndex = 1;
            buttonOK_CAI.Text = "OK";
            buttonOK_CAI.UseVisualStyleBackColor = true;
            buttonOK_CAI.Click += buttonOK_CAI_Click;
            // 
            // FormAboutTask_CAI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 211);
            Controls.Add(buttonOK_CAI);
            Controls.Add(textBoxInfo_CAI);
            Name = "FormAboutTask_CAI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInfo_CAI;
        private Button buttonOK_CAI;
    }
}