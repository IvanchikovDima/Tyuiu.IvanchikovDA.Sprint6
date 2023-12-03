using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMyAppFirst
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonPushMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Привет, Мир!", "Сообщение");
        }

        private void buttonPushMe_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxVarA_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try

            {
                if (radioButtonPlus.Checked)
                {
                    int a = Convert.ToInt32(textBoxVarA.Text);
                    int b = Convert.ToInt32(textBoxVarB.Text);

                    int c = a + b;

                    textBoxResult.Text = Convert.ToString(c);
                }

                if (radioButtonMinus.Checked)
                {
                    int a = Convert.ToInt32(textBoxVarA.Text);
                    int b = Convert.ToInt32(textBoxVarB.Text);

                    int c = a - b;

                    textBoxResult.Text = Convert.ToString(c);
                }

                if (radioButtonMult.Checked)
                {
                    int a = Convert.ToInt32(textBoxVarA.Text);
                    int b = Convert.ToInt32(textBoxVarB.Text);

                    int c = a * b;

                    textBoxResult.Text = Convert.ToString(c);
                }

                if (radioButtonDiv.Checked)
                {
                    double a = Convert.ToDouble(textBoxVarA.Text);
                    double b = Convert.ToDouble(textBoxVarB.Text);

                    double z = a / b;

                    textBoxResult.Text = Convert.ToString(z);
                }
            }
            catch
            {
                MessageBox.Show("Неверный ввод данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
