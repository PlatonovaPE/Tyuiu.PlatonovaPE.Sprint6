using Tyuiu.PlatonovaPE.Sprint6.Task4.V16.Lib;
namespace Tyuiu.PlatonovaPE.Sprint6.Task4.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int startValue = Convert.ToInt32(textboxST.Text);
                int stopValue = Convert.ToInt32(textboxEND.Text);
                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(startValue, stopValue);
                TextBoxIn.Text = "";

              

            }
            catch (FormatException)
            {
                MessageBox.Show("Ïîæàëóéñòà, ââåäèòå êîððåêòíîå öåëîå ÷èñëî.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ïðîèçîøëà îøèáêà: {ex.Message}");
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask4V16.txt" });
                File.WriteAllText(path, TextBoxIn.Text);

                DialogResult dialogResult = MessageBox.Show("Ôàéë\n" + path + " ñîõðàíåí óñïåøíî!\nÎòêðûòü åãî â áëîêíîòå?", "Ñîîáùåíèå", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Cáîé ïðè ñîõðàíèè ôàéëà", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task 4 âûïîëíèëà ñòóäåíò ãðóïïû ÏÊÒÁ-24-1 Êîðîáåéíèêîâà Äàðüÿ Äåíèñîâíà", "Cîîáùåíèå", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void Tablica_TextChanged(object sender, EventArgs e)
        {

        }
    }
}