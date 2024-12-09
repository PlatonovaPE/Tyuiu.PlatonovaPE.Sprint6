
namespace Tyuiu.PlatonovaPE.Sprint6.Task3.V28
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxTask_VAA = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxRes_VAA = new System.Windows.Forms.GroupBox();
            this.labelRes_VAA = new System.Windows.Forms.Label();
            this.buttonHelp_VAA = new System.Windows.Forms.Button();
            this.buttonDone_VAA = new System.Windows.Forms.Button();
            this.dataGridViewMatrix_VAA = new System.Windows.Forms.DataGridView();
            this.dataGridViewRes_VAA = new System.Windows.Forms.DataGridView();
            this.groupBoxTask_VAA.SuspendLayout();
            this.groupBoxRes_VAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_VAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_VAA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_VAA
            // 
            this.groupBoxTask_VAA.Controls.Add(this.dataGridViewMatrix_VAA);
            this.groupBoxTask_VAA.Controls.Add(this.label1);
            this.groupBoxTask_VAA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_VAA.Name = "groupBoxTask_VAA";
            this.groupBoxTask_VAA.Size = new System.Drawing.Size(650, 349);
            this.groupBoxTask_VAA.TabIndex = 0;
            this.groupBoxTask_VAA.TabStop = false;
            this.groupBoxTask_VAA.Text = "Условие";
            this.groupBoxTask_VAA.Enter += new System.EventHandler(this.groupBoxTask_VAA_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 136);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // groupBoxRes_VAA
            // 
            this.groupBoxRes_VAA.Controls.Add(this.dataGridViewRes_VAA);
            this.groupBoxRes_VAA.Controls.Add(this.labelRes_VAA);
            this.groupBoxRes_VAA.Location = new System.Drawing.Point(669, 13);
            this.groupBoxRes_VAA.Name = "groupBoxRes_VAA";
            this.groupBoxRes_VAA.Size = new System.Drawing.Size(258, 310);
            this.groupBoxRes_VAA.TabIndex = 1;
            this.groupBoxRes_VAA.TabStop = false;
            this.groupBoxRes_VAA.Text = "Вывод данных";
            // 
            // labelRes_VAA
            // 
            this.labelRes_VAA.AutoSize = true;
            this.labelRes_VAA.Location = new System.Drawing.Point(6, 23);
            this.labelRes_VAA.Name = "labelRes_VAA";
            this.labelRes_VAA.Size = new System.Drawing.Size(80, 17);
            this.labelRes_VAA.TabIndex = 1;
            this.labelRes_VAA.Text = "Результат:";
            // 
            // buttonHelp_VAA
            // 
            this.buttonHelp_VAA.Location = new System.Drawing.Point(770, 329);
            this.buttonHelp_VAA.Name = "buttonHelp_VAA";
            this.buttonHelp_VAA.Size = new System.Drawing.Size(42, 33);
            this.buttonHelp_VAA.TabIndex = 2;
            this.buttonHelp_VAA.Text = "?";
            this.buttonHelp_VAA.UseVisualStyleBackColor = true;
            this.buttonHelp_VAA.Click += new System.EventHandler(this.buttonHelp_VAA_Click);
            // 
            // buttonDone_VAA
            // 
            this.buttonDone_VAA.Location = new System.Drawing.Point(818, 329);
            this.buttonDone_VAA.Name = "buttonDone_VAA";
            this.buttonDone_VAA.Size = new System.Drawing.Size(109, 33);
            this.buttonDone_VAA.TabIndex = 3;
            this.buttonDone_VAA.Text = "Выполнить ";
            this.buttonDone_VAA.UseVisualStyleBackColor = true;
            this.buttonDone_VAA.Click += new System.EventHandler(this.buttonDone_VAA_Click);
            // 
            // dataGridViewMatrix_VAA
            // 
            this.dataGridViewMatrix_VAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_VAA.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_VAA.Location = new System.Drawing.Point(376, 22);
            this.dataGridViewMatrix_VAA.Name = "dataGridViewMatrix_VAA";
            this.dataGridViewMatrix_VAA.RowHeadersVisible = false;
            this.dataGridViewMatrix_VAA.RowHeadersWidth = 51;
            this.dataGridViewMatrix_VAA.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewMatrix_VAA.RowTemplate.Height = 24;
            this.dataGridViewMatrix_VAA.Size = new System.Drawing.Size(254, 223);
            this.dataGridViewMatrix_VAA.TabIndex = 1;
            // 
            // dataGridViewRes_VAA
            // 
            this.dataGridViewRes_VAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRes_VAA.ColumnHeadersVisible = false;
            this.dataGridViewRes_VAA.Location = new System.Drawing.Point(9, 44);
            this.dataGridViewRes_VAA.Name = "dataGridViewRes_VAA";
            this.dataGridViewRes_VAA.RowHeadersVisible = false;
            this.dataGridViewRes_VAA.RowHeadersWidth = 51;
            this.dataGridViewRes_VAA.RowTemplate.Height = 24;
            this.dataGridViewRes_VAA.Size = new System.Drawing.Size(240, 234);
            this.dataGridViewRes_VAA.TabIndex = 2;
            this.dataGridViewRes_VAA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRes_VAA_CellContentClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 374);
            this.Controls.Add(this.buttonDone_VAA);
            this.Controls.Add(this.buttonHelp_VAA);
            this.Controls.Add(this.groupBoxRes_VAA);
            this.Controls.Add(this.groupBoxTask_VAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 3 | Вариант 28 |  Платонова П.Е.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_VAA.ResumeLayout(false);
            this.groupBoxTask_VAA.PerformLayout();
            this.groupBoxRes_VAA.ResumeLayout(false);
            this.groupBoxRes_VAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_VAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_VAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_VAA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxRes_VAA;
        private System.Windows.Forms.Label labelRes_VAA;
        private System.Windows.Forms.Button buttonHelp_VAA;
        private System.Windows.Forms.Button buttonDone_VAA;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_VAA;
        private System.Windows.Forms.DataGridView dataGridViewRes_VAA;
    }
}