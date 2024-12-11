
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
            this.groupBoxTask_PPE = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxRes_PPE = new System.Windows.Forms.GroupBox();
            this.labelRes_PPE = new System.Windows.Forms.Label();
            this.buttonHelp_PPE = new System.Windows.Forms.Button();
            this.buttonDone_PPE = new System.Windows.Forms.Button();
            this.dataGridViewMatrix_PPE = new System.Windows.Forms.DataGridView();
            this.dataGridViewRes_PPE = new System.Windows.Forms.DataGridView();
            this.groupBoxTask_PPE.SuspendLayout();
            this.groupBoxRes_PPE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_PPE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_PPE)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_VAA
            // 
            this.groupBoxTask_PPE.Controls.Add(this.dataGridViewMatrix_PPE);
            this.groupBoxTask_PPE.Controls.Add(this.label1);
            this.groupBoxTask_PPE.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_PPE.Name = "groupBoxTask_PPE";
            this.groupBoxTask_PPE.Size = new System.Drawing.Size(650, 349);
            this.groupBoxTask_PPE.TabIndex = 0;
            this.groupBoxTask_PPE.TabStop = false;
            this.groupBoxTask_PPE.Text = "Условие";
            this.groupBoxTask_PPE.Enter += new System.EventHandler(this.groupBoxTask_PPE_Enter);
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
            this.groupBoxRes_PPE.Controls.Add(this.dataGridViewRes_PPE);
            this.groupBoxRes_PPE.Controls.Add(this.labelRes_PPE);
            this.groupBoxRes_PPE.Location = new System.Drawing.Point(669, 13);
            this.groupBoxRes_PPE.Name = "groupBoxRes_PPE";
            this.groupBoxRes_PPE.Size = new System.Drawing.Size(258, 310);
            this.groupBoxRes_PPE.TabIndex = 1;
            this.groupBoxRes_PPE.TabStop = false;
            this.groupBoxRes_PPE.Text = "Вывод данных";
            // 
            // labelRes_VAA
            // 
            this.labelRes_PPE.AutoSize = true;
            this.labelRes_PPE.Location = new System.Drawing.Point(6, 23);
            this.labelRes_PPE.Name = "labelRes_PPE";
            this.labelRes_PPE.Size = new System.Drawing.Size(80, 17);
            this.labelRes_PPE.TabIndex = 1;
            this.labelRes_PPE.Text = "Результат:";
            // 
            // buttonHelp_VAA
            // 
            this.buttonHelp_PPE.Location = new System.Drawing.Point(770, 329);
            this.buttonHelp_PPE.Name = "buttonHelp_PPE";
            this.buttonHelp_PPE.Size = new System.Drawing.Size(42, 33);
            this.buttonHelp_PPE.TabIndex = 2;
            this.buttonHelp_PPE.Text = "?";
            this.buttonHelp_PPE.UseVisualStyleBackColor = true;
            this.buttonHelp_PPE.Click += new System.EventHandler(this.buttonHelp_VAA_Click);
            // 
            // buttonDone_VAA
            // 
            this.buttonDone_PPE.Location = new System.Drawing.Point(818, 329);
            this.buttonDone_PPE.Name = "buttonDone_VAA";
            this.buttonDone_PPE.Size = new System.Drawing.Size(109, 33);
            this.buttonDone_PPE.TabIndex = 3;
            this.buttonDone_PPE.Text = "Выполнить ";
            this.buttonDone_PPE.UseVisualStyleBackColor = true;
            this.buttonDone_PPE.Click += new System.EventHandler(this.buttonDone_PPE_Click);
            // 
            // dataGridViewMatrix_VAA
            // 
            this.dataGridViewMatrix_PPE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_PPE.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_PPE.Location = new System.Drawing.Point(376, 22);
            this.dataGridViewMatrix_PPE.Name = "dataGridViewMatrix_PPE";
            this.dataGridViewMatrix_PPE.RowHeadersVisible = false;
            this.dataGridViewMatrix_PPE.RowHeadersWidth = 51;
            this.dataGridViewMatrix_PPE.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewMatrix_PPE.RowTemplate.Height = 24;
            this.dataGridViewMatrix_PPE.Size = new System.Drawing.Size(254, 223);
            this.dataGridViewMatrix_PPE.TabIndex = 1;
            // 
            // dataGridViewRes_VAA
            // 
            this.dataGridViewRes_PPE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRes_PPE.ColumnHeadersVisible = false;
            this.dataGridViewRes_PPE.Location = new System.Drawing.Point(9, 44);
            this.dataGridViewRes_PPE.Name = "dataGridViewRes_PPE";
            this.dataGridViewRes_PPE.RowHeadersVisible = false;
            this.dataGridViewRes_PPE.RowHeadersWidth = 51;
            this.dataGridViewRes_PPE.RowTemplate.Height = 24;
            this.dataGridViewRes_PPE.Size = new System.Drawing.Size(240, 234);
            this.dataGridViewRes_PPE.TabIndex = 2;
            this.dataGridViewRes_PPE.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRes_PPE_CellContentClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 374);
            this.Controls.Add(this.buttonDone_PPE);
            this.Controls.Add(this.buttonHelp_PPE);
            this.Controls.Add(this.groupBoxRes_PPE);
            this.Controls.Add(this.groupBoxTask_PPE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 3 | Вариант 28 |  Платонова П.Е.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_PPE.ResumeLayout(false);
            this.groupBoxTask_PPE.PerformLayout();
            this.groupBoxRes_PPE.ResumeLayout(false);
            this.groupBoxRes_PPE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_PPE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_PPE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_PPE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxRes_PPE;
        private System.Windows.Forms.Label labelRes_PPE;
        private System.Windows.Forms.Button buttonHelp_PPE;
        private System.Windows.Forms.Button buttonDone_PPE;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_PPE;
        private System.Windows.Forms.DataGridView dataGridViewRes_PPE;
    }
}