using System;
using System.Collections.Generic;

namespace Doubler
{


    /// <summary>
    /// Делегат для функций, отменяющих ход
    /// </summary>
    public delegate void cancelFunc();
    class Doubler
    {

         int number; // изменяемое число
         int moves; // количество шагов
         int goalNumber; // число, которое нужно получить

        Stack<cancelFunc> movesToCancel = new Stack<cancelFunc>();


        Random rand = new Random();

         /// <summary>
         /// Возвращает значение number
         /// </summary>
         public int Number { get { return this.number; } }

         /// <summary>
         /// Возвращает значение moves
         /// </summary>
         public int Moves { get { return this.moves; } }

         /// <summary>
         /// Возвращает значение goalNumber
         /// </summary>
         public int GoalNumber { get { return this.goalNumber; } }

         /// <summary>
         /// Конструктор, присваивающий начальные значения
         /// </summary>
         public Doubler()
         {
            this.number = 0;
            this.moves = 0;
            this.goalNumber = 0;
         }
        
         /// <summary>
         /// Прибавление 1
         /// </summary>
         public void Increment()
         {
            this.number++;
            this.moves++;
            movesToCancel.Push(new cancelFunc(Decrement));
         }

         /// <summary>
         /// Вычитание 1
         /// </summary>
         public void Decrement()
         {
            this.number--;
            this.moves--;
        }

         /// <summary>
         /// Умножение на 2
         /// </summary>
         public void MultiplyBy2()
         {
            this.number *= 2;
            this.moves++;
            movesToCancel.Push(new cancelFunc(DivisionBy2));
        }

         /// <summary>
         /// Деление на 2
         /// </summary>
         public void DivisionBy2()
         {
            this.number /= 2;
            this.moves--;
         }

        /// <summary>
        /// Возвращает начальные значения
        /// </summary>
        public void Reset()
         {
            this.number = 0;
            this.moves = 0;
             //operations.Clear();
         }

         /// <summary>
         /// Получение необходимого значения для игры
         /// </summary>
         public void NewGoalNumber()
         {
            this.goalNumber = rand.Next(1, 100);
         }

         /// <summary>
         /// Проверяем, не равно ли полученное значение необходимому
         /// </summary>
         /// <returns></returns>
         public bool CheckNumber()
         {
            return this.goalNumber == this.number ? true : false;
         }

         /// <summary>
         /// Берем из стэка последнюю добавленную функцию
         /// </summary>
         public void CheckStack()
         {
            cancelFunc cancelFunc;
            if (movesToCancel.Count != 0)
            {
                cancelFunc = movesToCancel.Pop();
                cancelFunc();
            }
            return;
         }

         /// <summary>
         /// Очищаем стэк
         /// </summary>
         public void ClearStack()
         {
            movesToCancel.Clear();
         }


    }


   
    
}
