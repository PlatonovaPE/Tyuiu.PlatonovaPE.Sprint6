namespace Tyuiu.PlatonovaPE.Sprint6.Task0.V5
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
            buttonHelp_PPE = new Button();
            buttonResult_PPE = new Button();
            groupBoxTask_PPE = new GroupBox();
            textBoxTask_PPE = new TextBox();
            pictureBoxFarmula_PPE = new PictureBox();
            groupBoxInput_PPE = new GroupBox();
            textBoxInputEnd_PPE = new TextBox();
            textBoxInputStart_PPE = new TextBox();
            groupBoxOutput_PPE = new GroupBox();
            textBoxOutputEnd_PPE = new TextBox();
            textBoxOutpunStart_PPE = new TextBox();
            groupBoxTask_PPE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFarmula_PPE).BeginInit();
            groupBoxInput_PPE.SuspendLayout();
            groupBoxOutput_PPE.SuspendLayout();
            SuspendLayout();
            // 
            // buttonHelp_MSM
            // 
            buttonHelp_PPE.FlatStyle = FlatStyle.Flat;
            buttonHelp_PPE.Font = new Font("Segoe UI", 14F);
            buttonHelp_PPE.Location = new Point(656, 520);
            buttonHelp_PPE.Margin = new Padding(3, 4, 3, 4);
            buttonHelp_PPE.Name = "buttonHelp_MSM";
            buttonHelp_PPE.Size = new Size(57, 67);
            buttonHelp_PPE.TabIndex = 0;
            buttonHelp_PPE.Text = "?";
            buttonHelp_PPE.UseVisualStyleBackColor = true;
            buttonHelp_PPE.Click += buttonHelp_PPE_Click;
            // 
            // buttonResult_MSM
            // 
            buttonResult_PPE.BackColor = SystemColors.Control;
            buttonResult_PPE.Location = new Point(720, 520);
            buttonResult_PPE.Margin = new Padding(3, 4, 3, 4);
            buttonResult_PPE.Name = "buttonResult_MSM";
            buttonResult_PPE.Size = new Size(181, 64);
            buttonResult_PPE.TabIndex = 1;
            buttonResult_PPE.Text = "Выполнить";
            buttonResult_PPE.UseVisualStyleBackColor = false;
            buttonResult_PPE.Click += buttonResult_PPE_Click;
            // 
            // groupBoxTask_MSM
            // 
            groupBoxTask_PPE.Controls.Add(textBoxTask_MSM);
            groupBoxTask_PPE.Controls.Add(pictureBoxFarmula_MSM);
            groupBoxTask_PPE.Location = new Point(14, 16);
            groupBoxTask_PPE.Margin = new Padding(3, 4, 3, 4);
            groupBoxTask_PPE.Name = "groupBoxTask_MSM";
            groupBoxTask_PPE.Padding = new Padding(3, 4, 3, 4);
            groupBoxTask_PPE.Size = new Size(887, 351);
            groupBoxTask_PPE.TabIndex = 2;
            groupBoxTask_PPE.TabStop = false;
            groupBoxTask_PPE.Text = "Условие";
            // 
            // textBoxTask_MSM
            // 
            textBoxTask_PPE.BackColor = SystemColors.Control;
            textBoxTask_PPE.BorderStyle = BorderStyle.None;
            textBoxTask_PPE.Location = new Point(7, 29);
            textBoxTask_PPE.Margin = new Padding(3, 4, 3, 4);
            textBoxTask_PPE.Multiline = true;
            textBoxTask_PPE.Name = "textBoxTask_PPE";
            textBoxTask_PPE.ReadOnly = true;
            textBoxTask_PPE.Size = new Size(527, 313);
            textBoxTask_PPE.TabIndex = 1;
            textBoxTask_PPE.Text = "Вычислить выражение по формуле";
            // 
            // pictureBoxFarmula_MSM
            // 
            pictureBoxFarmula_PPE.BackColor = SystemColors.Window;
            pictureBoxFarmula_PPE.Location = new Point(541, 29);
            pictureBoxFarmula_PPE.Margin = new Padding(3, 4, 3, 4);
            pictureBoxFarmula_PPE.Name = "pictureBoxFarmula_PPE";
            pictureBoxFarmula_PPE.Size = new Size(339, 52);
            pictureBoxFarmula_PPE.TabIndex = 0;
            pictureBoxFarmula_PPE.TabStop = false;
            pictureBoxFarmula_PPE.Click += this.pictureBoxFarmula_PPE_Click;
            // 
            // groupBoxInput_MSM
            // 
            groupBoxInput_PPE.Controls.Add(textBoxInputEnd_PPE);
            groupBoxInput_PPE.Controls.Add(textBoxInputStart_PPE);
            groupBoxInput_PPE.Location = new Point(14, 375);
            groupBoxInput_PPE.Margin = new Padding(3, 4, 3, 4);
            groupBoxInput_PPE.Name = "groupBoxInput_MSM";
            groupBoxInput_PPE.Padding = new Padding(3, 4, 3, 4);
            groupBoxInput_PPE.Size = new Size(638, 127);
            groupBoxInput_PPE.TabIndex = 3;
            groupBoxInput_PPE.TabStop = false;
            groupBoxInput_PPE.Text = "Ввод данных:";
            // 
            // textBoxInputEnd_MSM
            // 
            textBoxInputEnd_PPE.Font = new Font("Segoe UI", 16F);
            textBoxInputEnd_PPE.Location = new Point(7, 68);
            textBoxInputEnd_PPE.Margin = new Padding(3, 4, 3, 4);
            textBoxInputEnd_PPE.Name = "textBoxInputEnd_PPE";
            textBoxInputEnd_PPE.Size = new Size(623, 43);
            textBoxInputEnd_PPE.TabIndex = 1;
            textBoxInputEnd_PPE.KeyPress += textBoxInputEnd_MSM_KeyPress;
            // 
            // textBoxInputStart_MSM
            // 
            textBoxInputStart_PPE.BackColor = SystemColors.Control;
            textBoxInputStart_PPE.BorderStyle = BorderStyle.None;
            textBoxInputStart_PPE.Location = new Point(7, 39);
            textBoxInputStart_PPE.Margin = new Padding(3, 4, 3, 4);
            textBoxInputStart_PPE.Name = "textBoxInputStart_PPE";
            textBoxInputStart_PPE.ReadOnly = true;
            textBoxInputStart_PPE.Size = new Size(114, 20);
            textBoxInputStart_PPE.TabIndex = 0;
            textBoxInputStart_PPE.Text = "Переменная X:";
            // 
            // groupBoxOutput_MSM
            // 
            groupBoxOutput_PPE.Controls.Add(textBoxOutputEnd_PPE);
            groupBoxOutput_PPE.Controls.Add(textBoxOutpunStart_PPE);
            groupBoxOutput_PPE.Location = new Point(658, 375);
            groupBoxOutput_PPE.Margin = new Padding(3, 4, 3, 4);
            groupBoxOutput_PPE.Name = "groupBoxOutput_PPE";
            groupBoxOutput_PPE.Padding = new Padding(3, 4, 3, 4);
            groupBoxOutput_PPE.Size = new Size(242, 127);
            groupBoxOutput_PPE.TabIndex = 4;
            groupBoxOutput_PPE.TabStop = false;
            groupBoxOutput_PPE.Text = "Вывод данных:";
            // 
            // textBoxOutputEnd_MSM
            // 
            groupBoxOutput_PPE.Font = new Font("Segoe UI", 16F);
            groupBoxOutput_PPE.Location = new Point(7, 68);
            groupBoxOutput_PPE.Margin = new Padding(3, 4, 3, 4);
            groupBoxOutput_PPE.Name = "textBoxOutputEnd_PPE";
            groupBoxOutput_PPE.ReadOnly = true;
            groupBoxOutput_PPE.Size = new Size(207, 43);
            groupBoxOutput_PPE.TabIndex = 1;
            // 
            // textBoxOutpunStart_MSM
            // 
            textBoxOutpunStart_PPE.BackColor = SystemColors.Control;
            textBoxOutpunStart_PPE.BorderStyle = BorderStyle.None;
            textBoxOutpunStart_PPE.Location = new Point(7, 39);
            textBoxOutpunStart_PPE.Margin = new Padding(3, 4, 3, 4);
            textBoxOutpunStart_PPE.Multiline = true;
            textBoxOutpunStart_PPE.Name = "textBoxOutpunStart_PPE";
            textBoxOutpunStart_PPE.ReadOnly = true;
            textBoxOutpunStart_PPE.Size = new Size(114, 21);
            textBoxOutpunStart_PPE.TabIndex = 0;
            textBoxOutpunStart_PPE.Text = "Результат:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 655);
            Controls.Add(groupBoxOutput_PPE);
            Controls.Add(groupBoxInput_PPE);
            Controls.Add(groupBoxTask_PPE);
            Controls.Add(buttonResult_PPE);
            Controls.Add(buttonHelp_PPE);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 5 |Платонова П.Е .";
            groupBoxTask_PPE.ResumeLayout(false);
            groupBoxTask_PPE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFarmula_PPE).EndInit();
            groupBoxInput_PPE.ResumeLayout(false);
            groupBoxInput_PPE.PerformLayout();
            groupBoxOutput_PPE.ResumeLayout(false);
            groupBoxOutput_PPE.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonHelp_PPE;
        private Button buttonResult_PPE;
        private GroupBox groupBoxTask_PPE;
        private TextBox textBoxTask_PPE;
        private PictureBox pictureBoxFarmula_PPE;
        private GroupBox groupBoxInput_PPE;
        private TextBox textBoxInputEnd_PPE;
        private TextBox textBoxInputStart_PPE;
        private GroupBox groupBoxOutput_PPE;
        private TextBox textBoxOutputEnd_PPE;
        private TextBox textBoxOutpunStart_PPE;
    }
}
