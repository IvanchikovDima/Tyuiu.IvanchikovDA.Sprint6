using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.IvanchikovDA.Sprint6.Task5.V26.Lib;

namespace Tyuiu.IvanchikovDA.Sprint6.Task5.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
            DataService ds = new DataService();
        string path = @"C:\Users\User\source\repos\Tyuiu.IvanchikovDA.Sprint6\Tyuiu.IvanchikovDA.Sprint6.Task5.V26\bin\Debug\InPutFileTask5V26.txt";
        private void buttonDone_Click(object sender, EventArgs e)

        {
            try
            {
                dataGridView_DA.ColumnCount = 2;
                dataGridView_DA.Columns[0].Width = 20;
                dataGridView_DA.Columns[1].Width = 90;

                this.chartDiagram_DA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartDiagram_DA.ChartAreas[0].AxisY.Title = "Ось Y";

                chartDiagram_DA.Series[0].Points.Clear();

                double[] numsMass = new double[ds.len];

                numsMass = ds.LoadFromDataFile(path);
                this.dataGridView_DA.Rows.Clear();
                for (int i = 0; i < numsMass.Length; i++)
                {
                    this.chartDiagram_DA.Series[0].Points.AddXY(i, numsMass[i]);
                    dataGridView_DA.Rows.Add(i.ToString(), numsMass[i].ToString());
                    dataGridView_DA.Columns[i].Width = 40;
                    dataGridView_DA.Rows[i].Height = 40;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные значения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ПКТб-23-1 Иванчиков Дмитрий Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpen_DA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = @"C:\Users\User\source\repos\Tyuiu.IvanchikovDA.Sprint6\Tyuiu.IvanchikovDA.Sprint6.Task5.V26\bin\Debug\InPutFileTask5V26.txt";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}

  
       