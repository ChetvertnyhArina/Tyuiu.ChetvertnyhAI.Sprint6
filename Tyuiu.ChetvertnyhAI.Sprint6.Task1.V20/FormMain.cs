using System.Windows.Forms;
using Tyuiu.ChetvertnyhAI.Sprint6.Task1.V20.Lib;
namespace Tyuiu.ChetvertnyhAI.Sprint6.Task1.V20
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
                int startValue = Convert.ToInt32(textBoxStartV_CAI.Text);
                int stopValue = Convert.ToInt32(textBoxStopV_CAI.Text);

                string strLine;

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);
                textBoxResult_CAI.Text = "";
                textBoxResult_CAI.AppendText("+-----------+-----------+" + Environment.NewLine);
                textBoxResult_CAI.AppendText("+     x     |    f(x)   +" + Environment.NewLine);
                textBoxResult_CAI.AppendText("+-----------+-----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,6:d}     |  {1,6:f2}   | ", startValue, valueArray[i]);
                    textBoxResult_CAI.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }
                textBoxResult_CAI.AppendText("+-----------+-----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonHelp_CAI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы ИСТНб-25-1 Четвертных Арина Игоревна", "Сообщение", MessageBoxButtons.OK);
        }
    }
}
