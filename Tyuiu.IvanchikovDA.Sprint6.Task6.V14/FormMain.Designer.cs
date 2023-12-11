
namespace Tyuiu.IvanchikovDA.Sprint6.Task6.V14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxTask_DA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_DA = new System.Windows.Forms.TextBox();
            this.textBoxInPut_DA = new System.Windows.Forms.TextBox();
            this.textBoxOutPut_DA = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip();
            this.buttonHelp_DA = new System.Windows.Forms.Button();
            this.buttonDone_DA = new System.Windows.Forms.Button();
            this.buttonOpen_DA = new System.Windows.Forms.Button();
            this.groupBoxTask_DA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_DA
            // 
            this.groupBoxTask_DA.Controls.Add(this.textBoxTask_DA);
            this.groupBoxTask_DA.Location = new System.Drawing.Point(12, 64);
            this.groupBoxTask_DA.Name = "groupBoxTask_DA";
            this.groupBoxTask_DA.Size = new System.Drawing.Size(776, 88);
            this.groupBoxTask_DA.TabIndex = 4;
            this.groupBoxTask_DA.TabStop = false;
            this.groupBoxTask_DA.Text = "Условие";
            // 
            // textBoxTask_DA
            // 
            this.textBoxTask_DA.Location = new System.Drawing.Point(7, 31);
            this.textBoxTask_DA.Multiline = true;
            this.textBoxTask_DA.Name = "textBoxTask_DA";
            this.textBoxTask_DA.ReadOnly = true;
            this.textBoxTask_DA.Size = new System.Drawing.Size(760, 50);
            this.textBoxTask_DA.TabIndex = 1;
            this.textBoxTask_DA.Text = resources.GetString("textBoxTask_DA.Text");
            // 
            // textBoxInPut_DA
            // 
            this.textBoxInPut_DA.Location = new System.Drawing.Point(12, 158);
            this.textBoxInPut_DA.Multiline = true;
            this.textBoxInPut_DA.Name = "textBoxInPut_DA";
            this.textBoxInPut_DA.Size = new System.Drawing.Size(376, 338);
            this.textBoxInPut_DA.TabIndex = 5;
            this.textBoxInPut_DA.Text = "Ввод:";
            // 
            // textBoxOutPut_DA
            // 
            this.textBoxOutPut_DA.Location = new System.Drawing.Point(394, 158);
            this.textBoxOutPut_DA.Multiline = true;
            this.textBoxOutPut_DA.Name = "textBoxOutPut_DA";
            this.textBoxOutPut_DA.Size = new System.Drawing.Size(394, 338);
            this.textBoxOutPut_DA.TabIndex = 6;
            this.textBoxOutPut_DA.Text = "Вывод:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Подсказка";
            // 
            // buttonHelp_DA
            // 
            this.buttonHelp_DA.BackColor = System.Drawing.Color.Transparent;
            this.buttonHelp_DA.ForeColor = System.Drawing.Color.Black;
            this.buttonHelp_DA.Image = global::Tyuiu.IvanchikovDA.Sprint6.Task6.V14.Properties.Resources.zoom;
            this.buttonHelp_DA.Location = new System.Drawing.Point(739, 12);
            this.buttonHelp_DA.Name = "buttonHelp_DA";
            this.buttonHelp_DA.Size = new System.Drawing.Size(40, 38);
            this.buttonHelp_DA.TabIndex = 17;
            this.toolTip1.SetToolTip(this.buttonHelp_DA, "Сведения о программе\r\n");
            this.buttonHelp_DA.UseVisualStyleBackColor = false;
            // 
            // buttonDone_DA
            // 
            this.buttonDone_DA.BackColor = System.Drawing.Color.Transparent;
            this.buttonDone_DA.Image = global::Tyuiu.IvanchikovDA.Sprint6.Task6.V14.Properties.Resources.application_go;
            this.buttonDone_DA.Location = new System.Drawing.Point(63, 12);
            this.buttonDone_DA.Name = "buttonDone_DA";
            this.buttonDone_DA.Size = new System.Drawing.Size(45, 42);
            this.buttonDone_DA.TabIndex = 16;
            this.toolTip1.SetToolTip(this.buttonDone_DA, "Производит поиск вхождений символов \"z\" и конкатенирует строки в который находятс" +
        "я эти симполы\r\n");
            this.buttonDone_DA.UseVisualStyleBackColor = false;
            this.buttonDone_DA.Click += new System.EventHandler(this.buttonDone_DA_Click);
            // 
            // buttonOpen_DA
            // 
            this.buttonOpen_DA.BackColor = System.Drawing.Color.Transparent;
            this.buttonOpen_DA.Image = global::Tyuiu.IvanchikovDA.Sprint6.Task6.V14.Properties.Resources.application_add;
            this.buttonOpen_DA.Location = new System.Drawing.Point(12, 12);
            this.buttonOpen_DA.Name = "buttonOpen_DA";
            this.buttonOpen_DA.Size = new System.Drawing.Size(45, 42);
            this.buttonOpen_DA.TabIndex = 16;
            this.toolTip1.SetToolTip(this.buttonOpen_DA, "Выберите нужный файл для обработки.\r\n");
            this.buttonOpen_DA.UseVisualStyleBackColor = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.buttonHelp_DA);
            this.Controls.Add(this.buttonDone_DA);
            this.Controls.Add(this.buttonOpen_DA);
            this.Controls.Add(this.textBoxOutPut_DA);
            this.Controls.Add(this.textBoxInPut_DA);
            this.Controls.Add(this.groupBoxTask_DA);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.groupBoxTask_DA.ResumeLayout(false);
            this.groupBoxTask_DA.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_DA;
        private System.Windows.Forms.TextBox textBoxTask_DA;
        private System.Windows.Forms.TextBox textBoxInPut_DA;
        private System.Windows.Forms.TextBox textBoxOutPut_DA;
        private System.Windows.Forms.Button buttonOpen_DA;
        private System.Windows.Forms.Button buttonDone_DA;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonHelp_DA;
    }
}

