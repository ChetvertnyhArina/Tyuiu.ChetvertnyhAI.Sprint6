using Tyuiu.ChetvertnyhAI.Sprint6.Task5.V3.Lib;
namespace Tyuiu.ChetvertnyhAI.Sprint6.Task5.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\ТИУ\DataSprint6\InPutDataFileTask5V3.txt";

        private void buttonDone_CAI_Click(object sender, EventArgs e)
        {
            dataGridViewResult_CAI.ColumnCount = 2;
            dataGridViewResult_CAI.Columns[0].Width = 20;
            dataGridViewResult_CAI.Columns[1].Width = 50;

            this.chartFunction_CAI.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction_CAI.ChartAreas[0].AxisY.Title = "Ось Y";

            chartFunction_CAI.Series[0].Points.Clear();
            dataGridViewResult_CAI.Rows.Clear();

            double[] numsMass = ds.LoadFromDataFile(path);

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {

                dataGridViewResult_CAI.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartFunction_CAI.Series[0].Points.AddXY(i, numsMass[i]);
            }

        }


        private void buttonOpen_CAI_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }


        private void buttonHelp_CAI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы ИСТНб-25-1 Четвертных Арина Игоревна", "Сообщение", MessageBoxButtons.OK);
        }

    }
}
