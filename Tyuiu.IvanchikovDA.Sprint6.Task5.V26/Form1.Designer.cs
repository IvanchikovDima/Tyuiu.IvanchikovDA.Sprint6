
namespace Tyuiu.IvanchikovDA.Sprint6.Task5.V26
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_DA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_DA = new System.Windows.Forms.TextBox();
            this.buttonDone_DA = new System.Windows.Forms.Button();
            this.buttonHelp_DA = new System.Windows.Forms.Button();
            this.groupBoxTask2_DA = new System.Windows.Forms.GroupBox();
            this.chartDiagram_DA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonOpen_DA = new System.Windows.Forms.Button();
            this.dataGridView_DA = new System.Windows.Forms.DataGridView();
            this.groupBoxTask_DA.SuspendLayout();
            this.groupBoxTask2_DA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiagram_DA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_DA
            // 
            this.groupBoxTask_DA.Controls.Add(this.textBoxTask_DA);
            this.groupBoxTask_DA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_DA.Name = "groupBoxTask_DA";
            this.groupBoxTask_DA.Size = new System.Drawing.Size(506, 88);
            this.groupBoxTask_DA.TabIndex = 3;
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
            this.textBoxTask_DA.Text = "Прочитать данные из файла InPutFileTask5.txt. Вывести в dataGridViev положительны" +
    "е значения и построить диаграмму по этим значениям.";
            // 
            // buttonDone_DA
            // 
            this.buttonDone_DA.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDone_DA.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonDone_DA.Location = new System.Drawing.Point(524, 26);
            this.buttonDone_DA.Name = "buttonDone_DA";
            this.buttonDone_DA.Size = new System.Drawing.Size(94, 74);
            this.buttonDone_DA.TabIndex = 11;
            this.buttonDone_DA.Text = "Выполнить";
            this.buttonDone_DA.UseVisualStyleBackColor = false;
            this.buttonDone_DA.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonHelp_DA
            // 
            this.buttonHelp_DA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_DA.ForeColor = System.Drawing.Color.Black;
            this.buttonHelp_DA.Location = new System.Drawing.Point(714, 26);
            this.buttonHelp_DA.Name = "buttonHelp_DA";
            this.buttonHelp_DA.Size = new System.Drawing.Size(79, 74);
            this.buttonHelp_DA.TabIndex = 12;
            this.buttonHelp_DA.Text = "Справка";
            this.buttonHelp_DA.UseVisualStyleBackColor = false;
            this.buttonHelp_DA.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // groupBoxTask2_DA
            // 
            this.groupBoxTask2_DA.Controls.Add(this.dataGridView_DA);
            this.groupBoxTask2_DA.Location = new System.Drawing.Point(19, 106);
            this.groupBoxTask2_DA.Name = "groupBoxTask2_DA";
            this.groupBoxTask2_DA.Size = new System.Drawing.Size(198, 488);
            this.groupBoxTask2_DA.TabIndex = 13;
            this.groupBoxTask2_DA.TabStop = false;
            this.groupBoxTask2_DA.Text = "Вывод:";
            // 
            // chartDiagram_DA
            // 
            chartArea2.Name = "ChartArea1";
            this.chartDiagram_DA.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartDiagram_DA.Legends.Add(legend2);
            this.chartDiagram_DA.Location = new System.Drawing.Point(223, 106);
            this.chartDiagram_DA.Name = "chartDiagram_DA";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartDiagram_DA.Series.Add(series2);
            this.chartDiagram_DA.Size = new System.Drawing.Size(587, 479);
            this.chartDiagram_DA.TabIndex = 14;
            this.chartDiagram_DA.Text = "chart1";
            // 
            // buttonOpen_DA
            // 
            this.buttonOpen_DA.BackColor = System.Drawing.Color.DarkOrchid;
            this.buttonOpen_DA.Location = new System.Drawing.Point(624, 26);
            this.buttonOpen_DA.Name = "buttonOpen_DA";
            this.buttonOpen_DA.Size = new System.Drawing.Size(84, 74);
            this.buttonOpen_DA.TabIndex = 15;
            this.buttonOpen_DA.Text = "Открыть файл";
            this.buttonOpen_DA.UseVisualStyleBackColor = false;
            this.buttonOpen_DA.Click += new System.EventHandler(this.buttonOpen_DA_Click);
            // 
            // dataGridView_DA
            // 
            this.dataGridView_DA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DA.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_DA.Name = "dataGridView_DA";
            this.dataGridView_DA.Size = new System.Drawing.Size(186, 459);
            this.dataGridView_DA.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 596);
            this.Controls.Add(this.buttonOpen_DA);
            this.Controls.Add(this.chartDiagram_DA);
            this.Controls.Add(this.groupBoxTask2_DA);
            this.Controls.Add(this.buttonHelp_DA);
            this.Controls.Add(this.buttonDone_DA);
            this.Controls.Add(this.groupBoxTask_DA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 5 | Вариант 26 | Иванчиков Д.А. ";
            this.groupBoxTask_DA.ResumeLayout(false);
            this.groupBoxTask_DA.PerformLayout();
            this.groupBoxTask2_DA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDiagram_DA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_DA;
        private System.Windows.Forms.TextBox textBoxTask_DA;
        private System.Windows.Forms.Button buttonDone_DA;
        private System.Windows.Forms.Button buttonHelp_DA;
        private System.Windows.Forms.GroupBox groupBoxTask2_DA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiagram_DA;
        private System.Windows.Forms.Button buttonOpen_DA;
        private System.Windows.Forms.DataGridView dataGridView_DA;
    }
}

