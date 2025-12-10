using System.Windows.Forms;
using Tyuiu.ChetvertnyhAI.Sprint6.Task2.V6.Lib;
namespace Tyuiu.ChetvertnyhAI.Sprint6.Task2.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }


        DataService ds = new DataService();
        private void buttonDone_CAI_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStart_CAI.Text);
                int stopValue = Convert.ToInt32(textBoxStop_CAI.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;
                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(startValue, stopValue);

                this.chartFunction_CAI.Titles.Add("График функции F(x)");
                this.chartFunction_CAI.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunction_CAI.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_CAI.Rows.Add(Convert.ToString(startValue), Convert.ToString(valueArray[i]));
                    this.chartFunction_CAI.Series[0].Points.AddXY(startValue, valueArray[i]);
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonHelp_CAI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студентка группы ИСТНб-25-1 Четвертных Арина Игоревна", "Сообщение", MessageBoxButtons.OK);
        }

    }
}
