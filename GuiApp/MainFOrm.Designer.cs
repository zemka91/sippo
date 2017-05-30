namespace GuiApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.tabs = new System.Windows.Forms.TabControl();
			this.tabProblem = new System.Windows.Forms.TabPage();
			this.groupManual = new System.Windows.Forms.GroupBox();
			this.gridProblem = new System.Windows.Forms.DataGridView();
			this.languageCount = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.translatorCount = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.groupFile = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.fileName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.opManual = new System.Windows.Forms.RadioButton();
			this.opFile = new System.Windows.Forms.RadioButton();
			this.tabSolution = new System.Windows.Forms.TabPage();
			this.labelSum = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.gridResults = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.useExe = new System.Windows.Forms.CheckBox();
			this.tabs.SuspendLayout();
			this.tabProblem.SuspendLayout();
			this.groupManual.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridProblem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.languageCount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.translatorCount)).BeginInit();
			this.groupFile.SuspendLayout();
			this.tabSolution.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridResults)).BeginInit();
			this.SuspendLayout();
			// 
			// tabs
			// 
			this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabs.Controls.Add(this.tabProblem);
			this.tabs.Controls.Add(this.tabSolution);
			this.tabs.Location = new System.Drawing.Point(12, 12);
			this.tabs.Name = "tabs";
			this.tabs.SelectedIndex = 0;
			this.tabs.Size = new System.Drawing.Size(566, 387);
			this.tabs.TabIndex = 0;
			// 
			// tabProblem
			// 
			this.tabProblem.Controls.Add(this.useExe);
			this.tabProblem.Controls.Add(this.groupManual);
			this.tabProblem.Controls.Add(this.groupFile);
			this.tabProblem.Controls.Add(this.label1);
			this.tabProblem.Controls.Add(this.opManual);
			this.tabProblem.Controls.Add(this.opFile);
			this.tabProblem.Location = new System.Drawing.Point(4, 22);
			this.tabProblem.Name = "tabProblem";
			this.tabProblem.Padding = new System.Windows.Forms.Padding(3);
			this.tabProblem.Size = new System.Drawing.Size(558, 361);
			this.tabProblem.TabIndex = 0;
			this.tabProblem.Text = "Задача";
			this.tabProblem.UseVisualStyleBackColor = true;
			// 
			// groupManual
			// 
			this.groupManual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupManual.Controls.Add(this.gridProblem);
			this.groupManual.Controls.Add(this.languageCount);
			this.groupManual.Controls.Add(this.label3);
			this.groupManual.Controls.Add(this.translatorCount);
			this.groupManual.Controls.Add(this.label2);
			this.groupManual.Location = new System.Drawing.Point(9, 121);
			this.groupManual.Name = "groupManual";
			this.groupManual.Size = new System.Drawing.Size(539, 242);
			this.groupManual.TabIndex = 5;
			this.groupManual.TabStop = false;
			this.groupManual.Text = "Ручной ввод";
			// 
			// gridProblem
			// 
			this.gridProblem.AllowUserToAddRows = false;
			this.gridProblem.AllowUserToDeleteRows = false;
			this.gridProblem.AllowUserToResizeColumns = false;
			this.gridProblem.AllowUserToResizeRows = false;
			this.gridProblem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridProblem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridProblem.ColumnHeadersVisible = false;
			this.gridProblem.Location = new System.Drawing.Point(12, 77);
			this.gridProblem.Name = "gridProblem";
			this.gridProblem.RowHeadersWidth = 100;
			this.gridProblem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.gridProblem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.gridProblem.Size = new System.Drawing.Size(521, 159);
			this.gridProblem.TabIndex = 4;
			// 
			// languageCount
			// 
			this.languageCount.Location = new System.Drawing.Point(158, 51);
			this.languageCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.languageCount.Name = "languageCount";
			this.languageCount.Size = new System.Drawing.Size(51, 20);
			this.languageCount.TabIndex = 3;
			this.languageCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.languageCount.ValueChanged += new System.EventHandler(this.languageCount_ValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 53);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(110, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Количество языков:";
			// 
			// translatorCount
			// 
			this.translatorCount.Location = new System.Drawing.Point(158, 25);
			this.translatorCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.translatorCount.Name = "translatorCount";
			this.translatorCount.Size = new System.Drawing.Size(51, 20);
			this.translatorCount.TabIndex = 1;
			this.translatorCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.translatorCount.ValueChanged += new System.EventHandler(this.translatorCount_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(143, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Количество переводчиков:";
			// 
			// groupFile
			// 
			this.groupFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupFile.Controls.Add(this.button2);
			this.groupFile.Controls.Add(this.fileName);
			this.groupFile.Location = new System.Drawing.Point(9, 60);
			this.groupFile.Name = "groupFile";
			this.groupFile.Size = new System.Drawing.Size(540, 56);
			this.groupFile.TabIndex = 4;
			this.groupFile.TabStop = false;
			this.groupFile.Text = "Файл";
			// 
			// button2
			// 
			this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.button2.Location = new System.Drawing.Point(467, 19);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(66, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "Обзор...";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// fileName
			// 
			this.fileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.fileName.Location = new System.Drawing.Point(12, 20);
			this.fileName.Name = "fileName";
			this.fileName.ReadOnly = true;
			this.fileName.Size = new System.Drawing.Size(450, 20);
			this.fileName.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Тип ввода:";
			// 
			// opManual
			// 
			this.opManual.AutoSize = true;
			this.opManual.Location = new System.Drawing.Point(74, 37);
			this.opManual.Name = "opManual";
			this.opManual.Size = new System.Drawing.Size(86, 17);
			this.opManual.TabIndex = 1;
			this.opManual.Text = "ручной ввод";
			this.opManual.UseVisualStyleBackColor = true;
			this.opManual.CheckedChanged += new System.EventHandler(this.inputType_CheckedChanged);
			// 
			// opFile
			// 
			this.opFile.AutoSize = true;
			this.opFile.Location = new System.Drawing.Point(74, 14);
			this.opFile.Name = "opFile";
			this.opFile.Size = new System.Drawing.Size(51, 17);
			this.opFile.TabIndex = 0;
			this.opFile.Text = "файл";
			this.opFile.UseVisualStyleBackColor = true;
			this.opFile.CheckedChanged += new System.EventHandler(this.inputType_CheckedChanged);
			// 
			// tabSolution
			// 
			this.tabSolution.Controls.Add(this.labelSum);
			this.tabSolution.Controls.Add(this.label5);
			this.tabSolution.Controls.Add(this.label4);
			this.tabSolution.Controls.Add(this.gridResults);
			this.tabSolution.Location = new System.Drawing.Point(4, 22);
			this.tabSolution.Name = "tabSolution";
			this.tabSolution.Padding = new System.Windows.Forms.Padding(3);
			this.tabSolution.Size = new System.Drawing.Size(558, 361);
			this.tabSolution.TabIndex = 1;
			this.tabSolution.Text = "Решение";
			this.tabSolution.UseVisualStyleBackColor = true;
			// 
			// labelSum
			// 
			this.labelSum.AutoSize = true;
			this.labelSum.Location = new System.Drawing.Point(106, 285);
			this.labelSum.Name = "labelSum";
			this.labelSum.Size = new System.Drawing.Size(13, 13);
			this.labelSum.TabIndex = 8;
			this.labelSum.Text = "0";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 285);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "Итоговая сумма:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Назначения:";
			// 
			// gridResults
			// 
			this.gridResults.AllowUserToAddRows = false;
			this.gridResults.AllowUserToDeleteRows = false;
			this.gridResults.AllowUserToResizeColumns = false;
			this.gridResults.AllowUserToResizeRows = false;
			this.gridResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridResults.ColumnHeadersVisible = false;
			this.gridResults.Location = new System.Drawing.Point(9, 32);
			this.gridResults.Name = "gridResults";
			this.gridResults.RowHeadersVisible = false;
			this.gridResults.Size = new System.Drawing.Size(543, 234);
			this.gridResults.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(503, 405);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Решить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// useExe
			// 
			this.useExe.AutoSize = true;
			this.useExe.Location = new System.Drawing.Point(167, 15);
			this.useExe.Name = "useExe";
			this.useExe.Size = new System.Drawing.Size(218, 17);
			this.useExe.TabIndex = 6;
			this.useExe.Text = "использовать EXE-файл для решения";
			this.useExe.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(590, 440);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tabs);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.tabs.ResumeLayout(false);
			this.tabProblem.ResumeLayout(false);
			this.tabProblem.PerformLayout();
			this.groupManual.ResumeLayout(false);
			this.groupManual.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridProblem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.languageCount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.translatorCount)).EndInit();
			this.groupFile.ResumeLayout(false);
			this.groupFile.PerformLayout();
			this.tabSolution.ResumeLayout(false);
			this.tabSolution.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridResults)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.TabControl tabs;
		private System.Windows.Forms.TabPage tabProblem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton opManual;
		private System.Windows.Forms.RadioButton opFile;
		private System.Windows.Forms.TabPage tabSolution;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupManual;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupFile;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox fileName;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.DataGridView gridProblem;
		private System.Windows.Forms.NumericUpDown languageCount;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown translatorCount;
		private System.Windows.Forms.DataGridView gridResults;
		private System.Windows.Forms.Label labelSum;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox useExe;
	}
}

