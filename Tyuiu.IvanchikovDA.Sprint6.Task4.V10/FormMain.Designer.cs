
namespace Tyuiu.IvanchikovDA.Sprint6.Task4.V10
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxTask_DA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_DA = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.labelInPut_DA = new System.Windows.Forms.Label();
            this.labelResult_DA = new System.Windows.Forms.Label();
            this.textBoxStartStep_DA = new System.Windows.Forms.TextBox();
            this.textBoxStopStep_DA = new System.Windows.Forms.TextBox();
            this.chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTask2_DA = new System.Windows.Forms.GroupBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxTask_DA.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_DA
            // 
            this.groupBoxTask_DA.Controls.Add(this.textBoxTask_DA);
            this.groupBoxTask_DA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_DA.Name = "groupBoxTask_DA";
            this.groupBoxTask_DA.Size = new System.Drawing.Size(506, 88);
            this.groupBoxTask_DA.TabIndex = 2;
            this.groupBoxTask_DA.TabStop = false;
            this.groupBoxTask_DA.Text = "Условие";
            // 
            // textBoxTask_DA
            // 
            this.textBoxTask_DA.Location = new System.Drawing.Point(7, 31);
            this.textBoxTask_DA.Multiline = true;
            this.textBoxTask_DA.Name = "textBoxTask_DA";
            this.textBoxTask_DA.ReadOnly = true;
            this.textBoxTask_DA.Size = new System.Drawing.Size(485, 50);
            this.textBoxTask_DA.TabIndex = 1;
            this.textBoxTask_DA.Text = "Протабулировать функцию sin(x) на заданном диапазоне от - 5 до 5.\r\nРезальтат выве" +
    "сти в textBox. Построить график функции и сохранить в файл OutPutFileFask.txt по" +
    " нажатию кнопки.";
            this.textBoxTask_DA.TextChanged += new System.EventHandler(this.textBoxTask_DA_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxStopStep_DA);
            this.groupBox1.Controls.Add(this.textBoxStartStep_DA);
            this.groupBox1.Controls.Add(this.labelResult_DA);
            this.groupBox1.Controls.Add(this.labelInPut_DA);
            this.groupBox1.Location = new System.Drawing.Point(524, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 88);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод данных";
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDone.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonDone.Location = new System.Drawing.Point(870, 26);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(117, 74);
            this.buttonDone.TabIndex = 5;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp.ForeColor = System.Drawing.Color.Black;
            this.buttonHelp.Location = new System.Drawing.Point(1124, 26);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(98, 74);
            this.buttonHelp.TabIndex = 6;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = false;
            // 
            // labelInPut_DA
            // 
            this.labelInPut_DA.AutoSize = true;
            this.labelInPut_DA.Location = new System.Drawing.Point(6, 34);
            this.labelInPut_DA.Name = "labelInPut_DA";
            this.labelInPut_DA.Size = new System.Drawing.Size(67, 13);
            this.labelInPut_DA.TabIndex = 7;
            this.labelInPut_DA.Text = "Старт шага:";
            // 
            // labelResult_DA
            // 
            this.labelResult_DA.AutoSize = true;
            this.labelResult_DA.Location = new System.Drawing.Point(124, 34);
            this.labelResult_DA.Name = "labelResult_DA";
            this.labelResult_DA.Size = new System.Drawing.Size(69, 13);
            this.labelResult_DA.TabIndex = 8;
            this.labelResult_DA.Text = "Конец шага:";
            // 
            // textBoxStartStep_DA
            // 
            this.textBoxStartStep_DA.Location = new System.Drawing.Point(6, 53);
            this.textBoxStartStep_DA.Name = "textBoxStartStep_DA";
            this.textBoxStartStep_DA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartStep_DA.TabIndex = 9;
            // 
            // textBoxStopStep_DA
            // 
            this.textBoxStopStep_DA.Location = new System.Drawing.Point(127, 53);
            this.textBoxStopStep_DA.Name = "textBoxStopStep_DA";
            this.textBoxStopStep_DA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopStep_DA.TabIndex = 10;
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction.Legends.Add(legend1);
            this.chartFunction.Location = new System.Drawing.Point(320, 115);
            this.chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction.Series.Add(series1);
            this.chartFunction.Size = new System.Drawing.Size(913, 542);
            this.chartFunction.TabIndex = 7;
            this.chartFunction.Text = "chartFunction";
            title1.Name = "График функции sin(x)";
            title1.Text = "График функции six(x)";
            this.chartFunction.Titles.Add(title1);
            // 
            // groupBoxTask2_DA
            // 
            this.groupBoxTask2_DA.Location = new System.Drawing.Point(12, 106);
            this.groupBoxTask2_DA.Name = "groupBoxTask2_DA";
            this.groupBoxTask2_DA.Size = new System.Drawing.Size(302, 542);
            this.groupBoxTask2_DA.TabIndex = 8;
            this.groupBoxTask2_DA.TabStop = false;
            this.groupBoxTask2_DA.Text = "Вывод:";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Violet;
            this.buttonSave.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonSave.Location = new System.Drawing.Point(993, 33);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(105, 67);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 660);
            this.Controls.Add(this.groupBoxTask2_DA);
            this.Controls.Add(this.chartFunction);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxTask_DA);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.groupBoxTask_DA.ResumeLayout(false);
            this.groupBoxTask_DA.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_DA;
        private System.Windows.Forms.TextBox textBoxTask_DA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Label labelInPut_DA;
        private System.Windows.Forms.Label labelResult_DA;
        private System.Windows.Forms.TextBox textBoxStartStep_DA;
        private System.Windows.Forms.TextBox textBoxStopStep_DA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private System.Windows.Forms.GroupBox groupBoxTask2_DA;
        private System.Windows.Forms.Button buttonSave;
    }
}

