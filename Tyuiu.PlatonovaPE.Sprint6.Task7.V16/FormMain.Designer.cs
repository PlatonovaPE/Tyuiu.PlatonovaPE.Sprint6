namespace Tyuiu.PlatonovaPE.Sprint6.Task7.V16
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
       

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxOutPutData_PPE = new GroupBox();
            dataGridViewOutMatrix_PPE = new DataGridView();
            dataGridViewInMatrix_PPE = new DataGridView();
            groupBoxTask_PPE = new GroupBox();
            textBoxTask_PPE = new TextBox();
            groupBoxMenu_PPE = new GroupBox();
            buttonSaveFile_PPE = new Button();
            buttonHelp_PPE = new Button();
            buttonDone_PPE = new Button();
            buttonOpenFile_PPE = new Button();
            openFileDialogTask_PPE = new OpenFileDialog();
            toolTip_PPE = new ToolTip(components);
            saveFileDialogMatrix_PPE = new SaveFileDialog();
            groupBoxOutPutData_PPE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix_PPE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix_PPE).BeginInit();
            groupBoxTask_PPE.SuspendLayout();
            groupBoxMenu_PPE.SuspendLayout();
            
            // 
            // groupBoxOutPutData_PPE
            // 
            groupBoxOutPutData_PPE.Controls.Add(dataGridViewOutMatrix_PPE);
            groupBoxOutPutData_PPE.Controls.Add(dataGridViewInMatrix_PPE);
            groupBoxOutPutData_PPE.Dock = DockStyle.Bottom;
            groupBoxOutPutData_PPE.Location = new Point(0, 177);
            groupBoxOutPutData_PPE.Name = "groupBoxOutPutData_PPE";
            groupBoxOutPutData_PPE.Size = new Size(858, 352);
            groupBoxOutPutData_PPE.TabIndex = 5;
            groupBoxOutPutData_PPE.TabStop = false;
            // 
            // dataGridViewOutMatrix_PPE
            // 
            dataGridViewOutMatrix_PPE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutMatrix_PPE.Location = new Point(409, 22);
            dataGridViewOutMatrix_PPE.Name = "dataGridViewOutMatrix_PPE";
            dataGridViewOutMatrix_PPE.Size = new Size(435, 314);
            dataGridViewOutMatrix_PPE.TabIndex = 1;
            // 
            // dataGridViewInMatrix_PPE
            // 
            dataGridViewInMatrix_PPE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInMatrix_PPE.Location = new Point(15, 22);
            dataGridViewInMatrix_PPE.Name = "dataGridViewInMatrix_PPE";
            dataGridViewInMatrix_PPE.Size = new Size(372, 314);
            dataGridViewInMatrix_PPE.TabIndex = 0;
            // 
            // groupBoxTask_PPE
            // 
            groupBoxTask_PPE.Controls.Add(textBoxTask_PPE);
            groupBoxTask_PPE.Location = new Point(6, 106);
            groupBoxTask_PPE.Name = "groupBoxTask_PPE";
            groupBoxTask_PPE.Size = new Size(825, 72);
            groupBoxTask_PPE.TabIndex = 4;
            groupBoxTask_PPE.TabStop = false;
            groupBoxTask_PPE.Text = "Условие";
            // 
            // textBoxTask_PPE
            // 
            textBoxTask_PPE.BackColor = SystemColors.Control;
            textBoxTask_PPE.Dock = DockStyle.Fill;
            textBoxTask_PPE.Location = new Point(3, 19);
            textBoxTask_PPE.Multiline = true;
            textBoxTask_PPE.Name = "textBoxTask_PPE";
            textBoxTask_PPE.ReadOnly = true;
            textBoxTask_PPE.Size = new Size(819, 50);
            textBoxTask_PPE.TabIndex = 0;
            textBoxTask_PPE.Text = resources.GetString("textBoxTask_PPE.Text");
            // 
            // groupBoxMenu_PPE
            // 
            groupBoxMenu_PPE.Controls.Add(buttonSaveFile_PPE);
            groupBoxMenu_PPE.Controls.Add(buttonHelp_PPE);
            groupBoxMenu_PPE.Controls.Add(buttonDone_PPE);
            groupBoxMenu_PPE.Controls.Add(buttonOpenFile_PPE);
            groupBoxMenu_PPE.Dock = DockStyle.Top;
            groupBoxMenu_PPE.Location = new Point(0, 0);
            groupBoxMenu_PPE.Name = "groupBoxMenu_PPE";
            groupBoxMenu_PPE.Size = new Size(858, 100);
            groupBoxMenu_PPE.TabIndex = 3;
            groupBoxMenu_PPE.TabStop = false;
            // 
            // buttonSaveFile_PPE
            // 
            buttonSaveFile_PPE.Enabled = false;
            buttonSaveFile_PPE.Location = new Point(184, 22);
            buttonSaveFile_PPE.Name = "buttonSaveFile_PPE";
            buttonSaveFile_PPE.Size = new Size(88, 62);
            buttonSaveFile_PPE.TabIndex = 3;
            buttonSaveFile_PPE.Text = "Сохранить";
            buttonSaveFile_PPE.UseVisualStyleBackColor = true;
            buttonSaveFile_PPE.Click += buttonSaveFile_Click;
            // 
            // buttonHelp_PPE
            // 
            buttonHelp_PPE.Location = new Point(777, 22);
            buttonHelp_PPE.Name = "buttonHelp_PPE";
            buttonHelp_PPE.Size = new Size(75, 62);
            buttonHelp_PPE.TabIndex = 2;
            buttonHelp_PPE.Text = "Справка";
            buttonHelp_PPE.UseVisualStyleBackColor = true;
           
            // 
            // buttonDone_PPE
            // 
            buttonDone_PPE.Enabled = false;
            buttonDone_PPE.Location = new Point(93, 22);
            buttonDone_PPE.Name = "buttonDone_PPE";
            buttonDone_PPE.Size = new Size(85, 62);
            buttonDone_PPE.TabIndex = 1;
            buttonDone_PPE.Text = "Выполнить";
            buttonDone_PPE.UseVisualStyleBackColor = true;
            buttonDone_PPE.Click += buttonDone_Click;
            // 
            // buttonOpenFile_PPE
            // 
            buttonOpenFile_PPE.Location = new Point(6, 22);
            buttonOpenFile_PPE.Name = "buttonOpenFile_PPE";
            buttonOpenFile_PPE.Size = new Size(81, 62);
            buttonOpenFile_PPE.TabIndex = 0;
            buttonOpenFile_PPE.Text = "Загрузить";
            buttonOpenFile_PPE.UseVisualStyleBackColor = true;
            buttonOpenFile_PPE.Click += buttonOpenFile_Click;
            // 
            // openFileDialogTask_PPE
            // 
            openFileDialogTask_PPE.FileName = "openFileDialogTask_PPE";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 529);
            Controls.Add(groupBoxOutPutData_PPE);
            Controls.Add(groupBoxTask_PPE);
            Controls.Add(groupBoxMenu_PPE);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 16 | Платонова П.У.";
            groupBoxOutPutData_PPE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix_PPE).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix_PPE).EndInit();
            groupBoxTask_PPE.ResumeLayout(false);
            groupBoxTask_PPE.PerformLayout();
            groupBoxMenu_PPE.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxOutPutData_PPE;
        private GroupBox groupBoxTask_PPE;
        private TextBox textBoxTask_PPE;
        private GroupBox groupBoxMenu_PPE;
        private Button buttonHelp_PPE;
        private Button buttonDone_PPE;
        private Button buttonOpenFile_PPE;
        private OpenFileDialog openFileDialogTask_PPE;
        private ToolTip toolTip_PPE;
        private DataGridView dataGridViewOutMatrix_PPE;
        private DataGridView dataGridViewInMatrix_PPE;
        private SaveFileDialog saveFileDialogMatrix_PPE;
        private Button buttonSaveFile_PPE;
    }
}