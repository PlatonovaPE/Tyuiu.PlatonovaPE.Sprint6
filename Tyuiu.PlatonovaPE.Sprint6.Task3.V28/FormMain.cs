using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.PlatonovaPE.Sprint6.Task3.V28.Lib;
namespace Tyuiu.PlatonovaPE.Sprint6.Task3.V28
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { -9, 8, 9, 16, -18 },
                                      { -13, -11, -20, -15, 9 },
                                      { 18, 13, -12, -15, -11 },
                                      { 10, -2, 19, -4, -10 },
                                      { 6, -20, -4, 13, -14} };

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_VAA_Click(object sender, EventArgs e)
        {
            int[,] res = ds.Calculate(mtrx);

            int rows = res.GetUpperBound(0) + 1;
            int columns = res.Length / rows;

            dataGridViewRes_VAA.ColumnCount = columns;
            dataGridViewRes_VAA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewRes_VAA.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewRes_VAA.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }

        private void buttonHelp_VAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнина студентка группы ИИПб-23-2 Варова Ангелина Александровна", "Сообщение", MessageBoxButtons.OK);
        }

        private void groupBoxTask_VAA_Enter(object sender, EventArgs e)
        {
            //
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewMatrix_VAA.ColumnCount = columns;
            dataGridViewMatrix_VAA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_VAA.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_VAA.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void dataGridViewRes_VAA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }
    }
}