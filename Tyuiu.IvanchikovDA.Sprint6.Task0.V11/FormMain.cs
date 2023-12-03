using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.IvanchikovDA.Sprint6.Task0.V11.Lib;

namespace Tyuiu.IvanchikovDA.Sprint6.Task0.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_DA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxInPut_DA.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxInPut_DA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
        }
    }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Таск 0 Вариант 11 выполнил студент группы ПКТБ-23-1 Иванчиков Д.А.", "Сообщение");
        }
    }
}
