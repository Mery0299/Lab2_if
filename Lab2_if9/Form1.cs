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
            //проверка введённого значения
            if (!float.TryParse(textBox_firstNum.Text, out float firstNum))
            {
                MessageBox.Show("Вы неверно ввели первое число", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!float.TryParse(textBox_secondNum.Text, out float secondNum))
            {
                MessageBox.Show("Вы неверно ввели второе число", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!float.TryParse(textBox_thirdNum.Text, out float thirdNum))
            {
                MessageBox.Show("Вы неверно ввели третье число", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            float[] nums = new float[] { firstNum, secondNum, thirdNum };
            if (Logic.Check(nums))
            {
                label_answer.Text = Logic.Solution(nums).ToString();
            }
            else
            {
                label_answer.Text = "Числа не являются различными";
            }
        }

        //событие запрета ввода символов
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
