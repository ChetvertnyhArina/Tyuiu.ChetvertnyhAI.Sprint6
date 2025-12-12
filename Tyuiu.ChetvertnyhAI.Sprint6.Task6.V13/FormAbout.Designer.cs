namespace Tyuiu.ChetvertnyhAI.Sprint6.Task6.V13
{
    partial class FormAbout
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
            textBoxInfo = new TextBox();
            buttonOK_CAI = new Button();
            SuspendLayout();
            // 
            // textBoxInfo
            // 
            textBoxInfo.BackColor = SystemColors.Control;
            textBoxInfo.BorderStyle = BorderStyle.None;
            textBoxInfo.Location = new Point(12, 12);
            textBoxInfo.Multiline = true;
            textBoxInfo.Name = "textBoxInfo";
            textBoxInfo.ReadOnly = true;
            textBoxInfo.Size = new Size(592, 120);
            textBoxInfo.TabIndex = 0;
            textBoxInfo.Text = "Таск 6 выполнила студентка группы ИСТНб-25-1 Четвертных Арина Игоревна";
            // 
            // buttonOK_CAI
            // 
            buttonOK_CAI.Location = new Point(498, 155);
            buttonOK_CAI.Name = "buttonOK_CAI";
            buttonOK_CAI.Size = new Size(94, 29);
            buttonOK_CAI.TabIndex = 1;
            buttonOK_CAI.Text = "OK";
            buttonOK_CAI.UseVisualStyleBackColor = true;
            buttonOK_CAI.Click += buttonOK_CAI_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 196);
            Controls.Add(buttonOK_CAI);
            Controls.Add(textBoxInfo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            Load += FormAbout_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInfo;
        private Button buttonOK_CAI;
    }
}