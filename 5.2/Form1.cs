using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Red;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Green;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Blue;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            float ch = float.Parse(comboBox1.SelectedItem.ToString());
            label3.Font = new Font(label3.Font.Name, ch, label3.Font.Style);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
