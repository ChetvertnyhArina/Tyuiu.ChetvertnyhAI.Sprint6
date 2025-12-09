using System.Windows.Forms;
using Tyuiu.ChetvertnyhAI.Sprint6.Task0.V15.Lib;
namespace Tyuiu.ChetvertnyhAI.Sprint6.Task0.V15
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


        private void buttonDone_CAI_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_CAI.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_CAI.Text)));

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonHelp_CAI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студентка группы ИСТНб-25-1 Четвертных Арина Игоревна", "Сообщение", MessageBoxButtons.OK);
        }

        private void textBoxVarX_CAI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
}
