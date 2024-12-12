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
            SuspendLayout();
            // 
            // groupBoxOutPutData_PPE
            // 
            groupBoxOutPutData_PPE.Controls.Add(dataGridViewOutMatrix_PPE);
            groupBoxOutPutData_PPE.Controls.Add(dataGridViewInMatrix_PPE);
            groupBoxOutPutData_PPE.Dock = DockStyle.Bottom;
            groupBoxOutPutData_PPE.Location = new Point(0, 236);
            groupBoxOutPutData_PPE.Margin = new Padding(3, 4, 3, 4);
            groupBoxOutPutData_PPE.Name = "groupBoxOutPutData_PPE";
            groupBoxOutPutData_PPE.Padding = new Padding(3, 4, 3, 4);
            groupBoxOutPutData_PPE.Size = new Size(981, 469);
            groupBoxOutPutData_PPE.TabIndex = 5;
            groupBoxOutPutData_PPE.TabStop = false;
            // 
            // dataGridViewOutMatrix_PPE
            // 
            dataGridViewOutMatrix_PPE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutMatrix_PPE.Location = new Point(467, 29);
            dataGridViewOutMatrix_PPE.Margin = new Padding(3, 4, 3, 4);
            dataGridViewOutMatrix_PPE.Name = "dataGridViewOutMatrix_PPE";
            dataGridViewOutMatrix_PPE.RowHeadersWidth = 51;
            dataGridViewOutMatrix_PPE.Size = new Size(497, 419);
            dataGridViewOutMatrix_PPE.TabIndex = 1;
            dataGridViewOutMatrix_PPE.CellContentClick += dataGridViewOutMatrix_PPE_CellContentClick;
            // 
            // dataGridViewInMatrix_PPE
            // 
            dataGridViewInMatrix_PPE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInMatrix_PPE.Location = new Point(17, 29);
            dataGridViewInMatrix_PPE.Margin = new Padding(3, 4, 3, 4);
            dataGridViewInMatrix_PPE.Name = "dataGridViewInMatrix_PPE";
            dataGridViewInMatrix_PPE.RowHeadersWidth = 51;
            dataGridViewInMatrix_PPE.Size = new Size(425, 419);
            dataGridViewInMatrix_PPE.TabIndex = 0;
            // 
            // groupBoxTask_PPE
            // 
            groupBoxTask_PPE.Controls.Add(textBoxTask_PPE);
            groupBoxTask_PPE.Location = new Point(7, 141);
            groupBoxTask_PPE.Margin = new Padding(3, 4, 3, 4);
            groupBoxTask_PPE.Name = "groupBoxTask_PPE";
            groupBoxTask_PPE.Padding = new Padding(3, 4, 3, 4);
            groupBoxTask_PPE.Size = new Size(943, 96);
            groupBoxTask_PPE.TabIndex = 4;
            groupBoxTask_PPE.TabStop = false;
            groupBoxTask_PPE.Text = "Условие";
            // 
            // textBoxTask_PPE
            // 
            textBoxTask_PPE.BackColor = SystemColors.Control;
            textBoxTask_PPE.Dock = DockStyle.Fill;
            textBoxTask_PPE.Location = new Point(3, 24);
            textBoxTask_PPE.Margin = new Padding(3, 4, 3, 4);
            textBoxTask_PPE.Multiline = true;
            textBoxTask_PPE.Name = "textBoxTask_PPE";
            textBoxTask_PPE.ReadOnly = true;
            textBoxTask_PPE.Size = new Size(937, 68);
            textBoxTask_PPE.TabIndex = 0;
            // 
            // groupBoxMenu_PPE
            // 
            groupBoxMenu_PPE.Controls.Add(buttonSaveFile_PPE);
            groupBoxMenu_PPE.Controls.Add(buttonHelp_PPE);
            groupBoxMenu_PPE.Controls.Add(buttonDone_PPE);
            groupBoxMenu_PPE.Controls.Add(buttonOpenFile_PPE);
            groupBoxMenu_PPE.Dock = DockStyle.Top;
            groupBoxMenu_PPE.Location = new Point(0, 0);
            groupBoxMenu_PPE.Margin = new Padding(3, 4, 3, 4);
            groupBoxMenu_PPE.Name = "groupBoxMenu_PPE";
            groupBoxMenu_PPE.Padding = new Padding(3, 4, 3, 4);
            groupBoxMenu_PPE.Size = new Size(981, 133);
            groupBoxMenu_PPE.TabIndex = 3;
            groupBoxMenu_PPE.TabStop = false;
            // 
            // buttonSaveFile_PPE
            // 
            buttonSaveFile_PPE.Enabled = false;
            buttonSaveFile_PPE.Location = new Point(210, 29);
            buttonSaveFile_PPE.Margin = new Padding(3, 4, 3, 4);
            buttonSaveFile_PPE.Name = "buttonSaveFile_PPE";
            buttonSaveFile_PPE.Size = new Size(101, 83);
            buttonSaveFile_PPE.TabIndex = 3;
            buttonSaveFile_PPE.Text = "Сохранить";
            buttonSaveFile_PPE.UseVisualStyleBackColor = true;
            buttonSaveFile_PPE.Click += buttonSaveFile_Click;
            // 
            // buttonHelp_PPE
            // 
            buttonHelp_PPE.Location = new Point(888, 29);
            buttonHelp_PPE.Margin = new Padding(3, 4, 3, 4);
            buttonHelp_PPE.Name = "buttonHelp_PPE";
            buttonHelp_PPE.Size = new Size(86, 83);
            buttonHelp_PPE.TabIndex = 2;
            buttonHelp_PPE.Text = "Справка";
            buttonHelp_PPE.UseVisualStyleBackColor = true;
            buttonHelp_PPE.Click += buttonHelp_PPE_Click;
            // 
            // buttonDone_PPE
            // 
            buttonDone_PPE.Enabled = false;
            buttonDone_PPE.Location = new Point(106, 29);
            buttonDone_PPE.Margin = new Padding(3, 4, 3, 4);
            buttonDone_PPE.Name = "buttonDone_PPE";
            buttonDone_PPE.Size = new Size(97, 83);
            buttonDone_PPE.TabIndex = 1;
            buttonDone_PPE.Text = "Выполнить";
            buttonDone_PPE.UseVisualStyleBackColor = true;
            buttonDone_PPE.Click += buttonDone_Click;
            // 
            // buttonOpenFile_PPE
            // 
            buttonOpenFile_PPE.Location = new Point(7, 29);
            buttonOpenFile_PPE.Margin = new Padding(3, 4, 3, 4);
            buttonOpenFile_PPE.Name = "buttonOpenFile_PPE";
            buttonOpenFile_PPE.Size = new Size(93, 83);
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 705);
            Controls.Add(groupBoxOutPutData_PPE);
            Controls.Add(groupBoxTask_PPE);
            Controls.Add(groupBoxMenu_PPE);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
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