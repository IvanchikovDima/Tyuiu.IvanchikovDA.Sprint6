using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.IvanchikovDA.Sprint6.Task1.V23.Lib;

namespace Tyuiu.IvanchikovDA.Sprint6.Task1.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        DataService ds = new DataService();
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_DA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_DA.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_DA.Text = "";
                textBoxResult_DA.AppendText("+----------+----------" + Environment.NewLine);
                textBoxResult_DA.AppendText("     X     |    f(x)  " + Environment.NewLine);
                textBoxResult_DA.AppendText("+----------+----------" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}    |  {1, 5:f2   | ", startStep, valueArray[i]);
                    textBoxResult_DA.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_DA.AppendText("+----------+----------" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Таск 1 Вариант 23 выполнил студент группы ПКТБ-23-1 Иванчиков Д.А.", "Сообщение");
        }
    }
}