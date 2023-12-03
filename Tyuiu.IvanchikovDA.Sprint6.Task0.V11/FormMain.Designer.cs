
namespace Tyuiu.IvanchikovDA.Sprint6.Task0.V11
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
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula = new System.Windows.Forms.PictureBox();
            this.groupBoxInPut = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPut = new System.Windows.Forms.GroupBox();
            this.textBoxResult_DA = new System.Windows.Forms.TextBox();
            this.labelRes_DA = new System.Windows.Forms.Label();
            this.textBoxInPut_DA = new System.Windows.Forms.TextBox();
            this.labelX_DA = new System.Windows.Forms.Label();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula)).BeginInit();
            this.groupBoxInPut.SuspendLayout();
            this.groupBoxOutPut.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.pictureBoxFormula);
            this.groupBoxTask.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Size = new System.Drawing.Size(776, 170);
            this.groupBoxTask.TabIndex = 0;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Условие";
            // 
            // pictureBoxFormula
            // 
            this.pictureBoxFormula.Image = global::Tyuiu.IvanchikovDA.Sprint6.Task0.V11.Properties.Resources._1;
            this.pictureBoxFormula.Location = new System.Drawing.Point(6, 25);
            this.pictureBoxFormula.Name = "pictureBoxFormula";
            this.pictureBoxFormula.Size = new System.Drawing.Size(506, 145);
            this.pictureBoxFormula.TabIndex = 0;
            this.pictureBoxFormula.TabStop = false;
            // 
            // groupBoxInPut
            // 
            this.groupBoxInPut.Controls.Add(this.labelX_DA);
            this.groupBoxInPut.Controls.Add(this.textBoxInPut_DA);
            this.groupBoxInPut.Location = new System.Drawing.Point(12, 204);
            this.groupBoxInPut.Name = "groupBoxInPut";
            this.groupBoxInPut.Size = new System.Drawing.Size(402, 140);
            this.groupBoxInPut.TabIndex = 1;
            this.groupBoxInPut.TabStop = false;
            this.groupBoxInPut.Text = "Ввод данных:";
            // 
            // groupBoxOutPut
            // 
            this.groupBoxOutPut.Controls.Add(this.labelRes_DA);
            this.groupBoxOutPut.Controls.Add(this.textBoxResult_DA);
            this.groupBoxOutPut.Location = new System.Drawing.Point(429, 244);
            this.groupBoxOutPut.Name = "groupBoxOutPut";
            this.groupBoxOutPut.Size = new System.Drawing.Size(200, 100);
            this.groupBoxOutPut.TabIndex = 2;
            this.groupBoxOutPut.TabStop = false;
            this.groupBoxOutPut.Text = "Вывод данных:";
            // 
            // textBoxResult_DA
            // 
            this.textBoxResult_DA.Location = new System.Drawing.Point(7, 61);
            this.textBoxResult_DA.Name = "textBoxResult_DA";
            this.textBoxResult_DA.ReadOnly = true;
            this.textBoxResult_DA.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult_DA.TabIndex = 0;
            // 
            // labelRes_DA
            // 
            this.labelRes_DA.AutoSize = true;
            this.labelRes_DA.Location = new System.Drawing.Point(7, 42);
            this.labelRes_DA.Name = "labelRes_DA";
            this.labelRes_DA.Size = new System.Drawing.Size(62, 13);
            this.labelRes_DA.TabIndex = 1;
            this.labelRes_DA.Text = "Результат:";
            // 
            // textBoxInPut_DA
            // 
            this.textBoxInPut_DA.Location = new System.Drawing.Point(7, 101);
            this.textBoxInPut_DA.Name = "textBoxInPut_DA";
            this.textBoxInPut_DA.Size = new System.Drawing.Size(100, 20);
            this.textBoxInPut_DA.TabIndex = 0;
            this.textBoxInPut_DA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInPut_DA_KeyPress);
            // 
            // labelX_DA
            // 
            this.labelX_DA.AutoSize = true;
            this.labelX_DA.Location = new System.Drawing.Point(7, 82);
            this.labelX_DA.Name = "labelX_DA";
            this.labelX_DA.Size = new System.Drawing.Size(84, 13);
            this.labelX_DA.TabIndex = 1;
            this.labelX_DA.Text = "Переменная X:";
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(470, 385);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(159, 42);
            this.buttonDone.TabIndex = 3;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Location = new System.Drawing.Point(422, 385);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(42, 42);
            this.buttonHelp.TabIndex = 4;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.groupBoxOutPut);
            this.Controls.Add(this.groupBoxInPut);
            this.Controls.Add(this.groupBoxTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBoxTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula)).EndInit();
            this.groupBoxInPut.ResumeLayout(false);
            this.groupBoxInPut.PerformLayout();
            this.groupBoxOutPut.ResumeLayout(false);
            this.groupBoxOutPut.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.PictureBox pictureBoxFormula;
        private System.Windows.Forms.GroupBox groupBoxInPut;
        private System.Windows.Forms.Label labelX_DA;
        private System.Windows.Forms.TextBox textBoxInPut_DA;
        private System.Windows.Forms.GroupBox groupBoxOutPut;
        private System.Windows.Forms.Label labelRes_DA;
        private System.Windows.Forms.TextBox textBoxResult_DA;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonHelp;
    }
}

