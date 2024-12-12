using Tyuiu.PlatonovaPE.Sprint6.Task6.V26.Lib;
using System.IO;

namespace Tyuiu.PlatonovaPE.Sprint6.Task6.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void buttonOpen_PPE_Click(object sender, EventArgs e)
        {
            openFileDialogTask_PPE.ShowDialog();
            openFilePath = openFileDialogTask_PPE.FileName;
            textBoxInPut_PPE.Text = File.ReadAllText(openFilePath);
            groupBoxOutPut_PPE.Text = groupBoxOutPut_PPE.Text + " " + openFileDialogTask_PPE.FileName;
            buttonDoIt_PPE.Enabled = true;
        }

        private void buttonDoIt_PPE_Click(object sender, EventArgs e)
        {
            textBoxOutPut_PPE.Text = ds.CollectTextFromFile(openFilePath);
        }


        private void panelInPut_PPE_Paint(object sender, PaintEventArgs e)
        {
            //
        }

        private void textBoxInPut_PPE_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonHelp_PPE_Click(object sender, EventArgs e)
        {
            FormAbout.formAbout = new FormAbout();
            FormAbout.ShowDialog();
        }
    }
}