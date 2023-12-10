
namespace Tyuiu.IvanchikovDA.Sprint6.Task2.V10
{
    partial class FormMane
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_DA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_DA = new System.Windows.Forms.TextBox();
            this.pictureBoxFormula_DA = new System.Windows.Forms.PictureBox();
            this.groupBoxResult_DA = new System.Windows.Forms.GroupBox();
            this.dataGridViewFunction = new System.Windows.Forms.DataGridView();
            this.Columnx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelOutPut_DA = new System.Windows.Forms.Label();
            this.textBoxResult_DA = new System.Windows.Forms.TextBox();
            this.groupBoxInPut_DA = new System.Windows.Forms.GroupBox();
            this.labelResult_DA = new System.Windows.Forms.Label();
            this.labelInPut_DA = new System.Windows.Forms.Label();
            this.textBoxStopStep_DA = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_DA = new System.Windows.Forms.TextBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelTask = new System.Windows.Forms.Label();
            this.groupBoxTask_DA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_DA)).BeginInit();
            this.groupBoxResult_DA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction)).BeginInit();
            this.groupBoxInPut_DA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_DA
            // 
            this.groupBoxTask_DA.Controls.Add(this.textBoxTask_DA);
            this.groupBoxTask_DA.Controls.Add(this.pictureBoxFormula_DA);
            this.groupBoxTask_DA.Location = new System.Drawing.Point(12, 22);
            this.groupBoxTask_DA.Name = "groupBoxTask_DA";
            this.groupBoxTask_DA.Size = new System.Drawing.Size(492, 292);
            this.groupBoxTask_DA.TabIndex = 1;
            this.groupBoxTask_DA.TabStop = false;
            this.groupBoxTask_DA.Text = "Условие";
            // 
            // textBoxTask_DA
            // 
            this.textBoxTask_DA.Location = new System.Drawing.Point(7, 31);
            this.textBoxTask_DA.Multiline = true;
            this.textBoxTask_DA.Name = "textBoxTask_DA";
            this.textBoxTask_DA.ReadOnly = true;
            this.textBoxTask_DA.Size = new System.Drawing.Size(485, 42);
            this.textBoxTask_DA.TabIndex = 1;
            this.textBoxTask_DA.Text = "Протабулировать функцию sin(x) на заданном диапазоне.\r\nРезальтат вывести в DataGr" +
    "idViev и построить график функции.";
            // 
            // pictureBoxFormula_DA
            // 
            this.pictureBoxFormula_DA.Image = global::Tyuiu.IvanchikovDA.Sprint6.Task2.V10.Properties.Resources._1;
            this.pictureBoxFormula_DA.Location = new System.Drawing.Point(7, 92);
            this.pictureBoxFormula_DA.Name = "pictureBoxFormula_DA";
            this.pictureBoxFormula_DA.Size = new System.Drawing.Size(233, 40);
            this.pictureBoxFormula_DA.TabIndex = 0;
            this.pictureBoxFormula_DA.TabStop = false;
            // 
            // groupBoxResult_DA
            // 
            this.groupBoxResult_DA.Controls.Add(this.dataGridViewFunction);
            this.groupBoxResult_DA.Controls.Add(this.labelOutPut_DA);
            this.groupBoxResult_DA.Controls.Add(this.textBoxResult_DA);
            this.groupBoxResult_DA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxResult_DA.Location = new System.Drawing.Point(520, 22);
            this.groupBoxResult_DA.Name = "groupBoxResult_DA";
            this.groupBoxResult_DA.Size = new System.Drawing.Size(278, 393);
            this.groupBoxResult_DA.TabIndex = 2;
            this.groupBoxResult_DA.TabStop = false;
            this.groupBoxResult_DA.Text = "Вывод данных";
            this.groupBoxResult_DA.Enter += new System.EventHandler(this.groupBoxResult_DA_Enter);
            // 
            // dataGridViewFunction
            // 
            this.dataGridViewFunction.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewFunction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columnx,
            this.Columnf});
            this.dataGridViewFunction.Location = new System.Drawing.Point(52, 59);
            this.dataGridViewFunction.Name = "dataGridViewFunction";
            this.dataGridViewFunction.RowHeadersVisible = false;
            this.dataGridViewFunction.Size = new System.Drawing.Size(111, 284);
            this.dataGridViewFunction.TabIndex = 2;
            // 
            // Columnx
            // 
            this.Columnx.HeaderText = "X";
            this.Columnx.Name = "Columnx";
            this.Columnx.Width = 50;
            // 
            // Columnf
            // 
            this.Columnf.HeaderText = "F(x)";
            this.Columnf.Name = "Columnf";
            this.Columnf.Width = 50;
            // 
            // labelOutPut_DA
            // 
            this.labelOutPut_DA.AutoSize = true;
            this.labelOutPut_DA.Location = new System.Drawing.Point(14, 31);
            this.labelOutPut_DA.Name = "labelOutPut_DA";
            this.labelOutPut_DA.Size = new System.Drawing.Size(62, 13);
            this.labelOutPut_DA.TabIndex = 1;
            this.labelOutPut_DA.Text = "Результат:";
            // 
            // textBoxResult_DA
            // 
            this.textBoxResult_DA.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxResult_DA.ForeColor = System.Drawing.Color.Black;
            this.textBoxResult_DA.Location = new System.Drawing.Point(17, 54);
            this.textBoxResult_DA.Multiline = true;
            this.textBoxResult_DA.Name = "textBoxResult_DA";
            this.textBoxResult_DA.Size = new System.Drawing.Size(188, 338);
            this.textBoxResult_DA.TabIndex = 0;
            // 
            // groupBoxInPut_DA
            // 
            this.groupBoxInPut_DA.Controls.Add(this.labelResult_DA);
            this.groupBoxInPut_DA.Controls.Add(this.labelInPut_DA);
            this.groupBoxInPut_DA.Controls.Add(this.textBoxStopStep_DA);
            this.groupBoxInPut_DA.Controls.Add(this.textBoxStartStep_DA);
            this.groupBoxInPut_DA.Location = new System.Drawing.Point(19, 336);
            this.groupBoxInPut_DA.Name = "groupBoxInPut_DA";
            this.groupBoxInPut_DA.Size = new System.Drawing.Size(252, 78);
            this.groupBoxInPut_DA.TabIndex = 2;
            this.groupBoxInPut_DA.TabStop = false;
            this.groupBoxInPut_DA.Text = "Ввод данных";
            // 
            // labelResult_DA
            // 
            this.labelResult_DA.AutoSize = true;
            this.labelResult_DA.Location = new System.Drawing.Point(130, 33);
            this.labelResult_DA.Name = "labelResult_DA";
            this.labelResult_DA.Size = new System.Drawing.Size(69, 13);
            this.labelResult_DA.TabIndex = 1;
            this.labelResult_DA.Text = "Конец шага:";
            // 
            // labelInPut_DA
            // 
            this.labelInPut_DA.AutoSize = true;
            this.labelInPut_DA.Location = new System.Drawing.Point(7, 33);
            this.labelInPut_DA.Name = "labelInPut_DA";
            this.labelInPut_DA.Size = new System.Drawing.Size(67, 13);
            this.labelInPut_DA.TabIndex = 1;
            this.labelInPut_DA.Text = "Старт шага:";
            // 
            // textBoxStopStep_DA
            // 
            this.textBoxStopStep_DA.Location = new System.Drawing.Point(133, 52);
            this.textBoxStopStep_DA.Name = "textBoxStopStep_DA";
            this.textBoxStopStep_DA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopStep_DA.TabIndex = 0;
            // 
            // textBoxStartStep_DA
            // 
            this.textBoxStartStep_DA.Location = new System.Drawing.Point(7, 52);
            this.textBoxStartStep_DA.Name = "textBoxStartStep_DA";
            this.textBoxStartStep_DA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartStep_DA.TabIndex = 0;
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp.ForeColor = System.Drawing.Color.Black;
            this.buttonHelp.Location = new System.Drawing.Point(287, 364);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(80, 44);
            this.buttonHelp.TabIndex = 3;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDone.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonDone.Location = new System.Drawing.Point(387, 364);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(117, 44);
            this.buttonDone.TabIndex = 4;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            this.buttonDone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_MouseDown);
            this.buttonDone.MouseEnter += new System.EventHandler(this.buttonDone_MouseEnter);
            this.buttonDone.MouseLeave += new System.EventHandler(this.buttonDone_MouseLeave);
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction.Legends.Add(legend1);
            this.chartFunction.Location = new System.Drawing.Point(731, 76);
            this.chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction.Series.Add(series1);
            this.chartFunction.Size = new System.Drawing.Size(491, 338);
            this.chartFunction.TabIndex = 5;
            this.chartFunction.Text = "chart1";
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.Location = new System.Drawing.Point(828, 53);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(118, 13);
            this.labelTask.TabIndex = 6;
            this.labelTask.Text = "График функции sin(x)";
            // 
            // FormMane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 461);
            this.Controls.Add(this.labelTask);
            this.Controls.Add(this.chartFunction);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.groupBoxInPut_DA);
            this.Controls.Add(this.groupBoxResult_DA);
            this.Controls.Add(this.groupBoxTask_DA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1250, 500);
            this.MinimumSize = new System.Drawing.Size(1250, 500);
            this.Name = "FormMane";
            this.Text = "Спринт 6 | Таск 2 | Вариант 10 | Иванчиков Д.А.";
            this.groupBoxTask_DA.ResumeLayout(false);
            this.groupBoxTask_DA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_DA)).EndInit();
            this.groupBoxResult_DA.ResumeLayout(false);
            this.groupBoxResult_DA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction)).EndInit();
            this.groupBoxInPut_DA.ResumeLayout(false);
            this.groupBoxInPut_DA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_DA;
        private System.Windows.Forms.TextBox textBoxTask_DA;
        private System.Windows.Forms.PictureBox pictureBoxFormula_DA;
        private System.Windows.Forms.GroupBox groupBoxResult_DA;
        private System.Windows.Forms.Label labelOutPut_DA;
        private System.Windows.Forms.TextBox textBoxResult_DA;
        private System.Windows.Forms.GroupBox groupBoxInPut_DA;
        private System.Windows.Forms.Label labelResult_DA;
        private System.Windows.Forms.Label labelInPut_DA;
        private System.Windows.Forms.TextBox textBoxStopStep_DA;
        private System.Windows.Forms.TextBox textBoxStartStep_DA;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.DataGridView dataGridViewFunction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnf;
    }
}

