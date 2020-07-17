using System;
using System.Windows.Forms;

namespace Guess
{

   
   
    class Guess
    {
        static int number; //загаданное число
        static int count; //количество попыток

        Random rand = new Random();


        /// <summary>
        /// Отдаем значение, которое загадал компьютер
        /// </summary>
        public int Number { get { return number; } }

        /// <summary>
        /// Отдаем количество попыток
        /// </summary>
        public int Count { get { return count; } }

        /// <summary>
        /// Обнуляем количество попыток
        /// </summary>
        public void Reset()
        {
            count = 0;
        }

        /// <summary>
        /// Комьютер загадывает случайное число от 1 до 100
        /// </summary>
        public void CreateNumber()
        {
            number = rand.Next(1, 101); 
            //System.Windows.Forms.MessageBox.Show($"Я загадал {number}");
        }

        /// <summary>
        /// Увеличиваем количество попыток
        /// </summary>
        public void CountIncrement()
        {
            count++;
        }

        /// <summary>
        /// Проверяем введенное значение на совпадение с загаданным
        /// </summary>
        /// <param name="check"></param>
        /// <param name="userAnswer">Введенное значение</param>
        /// <returns></returns>
        public string CheckUserNumber(out bool check, int userAnswer)
        {
 

            if (userAnswer == number)
            {
                check = true;
                return $"Правильно! Количество попыток:  {count} ";
            }

            else if (userAnswer == 0)
            {
                check = false;
                return "Вводи нормальные значения";
            }

            else if (userAnswer > number)
            {
                check = false;
                return "Многовато!";
            }
            else
            {
                check = false;
                return "Маловато!";
            }
        }

    }
    
}
