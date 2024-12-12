namespace Tyuiu.PlatonovaPE.Sprint6.Task6.V26
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBoxTask_PPE = new GroupBox();
            textBoxTask_PPE = new TextBox();
            panelInPut_PPE = new Panel();
            groupBoxInPut_PPE = new GroupBox();
            textBoxInPut_PPE = new TextBox();
            panelTask_PPE = new Panel();
            buttonHelp_PPE = new Button();
            buttonDoIt_PPE = new Button();
            buttonOpen_PPE = new Button();
            panelOutPut_PPE = new Panel();
            groupBoxOutPut_PPE = new GroupBox();
            textBoxOutPut_PPE = new TextBox();
            openFileDialogTask_PPE = new OpenFileDialog();
            toolTip_PPE = new ToolTip(components);
            groupBoxTask_PPE.SuspendLayout();
            panelInPut_PPE.SuspendLayout();
            groupBoxInPut_PPE.SuspendLayout();
            panelTask_PPE.SuspendLayout();
            panelOutPut_PPE.SuspendLayout();
            groupBoxOutPut_PPE.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_PPE
            // 
            groupBoxTask_PPE.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxTask_PPE.Controls.Add(textBoxTask_PPE);
            groupBoxTask_PPE.Location = new Point(16, 115);
            groupBoxTask_PPE.Margin = new Padding(4, 5, 4, 5);
            groupBoxTask_PPE.Name = "groupBoxTask_PPE";
            groupBoxTask_PPE.Padding = new Padding(4, 5, 4, 5);
            groupBoxTask_PPE.Size = new Size(1147, 128);
            groupBoxTask_PPE.TabIndex = 0;
            groupBoxTask_PPE.TabStop = false;
            groupBoxTask_PPE.Text = "Условие:";
            // 
            // textBoxTask_PPE
            // 
            textBoxTask_PPE.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxTask_PPE.BackColor = SystemColors.Control;
            textBoxTask_PPE.BorderStyle = BorderStyle.None;
            textBoxTask_PPE.Location = new Point(13, 31);
            textBoxTask_PPE.Margin = new Padding(4, 5, 4, 5);
            textBoxTask_PPE.Multiline = true;
            textBoxTask_PPE.Name = "textBoxTask_PPE";
            textBoxTask_PPE.ReadOnly = true;
            textBoxTask_PPE.Size = new Size(1125, 88);
            textBoxTask_PPE.TabIndex = 0;
            textBoxTask_PPE.TabStop = false;
            // 
            // panelInPut_PPE
            // 
            panelInPut_PPE.Controls.Add(groupBoxInPut_PPE);
            panelInPut_PPE.Dock = DockStyle.Fill;
            panelInPut_PPE.Location = new Point(0, 252);
            panelInPut_PPE.Margin = new Padding(4, 5, 4, 5);
            panelInPut_PPE.Name = "panelInPut_PPE";
            panelInPut_PPE.Size = new Size(1179, 534);
            panelInPut_PPE.TabIndex = 1;
            panelInPut_PPE.Paint += panelInPut_PPE_Paint;
            // 
            // groupBoxInPut_PPE
            // 
            groupBoxInPut_PPE.Controls.Add(textBoxInPut_PPE);
            groupBoxInPut_PPE.Dock = DockStyle.Left;
            groupBoxInPut_PPE.Location = new Point(0, 0);
            groupBoxInPut_PPE.Margin = new Padding(4, 5, 4, 5);
            groupBoxInPut_PPE.Name = "groupBoxInPut_PPE";
            groupBoxInPut_PPE.Padding = new Padding(4, 5, 4, 5);
            groupBoxInPut_PPE.Size = new Size(563, 534);
            groupBoxInPut_PPE.TabIndex = 0;
            groupBoxInPut_PPE.TabStop = false;
            groupBoxInPut_PPE.Text = "Ввод:";
            // 
            // textBoxInPut_PPE
            // 
            textBoxInPut_PPE.Dock = DockStyle.Fill;
            textBoxInPut_PPE.Location = new Point(4, 25);
            textBoxInPut_PPE.Margin = new Padding(4, 5, 4, 5);
            textBoxInPut_PPE.Multiline = true;
            textBoxInPut_PPE.Name = "textBoxInPut_PPE";
            textBoxInPut_PPE.ReadOnly = true;
            textBoxInPut_PPE.ScrollBars = ScrollBars.Vertical;
            textBoxInPut_PPE.Size = new Size(555, 504);
            textBoxInPut_PPE.TabIndex = 0;
            textBoxInPut_PPE.TextChanged += textBoxInPut_PPE_TextChanged;
            // 
            // panelTask_PPE
            // 
            panelTask_PPE.Controls.Add(buttonHelp_PPE);
            panelTask_PPE.Controls.Add(buttonDoIt_PPE);
            panelTask_PPE.Controls.Add(buttonOpen_PPE);
            panelTask_PPE.Dock = DockStyle.Top;
            panelTask_PPE.Location = new Point(0, 0);
            panelTask_PPE.Margin = new Padding(4, 5, 4, 5);
            panelTask_PPE.Name = "panelTask_PPE";
            panelTask_PPE.Size = new Size(1179, 252);
            panelTask_PPE.TabIndex = 2;
            // 
            // buttonHelp_PPE
            // 
            buttonHelp_PPE.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_PPE.Location = new Point(1077, 18);
            buttonHelp_PPE.Margin = new Padding(4, 5, 4, 5);
            buttonHelp_PPE.Name = "buttonHelp_PPE";
            buttonHelp_PPE.Size = new Size(97, 86);
            buttonHelp_PPE.TabIndex = 0;
            toolTip_PPE.SetToolTip(buttonHelp_PPE, "Сведения о программе");
            buttonHelp_PPE.UseVisualStyleBackColor = true;
            buttonHelp_PPE.Click += buttonHelp_PPE_Click;
            // 
            // buttonDoIt_PPE
            // 
            buttonDoIt_PPE.Location = new Point(121, 18);
            buttonDoIt_PPE.Margin = new Padding(4, 5, 4, 5);
            buttonDoIt_PPE.Name = "buttonDoIt_PPE";
            buttonDoIt_PPE.Size = new Size(97, 86);
            buttonDoIt_PPE.TabIndex = 0;
            toolTip_PPE.SetToolTip(buttonDoIt_PPE, "Производит поиск и возвращает последнее слово в строке");
            buttonDoIt_PPE.UseVisualStyleBackColor = true;
            buttonDoIt_PPE.Click += buttonDoIt_PPE_Click;
            // 
            // buttonOpen_PPE
            // 
            buttonOpen_PPE.Location = new Point(16, 18);
            buttonOpen_PPE.Margin = new Padding(4, 5, 4, 5);
            buttonOpen_PPE.Name = "buttonOpen_PPE";
            buttonOpen_PPE.Size = new Size(97, 86);
            buttonOpen_PPE.TabIndex = 0;
            toolTip_PPE.SetToolTip(buttonOpen_PPE, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonOpen_PPE.UseVisualStyleBackColor = true;
            buttonOpen_PPE.Click += buttonOpen_PPE_Click;
            // 
            // panelOutPut_PPE
            // 
            panelOutPut_PPE.Controls.Add(groupBoxOutPut_PPE);
            panelOutPut_PPE.Dock = DockStyle.Right;
            panelOutPut_PPE.Location = new Point(576, 252);
            panelOutPut_PPE.Margin = new Padding(4, 5, 4, 5);
            panelOutPut_PPE.Name = "panelOutPut_PPE";
            panelOutPut_PPE.Size = new Size(603, 534);
            panelOutPut_PPE.TabIndex = 1;
            // 
            // groupBoxOutPut_PPE
            // 
            groupBoxOutPut_PPE.Controls.Add(textBoxOutPut_PPE);
            groupBoxOutPut_PPE.Dock = DockStyle.Right;
            groupBoxOutPut_PPE.Location = new Point(4, 0);
            groupBoxOutPut_PPE.Margin = new Padding(4, 5, 4, 5);
            groupBoxOutPut_PPE.Name = "groupBoxOutPut_PPE";
            groupBoxOutPut_PPE.Padding = new Padding(4, 5, 4, 5);
            groupBoxOutPut_PPE.Size = new Size(599, 534);
            groupBoxOutPut_PPE.TabIndex = 0;
            groupBoxOutPut_PPE.TabStop = false;
            groupBoxOutPut_PPE.Text = "Вывод:";
            // 
            // textBoxOutPut_PPE
            // 
            textBoxOutPut_PPE.Dock = DockStyle.Fill;
            textBoxOutPut_PPE.Location = new Point(4, 25);
            textBoxOutPut_PPE.Margin = new Padding(4, 5, 4, 5);
            textBoxOutPut_PPE.Multiline = true;
            textBoxOutPut_PPE.Name = "textBoxOutPut_PPE";
            textBoxOutPut_PPE.ReadOnly = true;
            textBoxOutPut_PPE.ScrollBars = ScrollBars.Vertical;
            textBoxOutPut_PPE.Size = new Size(591, 504);
            textBoxOutPut_PPE.TabIndex = 0;
            // 
            // openFileDialogTask_PPE
            // 
            openFileDialogTask_PPE.FileName = "openFileDialogTask_PPE";
            // 
            // toolTip_PPE
            // 
            toolTip_PPE.ToolTipIcon = ToolTipIcon.Info;
            toolTip_PPE.ToolTipTitle = "Подсказда";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 786);
            Controls.Add(panelOutPut_PPE);
            Controls.Add(panelInPut_PPE);
            Controls.Add(groupBoxTask_PPE);
            Controls.Add(panelTask_PPE);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1194, 821);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 26 | Платонова П.Е.";
            groupBoxTask_PPE.ResumeLayout(false);
            groupBoxTask_PPE.PerformLayout();
            panelInPut_PPE.ResumeLayout(false);
            groupBoxInPut_PPE.ResumeLayout(false);
            groupBoxInPut_PPE.PerformLayout();
            panelTask_PPE.ResumeLayout(false);
            panelOutPut_PPE.ResumeLayout(false);
            groupBoxOutPut_PPE.ResumeLayout(false);
            groupBoxOutPut_PPE.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_PPE;
        private System.Windows.Forms.TextBox textBoxTask_PPE;
        private System.Windows.Forms.Panel panelInPut_PPE;
        private System.Windows.Forms.GroupBox groupBoxInPut_PPE;
        private System.Windows.Forms.TextBox textBoxInPut_PPE;
        private System.Windows.Forms.Panel panelTask_PPE;
        private System.Windows.Forms.Button buttonHelp_PPE;
        private System.Windows.Forms.Button buttonDoIt_PPE;
        private System.Windows.Forms.Button buttonOpen_PPE;
        private System.Windows.Forms.Panel panelOutPut_PPE;
        private System.Windows.Forms.GroupBox groupBoxOutPut_PPE;
        private System.Windows.Forms.TextBox textBoxOutPut_PPE;
        private System.Windows.Forms.ToolTip toolTip_PPE;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_PPE;
    }
}