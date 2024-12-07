using Tyuiu.PlatonovaPE.Sprint6.Task0.V5.Lib;

namespace Tyuiu.PlatonovaPE.Sprint6.Task0.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonResult_MSM_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxOutputEnd_MSM.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxInputEnd_MSM.Text)));
            }
            catch
            {
                MessageBox.Show("Ââåäåíû íåâåðíûå äàííûå", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxInputEnd_MSM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8)) e.Handled = true;
        }
        private void buttonHelp_MSM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Òàñê 0 âûïîëíèë ñòóäåíò ãðóïïû ÀÑÎèÓá-24-1 Ìîðîçîâ Ñåðãåé Ìàêñèìîâè÷", "Ñïðàâêà");
        }

    }
}