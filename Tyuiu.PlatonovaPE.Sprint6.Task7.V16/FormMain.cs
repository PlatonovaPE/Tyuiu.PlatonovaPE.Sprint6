using System.IO;
using Tyuiu.PlatonovaPE.Sprint6.Task7.V16.Lib;

using Tyuiu.PlatonovaPE.Sprint6.Task7.V16.Lib;

namespace Tyuiu.PlatonovaPE.Sprint6.Task7.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_PPE.Filter = "Çíà÷åíèÿ ðàçäåë¸ííûå çàïÿòûìè (*.csv)|*.csv|Âñå ôàéëû(*.*)|*.*";
            saveFileDialogMatrix_PPE.Filter = "Çíà÷åíèÿ ðàçäåë¸ííûå çàïÿòûìè (*.csv)|*.csv|Âñå ôàéëû(*.*)|*.*";
        }

        int rows;
        int columns;
        static string openFilePath;

        DataService ds = new DataService();

        public int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace("\n", "\r");
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }

            return arrayValues;
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_PPE.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_PPE.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_PPE.ShowDialog();

            string path = saveFileDialogMatrix_PPE.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutMatrix_PPE.RowCount;
            int columns = dataGridViewOutMatrix_PPE.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutMatrix_PPE.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutMatrix_PPE.Rows[i].Cells[j].Value;
                    }
                }

                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] arraysValues = new int[rows, columns];
            arraysValues = ds.GetMatrix(openFilePath);

            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < columns; y++)
                {
                    try
                    {
                        dataGridViewOutMatrix_PPE.Rows[x].Cells[y].Value = arraysValues[x, y];
                    }
                    catch
                    {
                        MessageBox.Show($": {rows} {x}, : {columns} {y}", "", MessageBoxButtons.OK);
                    }
                }
            }

            buttonSaveFile_PPE.Enabled = true;
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask_PPE.ShowDialog();
            openFilePath = openFileDialogTask_PPE.FileName;

            rows = 10;
            columns = 10;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInMatrix_PPE.ColumnCount = columns;
            dataGridViewInMatrix_PPE.RowCount = rows;
            dataGridViewOutMatrix_PPE.ColumnCount = columns;
            dataGridViewOutMatrix_PPE.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInMatrix_PPE.Columns[i].Width = 25;
                dataGridViewOutMatrix_PPE.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInMatrix_PPE.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_PPE.Enabled = true;
        }

        private void FromMain_Load(object sender, EventArgs e)
        {
            dataGridViewInMatrix_PPE.ColumnCount = 50;
            dataGridViewInMatrix_PPE.RowCount = 50;
            dataGridViewOutMatrix_PPE.ColumnCount = 50;
            dataGridViewOutMatrix_PPE.ColumnCount = 50;

            //panelLeft.Width = this.Width / 2;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewInMatrix_PPE.Columns[i].Width = 25;
                dataGridViewOutMatrix_PPE.Columns[i].Width = 25;
            }
        }

        private void dataGridViewOutMatrix_PPE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonHelp_PPE_Click(object sender, EventArgs e)
        {
            FormAbout.formAbout = new FormAbout();
            FormAbout.ShowDialog();
        }
    }
}