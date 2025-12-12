using System.IO;
using System.Windows.Forms;
using Tyuiu.ChetvertnyhAI.Sprint6.Task6.V13.Lib;
namespace Tyuiu.ChetvertnyhAI.Sprint6.Task6.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openFilePath;

        private void buttonDone_CAI_Click(object sender, EventArgs e)
        {
            textBoxOutFile_CAI.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_CAI_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }


        private void ButtonOpenFile_CAI_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogTask_CAI.ShowDialog();
                openFilePath = openFileDialogTask_CAI.FileName;
                textBoxInFile_CAI.Text = File.ReadAllText(openFilePath);
                groupBoxIn_CAI.Text = groupBoxIn_CAI.Text + " " + openFilePath;
                buttonDone_CAI.Enabled = true;
            }
            catch
            {
                MessageBox.Show("¬ведены неверные данные", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
