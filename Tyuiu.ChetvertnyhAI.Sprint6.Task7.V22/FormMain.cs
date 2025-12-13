using Tyuiu.ChetvertnyhAI.Sprint6.Task7.V22.Lib;
namespace Tyuiu.ChetvertnyhAI.Sprint6.Task7.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

        }
        DataService ds = new DataService();
        static string openFilePath;
        static int rows;
        static int columns;


        public static int[,] LoadFromFileData(string FilePath)
        {
            string fileData = File.ReadAllText(FilePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return arrayValues;
        }



        private void buttonOpenFile_CAI_Click(object sender, EventArgs e)
        {
            openFileDialogTask_CAI.ShowDialog();
            openFilePath = openFileDialogTask_CAI.FileName;

            int[,] arrayValues = LoadFromFileData(openFilePath);
            dataGridViewInFile_CAI.ColumnCount = columns;
            dataGridViewInFile_CAI.RowCount = rows;
            dataGridViewOutFile_CAI.ColumnCount = columns;
            dataGridViewOutFile_CAI.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInFile_CAI.Columns[i].Width = 40;
                dataGridViewOutFile_CAI.Columns[i].Width = 40;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInFile_CAI.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_CAI.Enabled = true;
        }



        private void buttonHelp_CAI_Click(object sender, EventArgs e)
        {
            FormAboutTask_CAI formAbout = new FormAboutTask_CAI();
            formAbout.ShowDialog();
        }



        private void buttonDone_CAI_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOutFile_CAI.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            buttonSaveFile_CAI.Enabled = true;
        }



        private void buttonSaveFile_CAI_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_CAI.FileName = "OutPutFileTask7V22.csv";
            saveFileDialogMatrix_CAI.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_CAI.ShowDialog();

            string path = saveFileDialogMatrix_CAI.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutFile_CAI.RowCount;
            int columns = dataGridViewOutFile_CAI.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutFile_CAI.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutFile_CAI.Rows[i].Cells[j].Value;
                    }
                }

                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInFile_CAI.ColumnCount = 60;
            dataGridViewOutFile_CAI.ColumnCount = 60;
            dataGridViewInFile_CAI.RowCount = 60;
            dataGridViewOutFile_CAI.RowCount = 60;
            for (int i = 0; i < 50; i++)
            {
                dataGridViewInFile_CAI.Columns[i].Width = 40;
                dataGridViewOutFile_CAI.Columns[i].Width = 40;
            }
        }


        private void buttonOpenFile_CAI_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_CAI_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_CAI_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_CAI_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Справка";
        }
    }

}
