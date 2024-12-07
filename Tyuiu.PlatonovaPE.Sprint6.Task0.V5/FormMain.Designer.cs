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
            buttonHelp_MSM = new Button();
            buttonResult_MSM = new Button();
            groupBoxTask_MSM = new GroupBox();
            textBoxTask_MSM = new TextBox();
            pictureBoxFarmula_MSM = new PictureBox();
            groupBoxInput_MSM = new GroupBox();
            textBoxInputEnd_MSM = new TextBox();
            textBoxInputStart_MSM = new TextBox();
            groupBoxOutput_MSM = new GroupBox();
            textBoxOutputEnd_MSM = new TextBox();
            textBoxOutpunStart_MSM = new TextBox();
            groupBoxTask_MSM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFarmula_MSM).BeginInit();
            groupBoxInput_MSM.SuspendLayout();
            groupBoxOutput_MSM.SuspendLayout();
            SuspendLayout();
            // 
            // buttonHelp_MSM
            // 
            buttonHelp_MSM.FlatStyle = FlatStyle.Flat;
            buttonHelp_MSM.Font = new Font("Segoe UI", 14F);
            buttonHelp_MSM.Location = new Point(656, 520);
            buttonHelp_MSM.Margin = new Padding(3, 4, 3, 4);
            buttonHelp_MSM.Name = "buttonHelp_MSM";
            buttonHelp_MSM.Size = new Size(57, 67);
            buttonHelp_MSM.TabIndex = 0;
            buttonHelp_MSM.Text = "?";
            buttonHelp_MSM.UseVisualStyleBackColor = true;
            buttonHelp_MSM.Click += buttonHelp_MSM_Click;
            // 
            // buttonResult_MSM
            // 
            buttonResult_MSM.BackColor = SystemColors.Control;
            buttonResult_MSM.Location = new Point(720, 520);
            buttonResult_MSM.Margin = new Padding(3, 4, 3, 4);
            buttonResult_MSM.Name = "buttonResult_MSM";
            buttonResult_MSM.Size = new Size(181, 64);
            buttonResult_MSM.TabIndex = 1;
            buttonResult_MSM.Text = "Выполнить";
            buttonResult_MSM.UseVisualStyleBackColor = false;
            buttonResult_MSM.Click += buttonResult_MSM_Click;
            // 
            // groupBoxTask_MSM
            // 
            groupBoxTask_MSM.Controls.Add(textBoxTask_MSM);
            groupBoxTask_MSM.Controls.Add(pictureBoxFarmula_MSM);
            groupBoxTask_MSM.Location = new Point(14, 16);
            groupBoxTask_MSM.Margin = new Padding(3, 4, 3, 4);
            groupBoxTask_MSM.Name = "groupBoxTask_MSM";
            groupBoxTask_MSM.Padding = new Padding(3, 4, 3, 4);
            groupBoxTask_MSM.Size = new Size(887, 351);
            groupBoxTask_MSM.TabIndex = 2;
            groupBoxTask_MSM.TabStop = false;
            groupBoxTask_MSM.Text = "Условие";
            // 
            // textBoxTask_MSM
            // 
            textBoxTask_MSM.BackColor = SystemColors.Control;
            textBoxTask_MSM.BorderStyle = BorderStyle.None;
            textBoxTask_MSM.Location = new Point(7, 29);
            textBoxTask_MSM.Margin = new Padding(3, 4, 3, 4);
            textBoxTask_MSM.Multiline = true;
            textBoxTask_MSM.Name = "textBoxTask_MSM";
            textBoxTask_MSM.ReadOnly = true;
            textBoxTask_MSM.Size = new Size(527, 313);
            textBoxTask_MSM.TabIndex = 1;
            textBoxTask_MSM.Text = "Вычислить выражение по формуле";
            // 
            // pictureBoxFarmula_MSM
            // 
            pictureBoxFarmula_MSM.BackColor = SystemColors.Window;
            pictureBoxFarmula_MSM.Location = new Point(541, 29);
            pictureBoxFarmula_MSM.Margin = new Padding(3, 4, 3, 4);
            pictureBoxFarmula_MSM.Name = "pictureBoxFarmula_MSM";
            pictureBoxFarmula_MSM.Size = new Size(339, 52);
            pictureBoxFarmula_MSM.TabIndex = 0;
            pictureBoxFarmula_MSM.TabStop = false;
            pictureBoxFarmula_MSM.Click += this.pictureBoxFarmula_MSM_Click;
            // 
            // groupBoxInput_MSM
            // 
            groupBoxInput_MSM.Controls.Add(textBoxInputEnd_MSM);
            groupBoxInput_MSM.Controls.Add(textBoxInputStart_MSM);
            groupBoxInput_MSM.Location = new Point(14, 375);
            groupBoxInput_MSM.Margin = new Padding(3, 4, 3, 4);
            groupBoxInput_MSM.Name = "groupBoxInput_MSM";
            groupBoxInput_MSM.Padding = new Padding(3, 4, 3, 4);
            groupBoxInput_MSM.Size = new Size(638, 127);
            groupBoxInput_MSM.TabIndex = 3;
            groupBoxInput_MSM.TabStop = false;
            groupBoxInput_MSM.Text = "Ввод данных:";
            // 
            // textBoxInputEnd_MSM
            // 
            textBoxInputEnd_MSM.Font = new Font("Segoe UI", 16F);
            textBoxInputEnd_MSM.Location = new Point(7, 68);
            textBoxInputEnd_MSM.Margin = new Padding(3, 4, 3, 4);
            textBoxInputEnd_MSM.Name = "textBoxInputEnd_MSM";
            textBoxInputEnd_MSM.Size = new Size(623, 43);
            textBoxInputEnd_MSM.TabIndex = 1;
            textBoxInputEnd_MSM.KeyPress += textBoxInputEnd_MSM_KeyPress;
            // 
            // textBoxInputStart_MSM
            // 
            textBoxInputStart_MSM.BackColor = SystemColors.Control;
            textBoxInputStart_MSM.BorderStyle = BorderStyle.None;
            textBoxInputStart_MSM.Location = new Point(7, 39);
            textBoxInputStart_MSM.Margin = new Padding(3, 4, 3, 4);
            textBoxInputStart_MSM.Name = "textBoxInputStart_MSM";
            textBoxInputStart_MSM.ReadOnly = true;
            textBoxInputStart_MSM.Size = new Size(114, 20);
            textBoxInputStart_MSM.TabIndex = 0;
            textBoxInputStart_MSM.Text = "Переменная X:";
            // 
            // groupBoxOutput_MSM
            // 
            groupBoxOutput_MSM.Controls.Add(textBoxOutputEnd_MSM);
            groupBoxOutput_MSM.Controls.Add(textBoxOutpunStart_MSM);
            groupBoxOutput_MSM.Location = new Point(658, 375);
            groupBoxOutput_MSM.Margin = new Padding(3, 4, 3, 4);
            groupBoxOutput_MSM.Name = "groupBoxOutput_MSM";
            groupBoxOutput_MSM.Padding = new Padding(3, 4, 3, 4);
            groupBoxOutput_MSM.Size = new Size(242, 127);
            groupBoxOutput_MSM.TabIndex = 4;
            groupBoxOutput_MSM.TabStop = false;
            groupBoxOutput_MSM.Text = "Вывод данных:";
            // 
            // textBoxOutputEnd_MSM
            // 
            textBoxOutputEnd_MSM.Font = new Font("Segoe UI", 16F);
            textBoxOutputEnd_MSM.Location = new Point(7, 68);
            textBoxOutputEnd_MSM.Margin = new Padding(3, 4, 3, 4);
            textBoxOutputEnd_MSM.Name = "textBoxOutputEnd_MSM";
            textBoxOutputEnd_MSM.ReadOnly = true;
            textBoxOutputEnd_MSM.Size = new Size(207, 43);
            textBoxOutputEnd_MSM.TabIndex = 1;
            // 
            // textBoxOutpunStart_MSM
            // 
            textBoxOutpunStart_MSM.BackColor = SystemColors.Control;
            textBoxOutpunStart_MSM.BorderStyle = BorderStyle.None;
            textBoxOutpunStart_MSM.Location = new Point(7, 39);
            textBoxOutpunStart_MSM.Margin = new Padding(3, 4, 3, 4);
            textBoxOutpunStart_MSM.Multiline = true;
            textBoxOutpunStart_MSM.Name = "textBoxOutpunStart_MSM";
            textBoxOutpunStart_MSM.ReadOnly = true;
            textBoxOutpunStart_MSM.Size = new Size(114, 21);
            textBoxOutpunStart_MSM.TabIndex = 0;
            textBoxOutpunStart_MSM.Text = "Результат:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 655);
            Controls.Add(groupBoxOutput_MSM);
            Controls.Add(groupBoxInput_MSM);
            Controls.Add(groupBoxTask_MSM);
            Controls.Add(buttonResult_MSM);
            Controls.Add(buttonHelp_MSM);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 5 |Платонова П.Е .";
            groupBoxTask_MSM.ResumeLayout(false);
            groupBoxTask_MSM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFarmula_MSM).EndInit();
            groupBoxInput_MSM.ResumeLayout(false);
            groupBoxInput_MSM.PerformLayout();
            groupBoxOutput_MSM.ResumeLayout(false);
            groupBoxOutput_MSM.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonHelp_MSM;
        private Button buttonResult_MSM;
        private GroupBox groupBoxTask_MSM;
        private TextBox textBoxTask_MSM;
        private PictureBox pictureBoxFarmula_MSM;
        private GroupBox groupBoxInput_MSM;
        private TextBox textBoxInputEnd_MSM;
        private TextBox textBoxInputStart_MSM;
        private GroupBox groupBoxOutput_MSM;
        private TextBox textBoxOutputEnd_MSM;
        private TextBox textBoxOutpunStart_MSM;
    }
}
