using System;
using System.Windows.Forms;

namespace Lab2_if9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //событие по нажатию на кнопку
        private void button_solution_Click(object sender, EventArgs e)
        {

        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | Char.IsControl(e.KeyChar) | e.KeyChar == ',' | (e.KeyChar == '-'))
                return;
            else
            {
                MessageBox.Show("Следует вводить только число", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }
    }
}
