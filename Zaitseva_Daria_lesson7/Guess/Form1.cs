using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess
{
    //Студент Зайцева Дарья
    //Задание 2. Используя Windows Forms, разработать игру «Угадай число». 
    //Компьютер загадывает число от 1 до 100, а человек пытается его угадать 
    //за минимальное число попыток. Компьютер говорит, больше или меньше загаданное 
    //число введенного.
    //a) Для ввода данных от человека используется элемент TextBox;
    //б) ** Реализовать отдельную форму c TextBox для ввода числа.

    public partial class Form1 : Form
    {

        Form2 form2;
        Guess guess;
        public Form1()
        {

            guess = new Guess();

            InitializeComponent();
            lblMainText.Text = "Я компьютер. Я загадываю числа от 1 до 100.\nА ты угадывай, кожаный ублюдок!";
            lblAttemptNumberText.Text = "Попыток: ";
            lblAttemptNumber.Text = "0";
            btnStart.Text = "Начать";
            this.Text = "Угадай число";

            form2 = new Form2(this);
            
        }

        /// <summary>
        /// Обновляем количество попыток
        /// </summary>
        public void FormUpdate()
        {
            lblAttemptNumber.Text = guess.Count.ToString();
        }

    

        private void btnStart_Click(object sender, EventArgs e)
        {
            guess.CreateNumber();
            guess.Reset();
            FormUpdate();
            MessageBox.Show("Загадал! Угадывай теперь!");
            form2.Show();

        }
    }
}
