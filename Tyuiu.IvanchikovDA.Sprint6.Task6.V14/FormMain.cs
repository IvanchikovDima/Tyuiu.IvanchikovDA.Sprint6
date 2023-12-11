using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.IvanchikovDA.Sprint6.Task6.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void buttonDone_DA_Click(object sender, EventArgs e)
        {
            string str = "z";
            textBoxOutPut_DA.Text = ds.CollectTextFromFile(str, openFilePath);
        }
    }
}
