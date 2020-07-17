using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doubler
{
   /// Студент Зайцева Дарья
   /// Задание 1. Удвоитель
   /// а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
   /// б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок.
   /// Игрок должен получить это число за минимальное количество ходов.
   /// в) * Добавить кнопку «Отменить», которая отменяет последние ходы.Используйте обобщенный класс Stack.
   ///Вся логика игры должна быть реализована в классе с удвоителем.


    public partial class Form1 : Form
    {
        Doubler doubler;
        bool isPlay = false;

        public Form1()
        {
            doubler = new Doubler();
            InitializeComponent();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            lblNumber.Text = "0";
            btnReset.Text = "Сброс";
            this.Text = "Удвоитель";
            btnCancel.Text = "Отменить ход";
            movesText.Text = "Количество ходов:";
            movesNumber.Text = "0";
            goalNumberText.Text = "Необходимое значение";
            goalNumber.Text = "0";
            


        }
        /// <summary>
        /// Меняем в форме значения number и moves
        /// Проверяем результат, если идет игра
        /// </summary>
        public void FormUpdate()
        {
            lblNumber.Text = doubler.Number.ToString();
            movesNumber.Text = doubler.Moves.ToString();

            if(isPlay)
            {
                if(doubler.CheckNumber())
                {
                    MessageBox.Show($"Число получено! \n Ходов: {doubler.Moves}");
                    goalNumber.Text = "0";
                    isPlay = false;
                    doubler.Reset();
                    movesNumber.Text = "0";
                    lblNumber.Text = "0";
                    doubler.ClearStack();


                }
            }
        }

        /// <summary>
        /// Нажатие на кнопку "+1"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCommand1_Click(object sender, EventArgs e)
        {

            doubler.Increment();
            FormUpdate();
        }

        /// <summary>
        /// Нажатие на кнопку "x2"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCommand2_Click(object sender, EventArgs e)
        {
            doubler.MultiplyBy2();
            FormUpdate();
        }

        /// <summary>
        /// Нажатие на кнопку "Сброс"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            doubler.Reset();
            FormUpdate();
            doubler.ClearStack();
        }

        
        /// <summary>
        /// Нажатие на кнопку "Отменить ход"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {

            doubler.CheckStack();
            FormUpdate();
        }

        /// <summary>
        /// Нажатие на пукт "Play" в меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doubler.NewGoalNumber();
            MessageBox.Show($"Необходимое значение : {doubler.GoalNumber}");
            goalNumber.Text = doubler.GoalNumber.ToString();
            doubler.Reset();
            FormUpdate();
            doubler.ClearStack();
            isPlay = true;

        }

       
    }
}
