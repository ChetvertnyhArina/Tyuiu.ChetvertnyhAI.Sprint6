using System.Windows.Forms;
using Tyuiu.ChetvertnyhAI.Sprint6.Task3.V5.Lib;
namespace Tyuiu.ChetvertnyhAI.Sprint6.Task3.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] mtrx = new int[,] { { 30, -20, 7, -8, 9 }, { 32, 17, -14, -7, 33 },
                { 19, -19, -13, 14, -20}, { 11, 30, -1, 26, 6 }, { 30, -15, -20, -5, 15 } };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows; 

            dataGridViewMatrix_CAI.ColumnCount = columns;
            dataGridViewMatrix_CAI.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_CAI.Columns[i].Width = 40;
            }

            for (int i = 0;i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_CAI.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }


        private void buttonDone_CAI_Click(object sender, EventArgs e)
        {

            int[,] result = ds.Calculate(mtrx);
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.GetUpperBound(1) + 1;
            dataGridViewResultMatrix_CAI.RowCount = rows;
            dataGridViewResultMatrix_CAI.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResultMatrix_CAI.Columns[i].Width = 40;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResultMatrix_CAI.Rows[i].Cells[j].Value = Convert.ToString(result[i, j]);
                }

            }

        }


        private void buttonHelp_CAI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы ИСТНб-25-1 Четвертных Арина Игоревна", "Сообщение", MessageBoxButtons.OK);
        }
    }
}
