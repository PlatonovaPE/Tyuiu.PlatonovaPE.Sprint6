namespace Tyuiu.PlatonovaPE.Sprint6.Task4.V16
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            
            TextBoxIn = new TextBox();
            textboxST = new TextBox();
            textboxEND = new TextBox();
            buttonDone = new Button();
            buttonSave = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            buttonInfo = new Button();
            groupBox3 = new GroupBox();
           
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
          
            // 
            // TextBoxIn
            // 
            TextBoxIn.Dock = DockStyle.Fill;
            TextBoxIn.Location = new Point(3, 23);
            TextBoxIn.Multiline = true;
            TextBoxIn.Name = "TextBoxIn";
            TextBoxIn.ScrollBars = ScrollBars.Vertical;
            TextBoxIn.Size = new Size(427, 483);
            TextBoxIn.TabIndex = 1;
            TextBoxIn.TextChanged += Tablica_TextChanged;
            // 
            // textboxST
            // 
            textboxST.Location = new Point(6, 56);
            textboxST.Name = "textboxST";
            textboxST.Size = new Size(174, 27);
            textboxST.TabIndex = 2;
            // 
            // textboxEND
            // 
            textboxEND.Location = new Point(186, 56);
            textboxEND.Name = "textboxEND";
            textboxEND.Size = new Size(164, 27);
            textboxEND.TabIndex = 3;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.FromArgb(0, 192, 0);
            buttonDone.ForeColor = SystemColors.ControlText;
            buttonDone.Location = new Point(969, 18);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(131, 83);
            buttonDone.TabIndex = 4;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(0, 192, 192);
            buttonSave.Location = new Point(1099, 18);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(125, 83);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(28, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(544, 95);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 23);
            label3.Name = "label3";
            label3.Size = new Size(526, 60);
            label3.TabIndex = 0;
            label3.Text = "Протабулировать функцию на заданном диапазоне от -5 до 5.\r\nРезультат вывести в textBox, построить график функции и сохранить файл\r\nOutPutFileTask4V16.txt по нажатию кнопки.\r\n";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textboxST);
            groupBox2.Controls.Add(textboxEND);
            groupBox2.Location = new Point(578, 18);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(385, 95);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 33);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 5;
            label2.Text = "Конец шага";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 33);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 4;
            label1.Text = "Старт шага:";
            // 
            // buttonInfo
            // 
            buttonInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInfo.BackColor = Color.LightSeaGreen;
            buttonInfo.Location = new Point(1224, 18);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(125, 83);
            buttonInfo.TabIndex = 8;
            buttonInfo.Text = "Справка";
            buttonInfo.UseVisualStyleBackColor = false;
            buttonInfo.Click += buttonHelp_Click;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(TextBoxIn);
            groupBox3.Location = new Point(28, 119);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(433, 509);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 653);
            Controls.Add(groupBox3);
            Controls.Add(buttonInfo);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(buttonSave);
            Controls.Add(buttonDone);
            
            MinimumSize = new Size(1400, 700);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 4 | Вариант 16 | Коробейникова Д.Д.";
            Load += FormMain_Load;
          ;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

       
        private TextBox TextBoxIn;
        private TextBox textboxST;
        private TextBox textboxEND;
        private Button buttonDone;
        private Button buttonSave;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button buttonInfo;
        private GroupBox groupBox3;
        private Label label2;
        private Label label1;
        private Label label3;
    }
}