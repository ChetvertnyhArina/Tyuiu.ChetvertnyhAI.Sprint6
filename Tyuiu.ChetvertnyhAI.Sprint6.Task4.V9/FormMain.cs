using System.Windows.Forms;
using Tyuiu.ChetvertnyhAI.Sprint6.Task4.V9.Lib;
namespace Tyuiu.ChetvertnyhAI.Sprint6.Task4.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonDone_CAI_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartV_CAI.Text);
                int stopStep = Convert.ToInt32(textBoxStopV_CAI.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_CAI.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_CAI.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_CAI.Text = "";
                chartFunction_CAI.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_CAI.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_CAI.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void buttonSave_CAI_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask4V9.txt");
                File.WriteAllText(path, textBoxResult_CAI.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно! Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonHelp_CAI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студентка группы ИСТНб-25-1 Четвертных Арина Игоревна", "Сообщение", MessageBoxButtons.OK);
        }
    }
}
