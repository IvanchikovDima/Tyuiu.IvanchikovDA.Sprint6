
namespace WindowsFormsMyAppFirst
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
            this.buttonPushMe = new System.Windows.Forms.Button();
            this.groupBoxInputData = new System.Windows.Forms.GroupBox();
            this.radioButtonDiv = new System.Windows.Forms.RadioButton();
            this.radioButtonMinus = new System.Windows.Forms.RadioButton();
            this.radioButtonMult = new System.Windows.Forms.RadioButton();
            this.radioButtonPlus = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelVarB = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelVarA = new System.Windows.Forms.Label();
            this.textBoxVarB = new System.Windows.Forms.TextBox();
            this.textBoxVarA = new System.Windows.Forms.TextBox();
            this.groupBoxOutPutData = new System.Windows.Forms.GroupBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.groupBoxInputData.SuspendLayout();
            this.groupBoxOutPutData.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPushMe
            // 
            this.buttonPushMe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPushMe.Location = new System.Drawing.Point(382, 53);
            this.buttonPushMe.Name = "buttonPushMe";
            this.buttonPushMe.Size = new System.Drawing.Size(93, 32);
            this.buttonPushMe.TabIndex = 0;
            this.buttonPushMe.Text = "Нажми меня";
            this.buttonPushMe.UseVisualStyleBackColor = true;
            this.buttonPushMe.Click += new System.EventHandler(this.buttonPushMe_Click_1);
            // 
            // groupBoxInputData
            // 
            this.groupBoxInputData.Controls.Add(this.radioButtonDiv);
            this.groupBoxInputData.Controls.Add(this.radioButtonMinus);
            this.groupBoxInputData.Controls.Add(this.radioButtonMult);
            this.groupBoxInputData.Controls.Add(this.radioButtonPlus);
            this.groupBoxInputData.Controls.Add(this.label4);
            this.groupBoxInputData.Controls.Add(this.label2);
            this.groupBoxInputData.Controls.Add(this.labelVarB);
            this.groupBoxInputData.Controls.Add(this.label3);
            this.groupBoxInputData.Controls.Add(this.label1);
            this.groupBoxInputData.Controls.Add(this.labelVarA);
            this.groupBoxInputData.Controls.Add(this.textBoxVarB);
            this.groupBoxInputData.Controls.Add(this.textBoxVarA);
            this.groupBoxInputData.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInputData.Name = "groupBoxInputData";
            this.groupBoxInputData.Size = new System.Drawing.Size(232, 135);
            this.groupBoxInputData.TabIndex = 1;
            this.groupBoxInputData.TabStop = false;
            this.groupBoxInputData.Text = "Ввод данных:";
            this.groupBoxInputData.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButtonDiv
            // 
            this.radioButtonDiv.AutoSize = true;
            this.radioButtonDiv.Location = new System.Drawing.Point(149, 84);
            this.radioButtonDiv.Name = "radioButtonDiv";
            this.radioButtonDiv.Size = new System.Drawing.Size(30, 17);
            this.radioButtonDiv.TabIndex = 2;
            this.radioButtonDiv.TabStop = true;
            this.radioButtonDiv.Text = "/";
            this.radioButtonDiv.UseVisualStyleBackColor = true;
            // 
            // radioButtonMinus
            // 
            this.radioButtonMinus.AutoSize = true;
            this.radioButtonMinus.Location = new System.Drawing.Point(149, 42);
            this.radioButtonMinus.Name = "radioButtonMinus";
            this.radioButtonMinus.Size = new System.Drawing.Size(28, 17);
            this.radioButtonMinus.TabIndex = 2;
            this.radioButtonMinus.TabStop = true;
            this.radioButtonMinus.Text = "-";
            this.radioButtonMinus.UseVisualStyleBackColor = true;
            // 
            // radioButtonMult
            // 
            this.radioButtonMult.AutoSize = true;
            this.radioButtonMult.Location = new System.Drawing.Point(112, 83);
            this.radioButtonMult.Name = "radioButtonMult";
            this.radioButtonMult.Size = new System.Drawing.Size(29, 17);
            this.radioButtonMult.TabIndex = 2;
            this.radioButtonMult.TabStop = true;
            this.radioButtonMult.Text = "*";
            this.radioButtonMult.UseVisualStyleBackColor = true;
            // 
            // radioButtonPlus
            // 
            this.radioButtonPlus.AutoSize = true;
            this.radioButtonPlus.Location = new System.Drawing.Point(112, 42);
            this.radioButtonPlus.Name = "radioButtonPlus";
            this.radioButtonPlus.Size = new System.Drawing.Size(31, 17);
            this.radioButtonPlus.TabIndex = 2;
            this.radioButtonPlus.TabStop = true;
            this.radioButtonPlus.Text = "+";
            this.radioButtonPlus.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Переменная B:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Переменная B:";
            // 
            // labelVarB
            // 
            this.labelVarB.AutoSize = true;
            this.labelVarB.Location = new System.Drawing.Point(6, 67);
            this.labelVarB.Name = "labelVarB";
            this.labelVarB.Size = new System.Drawing.Size(84, 13);
            this.labelVarB.TabIndex = 1;
            this.labelVarB.Text = "Переменная B:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Переменная А:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Переменная А:";
            // 
            // labelVarA
            // 
            this.labelVarA.AutoSize = true;
            this.labelVarA.Location = new System.Drawing.Point(6, 26);
            this.labelVarA.Name = "labelVarA";
            this.labelVarA.Size = new System.Drawing.Size(84, 13);
            this.labelVarA.TabIndex = 1;
            this.labelVarA.Text = "Переменная А:";
            // 
            // textBoxVarB
            // 
            this.textBoxVarB.Location = new System.Drawing.Point(6, 83);
            this.textBoxVarB.Name = "textBoxVarB";
            this.textBoxVarB.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarB.TabIndex = 0;
            // 
            // textBoxVarA
            // 
            this.textBoxVarA.Location = new System.Drawing.Point(6, 42);
            this.textBoxVarA.Name = "textBoxVarA";
            this.textBoxVarA.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarA.TabIndex = 0;
            this.textBoxVarA.TextChanged += new System.EventHandler(this.textBoxVarA_TextChanged);
            // 
            // groupBoxOutPutData
            // 
            this.groupBoxOutPutData.Controls.Add(this.labelResult);
            this.groupBoxOutPutData.Controls.Add(this.textBoxResult);
            this.groupBoxOutPutData.Location = new System.Drawing.Point(12, 153);
            this.groupBoxOutPutData.Name = "groupBoxOutPutData";
            this.groupBoxOutPutData.Size = new System.Drawing.Size(135, 120);
            this.groupBoxOutPutData.TabIndex = 2;
            this.groupBoxOutPutData.TabStop = false;
            this.groupBoxOutPutData.Text = "Вывод данных:";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(6, 20);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(62, 13);
            this.labelResult.TabIndex = 1;
            this.labelResult.Text = "Результат:";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(6, 37);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult.TabIndex = 0;
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(169, 188);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(75, 23);
            this.buttonDone.TabIndex = 3;
            this.buttonDone.Text = "Выполнить:";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.groupBoxOutPutData);
            this.Controls.Add(this.groupBoxInputData);
            this.Controls.Add(this.buttonPushMe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 300);
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мое первое приложение";
            this.groupBoxInputData.ResumeLayout(false);
            this.groupBoxInputData.PerformLayout();
            this.groupBoxOutPutData.ResumeLayout(false);
            this.groupBoxOutPutData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPushMe;
        private System.Windows.Forms.GroupBox groupBoxInputData;
        private System.Windows.Forms.Label labelVarA;
        private System.Windows.Forms.TextBox textBoxVarB;
        private System.Windows.Forms.TextBox textBoxVarA;
        private System.Windows.Forms.GroupBox groupBoxOutPutData;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelVarB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.RadioButton radioButtonDiv;
        private System.Windows.Forms.RadioButton radioButtonMinus;
        private System.Windows.Forms.RadioButton radioButtonMult;
        private System.Windows.Forms.RadioButton radioButtonPlus;
    }
}

