﻿using System.Windows.Forms.VisualStyles;
using Tyuiu.PlatonovaPE.Sprint6.Task2.V3.Lib;
namespace Tyuiu.PlatonovaPE.Sprint6.Task2.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart.Text);
                int stopStep = Convert.ToInt32(textBoxStop.Text);
                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] array = new double[len];
                array = ds.GetMassFunction(startStep, stopStep);
                this.chartResult.Titles.Add("Ãðàôèê ôóíêöèè F(x)");
                this.chartResult.ChartAreas[0].AxisX.Title = "Îñü Õ";
                this.chartResult.ChartAreas[0].AxisY.Title = "Îñü Y";
                for (int i = 0; i < len - 1; i++)
                {
                    this.dataGridView1.Rows.Add(Convert.ToString(startStep), Convert.ToString(array[i]));
                    this.chartResult.Series[0].Points.AddXY(startStep, array[i]);
                    startStep++;
                }
            }
            catch { MessageBox.Show("Ââåäåíû íåâåðíûå äàííûå", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonhelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Òàñê 0 âûïîëíèë  ñòóäåíò ãðóïïû ÀÑÎèÓÁ-24-1 Êîìàðîâà Ìàðãàðèòà Âàñèëüåâíà", "Ñîîáùåíèå", MessageBoxButtons.OK);
        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.Red;
        }

        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.Blue;
        }

        private void buttonDone_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone.BackColor = Color.Green;
        }
    }
}